// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Tests.Mod.Model;

namespace AccelByte.Sdk.Tests.Mod.Scenario.Httpbin
{
    public class HttpbinAnythingOperation : Operation
    {
        public static HttpbinAnythingOperationBuilder Builder { get => new HttpbinAnythingOperationBuilder(); }

        public class HttpbinAnythingOperationBuilder
            : OperationBuilder<HttpbinAnythingOperationBuilder>
        {
            public object? BodyParam { get; private set; } = null;

            public string? LocationQuery { get; private set; } = null;

            public HttpbinAnythingOperationBuilder SetBodyParam(object bodyParam)
            {
                BodyParam = bodyParam;
                return this;
            }

            public HttpbinAnythingOperationBuilder SetLocationQuery(string locationQuery)
            {
                LocationQuery = locationQuery;
                return this;
            }

            public HttpbinAnythingOperation Create(HttpMethod method)
            {
                var op = new HttpbinAnythingOperation(this, method);
                op.FlightId = FlightId;
                return op;
            }

            public HttpbinAnythingOperation Create(string method)
            {
                var op = new HttpbinAnythingOperation(this, new HttpMethod(method));
                op.FlightId = FlightId;
                return op;
            }
        }

        private HttpMethod _Method;

        private HttpbinAnythingOperation(HttpbinAnythingOperationBuilder builder, HttpMethod method)
        {
            _Method = method;
            BodyParams = builder.BodyParam;
            LocationQuery = builder.LocationQuery;
        }

        public override string Path => "/anything/{test_path}";

        public override HttpMethod Method => _Method;

        private List<string> _Consumes = new() { "application/json" };
        public override List<string> Consumes => _Consumes;

        private List<string> _Produces = new() { "application/json" };
        public override List<string> Produces => _Produces;

        public HttpbinAnythingOperation AddPathParam(string key, string value)
        {
            PathParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddQueryParam(string key, string value)
        {
            QueryParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddHeaderParam(string key, string value)
        {
            HeaderParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddFormParam(string key, dynamic value)
        {
            FormParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddCookie(string key, string value)
        {
            Cookies.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddCollectionFormat(string key, string value)
        {
            CollectionFormatMap.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddSecurity(string value)
        {
            Securities.Add(value);
            return this;
        }

        public HttpbinAnythingOperation SetConsume(string contentType)
        {
            _Consumes = new List<string> { contentType };
            return this;
        }

        public HttpbinAnythingOperation SetProduce(string contentType)
        {
            _Produces = new List<string> { contentType };
            return this;
        }

        public HttpbinAnythingResponse<TArgs>? ParseResponse<TArgs>(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code == HttpStatusCode.OK)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else if (code == HttpStatusCode.Created)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else if (code == HttpStatusCode.NoContent)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else
            {
                string sPayload = payload.ReadToString();
                throw new HttpResponseException(code, sPayload);
            }
        }

        public HttpbinAnythingResponse<TArgs, TData>? ParseResponse<TArgs, TData>(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code == HttpStatusCode.OK)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else if (code == HttpStatusCode.Created)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else if (code == HttpStatusCode.NoContent)
            {
                string sPayload = payload.ReadToString();
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else
            {
                string sPayload = payload.ReadToString();
                throw new HttpResponseException(code, sPayload);
            }
        }

        public HttpbinAnythingResponse<TArgs>? Execute<TArgs>(IAccelByteSdk sdk)
        {
            IHttpResponse response = sdk.RunRequest(this);
            return ParseResponse<TArgs>(response.Code, response.ContentType, response.Payload);
        }

        public HttpbinAnythingResponse<TArgs, TData>? Execute<TArgs, TData>(IAccelByteSdk sdk)
        {
            IHttpResponse response = sdk.RunRequest(this);
            return ParseResponse<TArgs, TData>(response.Code, response.ContentType, response.Payload);
        }

        public HttpbinAnythingResponse<Dictionary<string, string>>? Execute(IAccelByteSdk sdk)
        {
            IHttpResponse response = sdk.RunRequest(this);
            return ParseResponse<Dictionary<string, string>>(response.Code, response.ContentType, response.Payload);
        }
    }
}