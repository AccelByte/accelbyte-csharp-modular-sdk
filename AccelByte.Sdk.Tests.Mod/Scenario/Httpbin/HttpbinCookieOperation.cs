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
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Tests.Mod.Model;

namespace AccelByte.Sdk.Tests.Mod.Scenario.Httpbin
{
    public class HttpbinCookieOperation : Operation
    {
        public HttpbinCookieOperation()
        {

        }

        public override string Path => "/cookies";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public HttpbinCookieResponse? ParseResponse(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var jsonString = payload.ReadToString();
                throw new HttpResponseException(code, jsonString);
            }

            return JsonSerializer.Deserialize<HttpbinCookieResponse>(payload);
        }
    }
}