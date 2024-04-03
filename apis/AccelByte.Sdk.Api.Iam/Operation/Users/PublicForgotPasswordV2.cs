// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicForgotPasswordV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/forgot [POST]_**
    /// 
    /// **Special note for publisher-game scenario:** Game Client should provide game namespace path parameter and Publisher Client should provide publisher namespace path parameter.
    /// The password reset code will be sent to the publisher account's email address.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicForgotPasswordV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForgotPasswordV2Builder Builder { get => new PublicForgotPasswordV2Builder(); }

        public class PublicForgotPasswordV2Builder
            : OperationBuilder<PublicForgotPasswordV2Builder>
        {





            internal PublicForgotPasswordV2Builder() { }

            internal PublicForgotPasswordV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicForgotPasswordV2 Build(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicForgotPasswordV2 op = new PublicForgotPasswordV2(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicForgotPasswordV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicForgotPasswordV2 op = Build(
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
            public async Task ExecuteAsync(
                ModelSendVerificationCodeRequest body,
                string namespace_
            )
            {
                PublicForgotPasswordV2 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicForgotPasswordV2(PublicForgotPasswordV2Builder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicForgotPasswordV2(
            string namespace_,
            Model.ModelSendVerificationCodeRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/forgotPassword";

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