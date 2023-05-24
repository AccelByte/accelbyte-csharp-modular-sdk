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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// ForgotPassword
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/public/namespaces/{namespace}/users/forgot [POST]
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PASSWORD:USER [UPDATE]' or valid basic auth header"+
    /// "
    /// 
    ///  Special note for publisher-game scenario: Game Client should provide game namespace path parameter and Publisher Client should provide publisher namespace path parameter.
    /// 
    /// "+
    /// "
    /// 
    /// The password reset code will be sent to the publisher account's email address.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class ForgotPassword : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ForgotPasswordBuilder Builder { get => new ForgotPasswordBuilder(); }

        public class ForgotPasswordBuilder
            : OperationBuilder<ForgotPasswordBuilder>
        {





            internal ForgotPasswordBuilder() { }

            internal ForgotPasswordBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ForgotPassword Build(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                ForgotPassword op = new ForgotPassword(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                ForgotPassword op = Build(
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

        private ForgotPassword(ForgotPasswordBuilder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public ForgotPassword(
            string namespace_,
            Model.ModelSendVerificationCodeRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/forgotPassword";

        public override HttpMethod Method => HttpMethod.Post;

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