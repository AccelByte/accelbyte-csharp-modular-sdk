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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// MatchPoolDetails
    ///
    /// Get details for a specific match pool
    /// </summary>
    public class MatchPoolDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MatchPoolDetailsBuilder Builder { get => new MatchPoolDetailsBuilder(); }

        public class MatchPoolDetailsBuilder
            : OperationBuilder<MatchPoolDetailsBuilder>
        {





            internal MatchPoolDetailsBuilder() { }

            internal MatchPoolDetailsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public MatchPoolDetails Build(
                string namespace_,
                string pool
            )
            {
                MatchPoolDetails op = new MatchPoolDetails(this,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApiMatchPool? Execute(
                string namespace_,
                string pool
            )
            {
                MatchPoolDetails op = Build(
                    namespace_,
                    pool
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

        private MatchPoolDetails(MatchPoolDetailsBuilder builder,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MatchPoolDetails(
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiMatchPool? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchPool>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchPool>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}