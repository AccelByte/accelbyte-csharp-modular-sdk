// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;

using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Core
{
    public interface IOperation
    {
        string Path { get; }

        HttpMethod Method { get; }

        List<string> Consumes { get; }

        List<string> Produces { get; }

        string CustomBasePath { get; }

        string PreferredSecurityMethod { get; }

        string FlightId { get; }

        List<string> Securities { get; }

        Dictionary<string, string> PathParams { get; }

        Dictionary<string, dynamic> QueryParams { get; }

        Dictionary<string, string> HeaderParams { get; }

        Dictionary<string, dynamic> FormParams { get; }

        Dictionary<string, string> CollectionFormatMap { get; }

        Dictionary<string, string> Cookies { get; }

        bool DoNotEncodeQueryParams { get; }

        bool WrapQueryParamValueWithQuote { get; }

        object? BodyParams { get; }

        string? LocationQuery { get; }

        IHttpClientPolicy? HttpClientPolicy { get; }

        JsonSerializerOptions? RequestJsonOptions { get; }

        JsonSerializerOptions? ResponseJsonOptions { get; }

        string GetUrl(string baseUrl);
    }
}
