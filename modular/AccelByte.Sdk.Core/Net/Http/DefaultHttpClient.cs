// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
using System.Text;
using System.Text.Json;
using System.Web;
using System.IO;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class DefaultHttpClient : IHttpClient
    {
        public static readonly HttpLoggingHandler Handler = new HttpLoggingHandler(new HttpClientHandler()
        {
            AllowAutoRedirect = false   // Handle redirect manually
        });

        public static readonly HttpClient Http = new HttpClient(Handler);

        private static object HttpLock = new object();

        public IHttpClient SetLogger(IHttpLogger logger)
        {
            Handler.Logger = logger;
            return this;
        }

        public IHttpResponse SendRequest(IOperation operation, string baseURL)
        {
            Dictionary<string, string> headers = operation.HeaderParams;

            lock (HttpLock)
            {
                var contentType = string.Empty;

                if (operation.Consumes.Any())
                {
                    contentType = operation.Consumes.First();   // XXX First only
                    headers["Content-Type"] = contentType;
                }

                if (operation.Produces.Any())
                {
                    headers["Accept"] = operation.Produces.First();    // XXX First only
                }

                var url = operation.GetUrl(baseURL);

                var request = new HttpRequestMessage(operation.Method, url);

                if (operation.BodyParams != null)
                {
                    if (contentType == String.Empty)
                    {
                        contentType = "application/json";
                        headers["Content-Type"] = contentType;
                    }

                    if (IsMediaTypeJson(contentType))
                    {
                        var jsonString = JsonSerializer.Serialize(operation.BodyParams);
                        request.Content = new StringContent(jsonString, Encoding.UTF8, contentType);
                    }
                    else
                    {
                        var bodyString = operation.BodyParams.ToString()!;
                        request.Content = new StringContent(bodyString, Encoding.UTF8, contentType);
                    }
                }
                else if (operation.FormParams.Any())
                {
                    if (contentType == String.Empty)
                        contentType = "application/x-www-form-urlencoded";

                    switch (contentType)
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
                            throw new NotSupportedException($"Unsupported form content type (content type: {contentType})");
                    }
                }

                //request.Content.Headers.Clear();
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

                var response = Http!.Send(request);

                Stream? payload = null;

                if (IsHttpStatusCodeRedirect(response.StatusCode))
                {
                    var location = response.Headers.Location ??
                            throw new Exception($"Location header is null (status code: {response.StatusCode})");

                    payload = new MemoryStream(Encoding.UTF8.GetBytes(location.OriginalString));
                }
                else if (response.Content != null)
                {
                    payload = response.Content.ReadAsStream();
                }

                return new HttpResponse(response.StatusCode, contentType, payload!);
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

        private static bool IsHttpStatusCodeRedirect(HttpStatusCode code)
        {
            return (new[] { 308, 307, 300, 301, 302, 303 }).Contains((int)code);
        }
    }

    public static class DefaultHttpClient_SdkBuilderExts
    {
        public static IAccelByteSdkBuilder<T> UseDefaultHttpClient<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetHttpClient(new DefaultHttpClient());
        }
    }
}