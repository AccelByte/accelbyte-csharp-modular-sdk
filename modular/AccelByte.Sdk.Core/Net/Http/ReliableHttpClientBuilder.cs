// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Net.Http
{
    public class ReliableHttpClientBuilder
    {
        public HttpClient? Http { get; private set; } = null;

        public HttpClientHandler? HttpHandler { get; private set; } = null;

        public IHttpClientPolicy DefaultPolicy { get; private set; } = HttpClientPolicy.Default;

        public IHttpLogger? Logger { get; private set; } = null;

        public Action<HttpRequestMessage, int>? BeforeSend { get; private set; } = null;

        public ReliableHttpClientBuilder SetHttp(HttpClient hcObj)
        {
            Http = hcObj;
            return this;
        }

        public ReliableHttpClientBuilder SetHttpClientHandler(HttpClientHandler handler)
        {
            HttpHandler = handler;
            return this;
        }

        public ReliableHttpClientBuilder SetDefaultPolicy(HttpClientPolicy policy)
        {
            DefaultPolicy = policy;
            return this;
        }

        public ReliableHttpClientBuilder SetLogger(IHttpLogger logger)
        {
            Logger = logger;
            return this;
        }

        public ReliableHttpClientBuilder SetBeforeSendAction(Action<HttpRequestMessage, int> action)
        {
            BeforeSend = action;
            return this;
        }

        public ReliableHttpClient Build()
        {
            return new ReliableHttpClient(this);
        }
    }
}