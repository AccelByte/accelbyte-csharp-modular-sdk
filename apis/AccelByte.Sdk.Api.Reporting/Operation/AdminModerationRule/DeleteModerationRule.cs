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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// deleteModerationRule
    ///
    /// 
    /// 
    /// This endpoint delete moderation rule.
    /// 
    /// 
    /// 
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:RULE [DELETE]
    /// </summary>
    public class DeleteModerationRule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteModerationRuleBuilder Builder { get => new DeleteModerationRuleBuilder(); }

        public class DeleteModerationRuleBuilder
            : OperationBuilder<DeleteModerationRuleBuilder>
        {





            internal DeleteModerationRuleBuilder() { }

            internal DeleteModerationRuleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteModerationRule Build(
                string namespace_,
                string ruleId
            )
            {
                DeleteModerationRule op = new DeleteModerationRule(this,
                    namespace_,
                    ruleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string ruleId
            )
            {
                DeleteModerationRule op = Build(
                    namespace_,
                    ruleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteModerationRule(DeleteModerationRuleBuilder builder,
            string namespace_,
            string ruleId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleId"] = ruleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteModerationRule(
            string namespace_,
            string ruleId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleId"] = ruleId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}