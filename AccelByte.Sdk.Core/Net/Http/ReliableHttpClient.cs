// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Web;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class ReliableHttpClient : IHttpClient
    {
        public static readonly ReliableHttpClientBuilder Builder = new ReliableHttpClientBuilder();

        protected static List<int> _RedirectCodes = new List<int>() { 308, 307, 300, 301, 302, 303 };

        public static HttpClient? Http { get; private set; }

        private HttpLoggingHandler? _LoggingHandler = null;

        private IHttpClientPolicy _Policy;

        private Action<HttpRequestMessage, int>? _BeforeSend = null;

        internal ReliableHttpClient(ReliableHttpClientBuilder builder)
        {
            if (builder.Http != null)
                Http = builder.Http;
            else
            {
                if (builder.HttpHandler != null)
                {
                    _LoggingHandler = new HttpLoggingHandler(builder.HttpHandler);
                    Http = new HttpClient(_LoggingHandler);
                }
                else
                {
                    _LoggingHandler = new HttpLoggingHandler(new HttpClientHandler()
                    {
                        AllowAutoRedirect = false
                    });
                    Http = new HttpClient(_LoggingHandler);
                }
            }

            _Policy = builder.DefaultPolicy;
            if ((builder.Logger != null) && (_LoggingHandler != null))
                _LoggingHandler.Logger = builder.Logger;

            _BeforeSend = builder.BeforeSend;
        }

        public IHttpClient SetLogger(IHttpLogger logger)
        {
            if (_LoggingHandler != null)
                _LoggingHandler.Logger = logger;
            return this;
        }

        protected HttpRequestMessage CreateRequestMessage(IOperation operation, string baseURL)
        {
            Dictionary<string, string> headers = operation.HeaderParams;

            var reqContentType = string.Empty;

            if (operation.Consumes.Any())
            {
                reqContentType = operation.Consumes.First();
                headers["Content-Type"] = reqContentType;
            }

            if (operation.Produces.Any())
                headers["Accept"] = operation.Produces.First();

            var url = operation.GetUrl(baseURL);
            var request = new HttpRequestMessage(operation.Method, url);

            if (operation.BodyParams != null)
            {
                if (reqContentType == String.Empty)
                {
                    reqContentType = "application/json";
                    headers["Content-Type"] = reqContentType;
                }

                if (IsMediaTypeJson(reqContentType))
                {
                    var jsonString = JsonSerializer.Serialize(operation.BodyParams, operation.RequestJsonOptions);
                    request.Content = new StringContent(jsonString, Encoding.UTF8, reqContentType);
                }
                else
                {
                    var bodyString = operation.BodyParams.ToString()!;
                    request.Content = new StringContent(bodyString, Encoding.UTF8, reqContentType);
                }
            }
            else if (operation.FormParams.Any())
            {
                switch (reqContentType)
                {
                    case "application/x-www-form-urlencoded":
                        var formUrlEncoded = operation.FormParams.ToDictionary(kvp => kvp.Key, kvp => (string)kvp.Value);
                        request.Content = new FormUrlEncodedContent(formUrlEncoded);
                        break;
                    case "multipart/form-data":
                        var boundary = $"Upload----{DateTime.Now.ToString(CultureInfo.InvariantCulture)}";
                        var content = new MultipartFormDataContent(boundary);
                        foreach (var kvp in operation.FormParams)
                        {
                            if (kvp.Value is string str)
                            {
                                content.Add(new StringContent(str), kvp.Key);
                            }
                            else if (kvp.Value is Stream stream)
                            {
                                StreamContent fsStream = new StreamContent(stream);
                                if (kvp.Value is IUploadStream)
                                {
                                    IUploadStream uploadStream = (IUploadStream)kvp.Value;
                                    fsStream.Headers.ContentType = new MediaTypeHeaderValue(uploadStream.MimeType);
                                    content.Add(fsStream, kvp.Key, uploadStream.FileName);
                                }
                                else
                                {
                                    fsStream.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                                    content.Add(fsStream, kvp.Key, "name.bin");
                                }
                            }
                            else
                            {
                                throw new NotSupportedException($"Unsupported multipart form data type (content type: {kvp.Value.GetType()})");
                            }
                        }
                        headers["Content-Type"] = ("multipart/form-data; boundary=" + boundary);
                        request.Content = content;
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported form content type (content type: {reqContentType})");
                }
            }

            foreach (var h in headers)
            {
                if (h.Key == "User-Agent")
                    request.Headers.UserAgent.ParseAdd(h.Value);
                else if (h.Key == "Accept")
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(h.Value));
                else if (h.Key == "Authorization")
                {
                    var authorization = h.Value.Split(' ');
                    request.Headers.Authorization = new AuthenticationHeaderValue(authorization[0], authorization[1]);
                }
                else
                    request.Headers.TryAddWithoutValidation(h.Key, h.Value);
            }

            if (operation.Cookies.Count > 0)
            {
                List<string> cEntries = new List<string>();
                foreach (var c in operation.Cookies)
                    cEntries.Add(c.Key + "=" + HttpUtility.UrlEncode(c.Value, Encoding.UTF8));
                request.Headers.TryAddWithoutValidation("Cookie", String.Join("; ", cEntries));
            }

            return request;
        }

        public IHttpResponse SendRequest(IOperation operation, string baseURL)
        {
            if (Http == null)
                throw new Exception("HttpClient object is null.");

            IHttpClientPolicy policy = _Policy;
            if (operation.HttpClientPolicy != null)
                policy = _Policy.MergeWith(operation.HttpClientPolicy);

            int retryCount = 0;
            while (true)
            {
                try
                {
                    HttpRequestMessage request = CreateRequestMessage(operation, baseURL);
                    if (policy.AddRetryCountToHeaders!.Value)
                        request.Headers.TryAddWithoutValidation("X-Client-Retry-Count", retryCount.ToString());

                    _BeforeSend?.Invoke(request, retryCount);

                    HttpResponseMessage response;
                    using (var cts = new CancellationTokenSource(policy.RequestTimeOut!.Value * 1000))
                    {
                        Task<HttpResponseMessage> sendTask = Http.SendAsync(request, cts.Token);
                        sendTask.Wait();
                        response = sendTask.Result;
                    }

                    string respContentType = String.Empty;
                    IEnumerable<string>? ctValues = null;
                    if (response.Headers.TryGetValues("Content-Type", out ctValues))
                        respContentType = String.Join(",", ctValues).Trim();

                    if (respContentType != String.Empty)
                    {
                        string[] ctSplits = respContentType.Split(';');
                        if (ctSplits.Length > 0)
                            respContentType = ctSplits[0].Trim();
                    }

                    int responseCode = (int)response.StatusCode;
                    if (_RedirectCodes.Contains(responseCode))
                    {
                        var location = response.Headers.Location ??
                                throw new Exception($"Location header is null (status code: {response.StatusCode})");

                        Stream payload = new MemoryStream(Encoding.UTF8.GetBytes(location.OriginalString));
                        return new HttpResponse(response.StatusCode, respContentType, payload);
                    }
                    else
                    {
                        Stream payload;
                        if (response.Content != null)
                            payload = response.Content.ReadAsStream();
                        else
                            payload = new MemoryStream();

                        if ((responseCode >= 200) && (responseCode < 300))
                        {
                            return new HttpResponse(response.StatusCode, respContentType, payload);
                        }
                        else
                        {
                            throw new HttpRequestException(response.StatusCode, respContentType, payload);
                        }
                    }
                }
                catch (SocketException xSocket)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xSocket))
                            throw xSocket;
                        else
                            retryCount++;
                    }
                    else
                        throw xSocket;
                }
                catch (HttpRequestException xHttpReq)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xHttpReq))
                            return xHttpReq.AsHttpResponse;
                        else
                            retryCount++;
                    }
                    else
                        return xHttpReq.AsHttpResponse;
                }
                catch (TaskCanceledException xTask)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        HttpRequestTimeoutException toException = new HttpRequestTimeoutException(xTask);
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                        else
                            retryCount++;
                    }
                    else
                        throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                }
                catch (AggregateException x)
                {
                    if (x.InnerException is TaskCanceledException)
                    {
                        if (policy.RetryLogicHandler != null)
                        {
                            HttpRequestTimeoutException toException = new HttpRequestTimeoutException(x.InnerException);
                            if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                                throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                            else
                                retryCount++;
                        }
                        else
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                    }
                    else
                        throw new Exception(x.Message, x);
                }
                catch (Exception x)
                {
                    throw new Exception(x.Message, x);
                }
            }
        }

        public async Task<IHttpResponse> SendRequestAsync(IOperation operation, string baseURL)
        {
            if (Http == null)
                throw new Exception("HttpClient object is null.");

            IHttpClientPolicy policy = _Policy;
            if (operation.HttpClientPolicy != null)
                policy = _Policy.MergeWith(operation.HttpClientPolicy);

            int retryCount = 0;
            while (true)
            {
                try
                {
                    HttpRequestMessage request = CreateRequestMessage(operation, baseURL);
                    if (policy.AddRetryCountToHeaders!.Value)
                        request.Headers.TryAddWithoutValidation("X-Client-Retry-Count", retryCount.ToString());

                    _BeforeSend?.Invoke(request, retryCount);

                    HttpResponseMessage response;
                    using (var cts = new CancellationTokenSource(policy.RequestTimeOut!.Value * 1000))
                    {
                        response = await Http.SendAsync(request, cts.Token);
                    }

                    string respContentType = String.Empty;
                    IEnumerable<string>? ctValues = null;
                    if (response.Headers.TryGetValues("Content-Type", out ctValues))
                        respContentType = String.Join(",", ctValues).Trim();

                    if (respContentType != String.Empty)
                    {
                        string[] ctSplits = respContentType.Split(';');
                        if (ctSplits.Length > 0)
                            respContentType = ctSplits[0].Trim();
                    }

                    int responseCode = (int)response.StatusCode;
                    if (_RedirectCodes.Contains(responseCode))
                    {
                        var location = response.Headers.Location ??
                                throw new Exception($"Location header is null (status code: {response.StatusCode})");

                        Stream payload = new MemoryStream(Encoding.UTF8.GetBytes(location.OriginalString));
                        return new HttpResponse(response.StatusCode, respContentType, payload);
                    }
                    else
                    {
                        Stream payload;
                        if (response.Content != null)
                            payload = response.Content.ReadAsStream();
                        else
                            payload = new MemoryStream();

                        if ((responseCode >= 200) && (responseCode < 300))
                        {
                            return new HttpResponse(response.StatusCode, respContentType, payload);
                        }
                        else
                        {
                            throw new HttpRequestException(response.StatusCode, respContentType, payload);
                        }
                    }
                }
                catch (SocketException xSocket)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xSocket))
                            throw;
                        else
                            retryCount++;
                    }
                    else
                        throw;
                }
                catch (HttpRequestException xHttpReq)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, xHttpReq))
                            return xHttpReq.AsHttpResponse;
                        else
                            retryCount++;
                    }
                    else
                        return xHttpReq.AsHttpResponse;
                }
                catch (TaskCanceledException xTask)
                {
                    if (policy.RetryLogicHandler != null)
                    {
                        HttpRequestTimeoutException toException = new HttpRequestTimeoutException(xTask);
                        if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                        else
                            retryCount++;
                    }
                    else
                        throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                }
                catch (AggregateException x)
                {
                    if (x.InnerException is TaskCanceledException)
                    {
                        if (policy.RetryLogicHandler != null)
                        {
                            HttpRequestTimeoutException toException = new HttpRequestTimeoutException(x.InnerException);
                            if (!policy.RetryLogicHandler.ExecuteRetryLogic(policy, retryCount, toException))
                                throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                            else
                                retryCount++;
                        }
                        else
                            throw new HttpResponseException(HttpStatusCode.RequestTimeout, "");
                    }
                    else
                        throw new Exception(x.Message, x);
                }
                catch (Exception x)
                {
                    throw new Exception(x.Message, x);
                }
            }
        }

        private static bool IsMediaTypeJson(string mediaType)
        {
            if (mediaType == MediaTypeNames.Application.Json)
            {
                return true;
            }

            if (mediaType.StartsWith("application/") && mediaType.EndsWith("+json"))
            {
                return true;
            }

            return false;
        }
    }
}