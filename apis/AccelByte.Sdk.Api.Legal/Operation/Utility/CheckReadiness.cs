// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// checkReadiness
    ///
    /// Readiness status defined as at least one legal basePolicy is present and having active basePolicy.
    /// Other detail info:
    ///     * Required permission : resource="NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class CheckReadiness : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckReadinessBuilder Builder { get => new CheckReadinessBuilder(); }

        public class CheckReadinessBuilder
            : OperationBuilder<CheckReadinessBuilder>
        {





            internal CheckReadinessBuilder() { }

            internal CheckReadinessBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CheckReadiness Build(
            )
            {
                CheckReadiness op = new CheckReadiness(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.LegalReadinessStatusResponse? Execute(
            )
            {
                CheckReadiness op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private CheckReadiness(CheckReadinessBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckReadiness(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/readiness";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.LegalReadinessStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.LegalReadinessStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LegalReadinessStatusResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}