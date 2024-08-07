// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Repository
{
    public interface IConfigRepository
    {
        string BaseUrl { get; }

        string ClientId { get; }

        string ClientSecret { get; }

        string AppName { get; }

        string TraceIdVersion { get; }

        string Namespace { get; }

        bool EnableTraceId { get; }

        bool EnableUserAgentInfo { get; }

        IHttpLogger? Logger { get; }

        string GetCustomServiceBasePath(string serviceName);
    }
}