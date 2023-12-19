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
    /// createModerationRule
    ///
    /// This endpoint create moderation rule.
    /// Supported Category: - UGC - USER - CHAT - EXTENSION
    /// Supported Action (GOING TO DEPRECATE, for replacement please use "actions"):
    /// 
    /// * HideContent
    /// 
    /// Supported Actions:
    /// 
    /// * **hideContent**: Hide the content
    /// * **banAccount**: Ban the user account
    /// * **deleteChat**: Delete chat
    /// </summary>
    public class CreateModerationRule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateModerationRuleBuilder Builder { get => new CreateModerationRuleBuilder(); }

        public class CreateModerationRuleBuilder
            : OperationBuilder<CreateModerationRuleBuilder>
        {





            internal CreateModerationRuleBuilder() { }

            internal CreateModerationRuleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateModerationRule Build(
                RestapiModerationRuleRequest body,
                string namespace_
            )
            {
                CreateModerationRule op = new CreateModerationRule(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                RestapiModerationRuleRequest body,
                string namespace_
            )
            {
                CreateModerationRule op = Build(
                    body,
                    namespace_
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

        private CreateModerationRule(CreateModerationRuleBuilder builder,
            RestapiModerationRuleRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateModerationRule(
            string namespace_,
            Model.RestapiModerationRuleRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/rule";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}