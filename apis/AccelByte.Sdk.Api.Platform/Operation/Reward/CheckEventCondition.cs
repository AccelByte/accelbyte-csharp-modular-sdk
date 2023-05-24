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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// checkEventCondition
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : match result
    /// </summary>
    public class CheckEventCondition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckEventConditionBuilder Builder { get => new CheckEventConditionBuilder(); }

        public class CheckEventConditionBuilder
            : OperationBuilder<CheckEventConditionBuilder>
        {


            public Model.EventPayload? Body { get; set; }




            internal CheckEventConditionBuilder() { }

            internal CheckEventConditionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CheckEventConditionBuilder SetBody(Model.EventPayload _body)
            {
                Body = _body;
                return this;
            }




            public CheckEventCondition Build(
                string namespace_,
                string rewardId
            )
            {
                CheckEventCondition op = new CheckEventCondition(this,
                    namespace_,
                    rewardId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ConditionMatchResult? Execute(
                string namespace_,
                string rewardId
            )
            {
                CheckEventCondition op = Build(
                    namespace_,
                    rewardId
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

        private CheckEventCondition(CheckEventConditionBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckEventCondition(
            string namespace_,
            string rewardId,
            Model.EventPayload body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}/match";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ConditionMatchResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConditionMatchResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConditionMatchResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}