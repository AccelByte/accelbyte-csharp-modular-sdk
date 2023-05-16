// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Repository
{
    public class DefaultConfigRepository : IConfigRepository
    {
        private const string BASE_URL = "AB_BASE_URL";

        private const string CLIENT_ID = "AB_CLIENT_ID";

        private const string CLIENT_SECRET = "AB_CLIENT_SECRET";

        private const string CLIENT_APPNAME = "AB_APP_NAME";

        private const string CLIENT_NAMESPACE = "AB_NAMESPACE";

        private const string CLIENT_TRACEID_VERSION = "AB_TRACEID_VERSION";

        private const string CLIENT_ENABLE_TRACEID = "AB_ENABLE_TRACEID";

        private const string CLIENT_ENABLE_USERAGENT = "AB_ENABLE_USERAGENT";

        public string BaseUrl
        {
            get => Environment.GetEnvironmentVariable(BASE_URL) ??
                    throw new Exception($"Environment variable not found (variable: {BASE_URL})");
        }

        public string ClientId
        {
            get => Environment.GetEnvironmentVariable(CLIENT_ID) ??
                    throw new Exception($"Environment variable not found (variable: {CLIENT_ID})");
        }

        public string ClientSecret
        {
            get => Environment.GetEnvironmentVariable(CLIENT_SECRET) ??
                     throw new Exception($"Environment variable not found (variable: {CLIENT_SECRET})");
        }

        public string AppName
        {
            get
            {
                string? aAppname = Environment.GetEnvironmentVariable(CLIENT_APPNAME);
                if (aAppname != null)
                    return aAppname;
                else
                    return "UntitledApp";
            }
        }

        public string Namespace
        {
            get
            {
                string? aNamespace = Environment.GetEnvironmentVariable(CLIENT_NAMESPACE);
                if (aNamespace != null)
                    return aNamespace;
                else
                    return String.Empty;
            }
        }

        public string TraceIdVersion
        {
            get
            {
                string? aVersion = Environment.GetEnvironmentVariable(CLIENT_TRACEID_VERSION);
                if (aVersion == null)
                    return "1";
                else
                    return aVersion;
            }
        }

        public bool EnableTraceId
        {
            get
            {
                string? aEnable = Environment.GetEnvironmentVariable(CLIENT_ENABLE_TRACEID);
                if (aEnable == null)
                    return true;
                else
                    return (aEnable.Trim() == "1");
            }
        }

        public bool EnableUserAgentInfo
        {
            get
            {
                string? aEnable = Environment.GetEnvironmentVariable(CLIENT_ENABLE_USERAGENT);
                if (aEnable == null)
                    return true;
                else
                    return (aEnable.Trim() == "1");
            }
        }

        public IHttpLogger? Logger { get; set; } = null;
    }

    public static class DefaultConfigRepository_SdkBuilderExts
    {
        public static IAccelByteSdkBuilder<T> UseDefaultConfigRepository<T>(this IAccelByteSdkBuilder<T> builder)
        {
            return builder.SetConfigRepository(new DefaultConfigRepository());
        }
    }
}