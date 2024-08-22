// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests.Mod.Scenario.Httpbin
{
    public class HttpbinRedirectOperation : Operation
    {
        public HttpbinRedirectOperation(string toUrl, int statusCode)
        {
            QueryParams.Add("url", toUrl);
            QueryParams.Add("status_code", statusCode.ToString());
        }

        public override string Path => "/redirect-to";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "text/html" };

        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            return payload.ReadToString();
        }
    }
}