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
    /// UpdateRuleSet
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:RULES [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Updates an existing matchmaking rule set.
    /// 
    /// To use custom rules set please set enable_custom_match_function=true. Default (false).
    /// </summary>
    public class UpdateRuleSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRuleSetBuilder Builder { get => new UpdateRuleSetBuilder(); }

        public class UpdateRuleSetBuilder
            : OperationBuilder<UpdateRuleSetBuilder>
        {





            internal UpdateRuleSetBuilder() { }

            internal UpdateRuleSetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateRuleSet Build(
                ApiRuleSetPayload body,
                string namespace_,
                string ruleset
            )
            {
                UpdateRuleSet op = new UpdateRuleSet(this,
                    body,
                    namespace_,
                    ruleset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApiRuleSetPayload? Execute(
                ApiRuleSetPayload body,
                string namespace_,
                string ruleset
            )
            {
                UpdateRuleSet op = Build(
                    body,
                    namespace_,
                    ruleset
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApiRuleSetPayload<T1>? Execute<T1>(
                ApiRuleSetPayload body,
                string namespace_,
                string ruleset
            )
            {
                UpdateRuleSet op = Build(
                    body,
                    namespace_,
                    ruleset
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateRuleSet(UpdateRuleSetBuilder builder,
            ApiRuleSetPayload body,
            string namespace_,
            string ruleset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateRuleSet(
            string namespace_,
            string ruleset,
            Model.ApiRuleSetPayload body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets/{ruleset}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiRuleSetPayload? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApiRuleSetPayload<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}