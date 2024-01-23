// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Net.Http;

using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Core
{
    public abstract class Operation : IOperation
    {
        public const string SECURITY_BASIC = "Basic";

        public const string SECURITY_BEARER = "Bearer";

        public const string SECURITY_COOKIE = "Cookie";

        public const string COLLECTION_FORMAT_CSV = "csv";

        public const string COLLECTION_FORMAT_MULTI = "multi";

        public abstract string Path { get; }

        public abstract HttpMethod Method { get; }

        public abstract List<string> Consumes { get; }

        public abstract List<string> Produces { get; }

        public string PreferredSecurityMethod { get; set; } = String.Empty;

        public string FlightId { get; set; } = String.Empty;

        public List<string> Securities { get; } = new List<string>();

        public Dictionary<string, string> PathParams { get; } = new Dictionary<string, string>();

        public Dictionary<string, dynamic> QueryParams { get; } = new Dictionary<string, dynamic>();

        public Dictionary<string, string> HeaderParams { get; } = new Dictionary<string, string>();

        public Dictionary<string, dynamic> FormParams { get; } = new Dictionary<string, dynamic>();

        public Dictionary<string, string> CollectionFormatMap { get; } = new Dictionary<string, string>();

        public Dictionary<string, string> Cookies { get; } = new Dictionary<string, string>();

        public bool DoNotEncodeQueryParams { get; set; } = false;

        public bool WrapQueryParamValueWithQuote { get; set; } = false;

        public object? BodyParams { get; init; }

        public string? LocationQuery { get; init; }

        public IHttpClientPolicy? HttpClientPolicy { get; set; } = null;

        public JsonSerializerOptions? RequestJsonOptions { get; set; } = null;

        public JsonSerializerOptions? ResponseJsonOptions { get; set; } = null;

        public string GetUrl(string baseUrl)
        {
            return BuildUrl(baseUrl, Path, PathParams, QueryParams);
        }

        protected string EncodeQueryString(string value)
        {
            return (DoNotEncodeQueryParams ? value : HttpUtility.UrlEncode(value));
        }

        protected string WrapValueWithQuote(string value)
        {
            return (WrapQueryParamValueWithQuote ? "\"" + value + "\"" : value);
        }

        protected string BuildUrl(string baseUrl, string path, Dictionary<string, string> pathParams, Dictionary<string, dynamic> queryParams)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            if (baseUrl == null)
            {
                throw new ArgumentNullException(nameof(baseUrl));
            }

            var url = new StringBuilder(baseUrl.TrimEnd('/'));

            if (pathParams != null)
            {
                foreach (var pp in pathParams)
                {
                    path = path.Replace("{" + pp.Key + "}", HttpUtility.UrlEncode(pp.Value));
                }
            }

            url.Append(path);

            if (queryParams != null && queryParams.Any())
            {
                List<string> kpValues = new List<string>();
                foreach (var qp in queryParams)
                {
                    if (qp.Value is IList)
                    {
                        // Default collection format CSV
                        string collectionFormat = COLLECTION_FORMAT_CSV;
                        if (CollectionFormatMap.ContainsKey(qp.Key))
                            collectionFormat = CollectionFormatMap[qp.Key];

                        switch (collectionFormat)
                        {
                            case COLLECTION_FORMAT_CSV:
                                List<string> pValues = new List<string>();
                                foreach (var v in qp.Value)
                                {
                                    string val = v.ToString();
                                    // Escape " if any
                                    var escapedValue = val.Replace("\"", "\"\"");
                                    pValues.Add(EncodeQueryString(WrapValueWithQuote(escapedValue)));
                                }

                                if (pValues.Count > 0)
                                    kpValues.Add(EncodeQueryString(qp.Key) + "=" + String.Join(',', pValues));
                                break;
                            case COLLECTION_FORMAT_MULTI:
                                foreach (var v in qp.Value)
                                {
                                    string val = v.ToString();
                                    kpValues.Add(EncodeQueryString(qp.Key) + "=" + EncodeQueryString(val));
                                }
                                break;
                            default:
                                throw new NotSupportedException($"Unsupported query collection format (format: {collectionFormat})");
                        }
                    }
                    else
                        kpValues.Add(EncodeQueryString(qp.Key) + "=" + EncodeQueryString(qp.Value));
                }

                if (kpValues.Count > 0)
                    url.Append("?" + String.Join('&', kpValues));
            }

            return url.ToString();
        }

        protected void SetBaseFields<T>(OperationBuilder<T> opBuilder) where T : OperationBuilder<T>
        {
            PreferredSecurityMethod = opBuilder.PreferredSecurityMethod;
            RequestJsonOptions = opBuilder.RequestJsonOptions;
            ResponseJsonOptions = opBuilder.ResponseJsonOptions;
            FlightId = opBuilder.FlightId;
        }
    }
}