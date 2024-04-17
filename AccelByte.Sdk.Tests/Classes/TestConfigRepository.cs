// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Tests
{
    public class TestConfigRepository : IConfigRepository
    {
        private Dictionary<string, string> _BasePath = new Dictionary<string, string>();

        public TestConfigRepository(string baseUrl, string clientId, string clientSecret, string appName)
        {
            BaseUrl = baseUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
            AppName = appName;
        }

        public string BaseUrl { get; init; }

        public string ClientId { get; init; }

        public string ClientSecret { get; init; }

        public string AppName { get; init; }

        public string Namespace { get; set; } = "unit_test";

        public string TraceIdVersion { get; } = "1";

        public bool EnableTraceId { get; } = true;

        public bool EnableUserAgentInfo { get; } = true;

        public IHttpLogger? Logger { get; set; } = null;

        public void RegisterCustomBasePath(string serviceName, string basePath)
        {
            if (!_BasePath.ContainsKey(serviceName))
                _BasePath.Add(serviceName, basePath);
            else
                _BasePath[serviceName] = basePath;
        }

        public string GetCustomServiceBasePath(string serviceName)
        {
            if (_BasePath.ContainsKey(serviceName))
                return _BasePath[serviceName];
            else
                return "";
        }
    }
}