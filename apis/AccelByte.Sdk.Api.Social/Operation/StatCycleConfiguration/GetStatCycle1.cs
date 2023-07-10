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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getStatCycle_1
    ///
    /// Get stat cycle.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STAT", action=2 (READ)
    ///             *  Returns : stat cycle info
    /// </summary>
    public class GetStatCycle1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatCycle1Builder Builder { get => new GetStatCycle1Builder(); }

        public class GetStatCycle1Builder
            : OperationBuilder<GetStatCycle1Builder>
        {





            internal GetStatCycle1Builder() { }

            internal GetStatCycle1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetStatCycle1 Build(
                string cycleId,
                string namespace_
            )
            {
                GetStatCycle1 op = new GetStatCycle1(this,
                    cycleId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.StatCycleInfo? Execute(
                string cycleId,
                string namespace_
            )
            {
                GetStatCycle1 op = Build(
                    cycleId,
                    namespace_
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

        private GetStatCycle1(GetStatCycle1Builder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStatCycle1(
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statCycles/{cycleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatCycleInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}