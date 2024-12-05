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
    /// ResetPassword
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/reset [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class ResetPassword : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetPasswordBuilder Builder { get => new ResetPasswordBuilder(); }

        public class ResetPasswordBuilder
            : OperationBuilder<ResetPasswordBuilder>
        {





            internal ResetPasswordBuilder() { }

            internal ResetPasswordBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ResetPassword Build(
                ModelResetPasswordRequest body,
                string namespace_
            )
            {
                ResetPassword op = new ResetPassword(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<ResetPasswordBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public ResetPassword.Response Execute(
                ModelResetPasswordRequest body,
                string namespace_
            )
            {
                ResetPassword op = Build(
                    body,
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
            public async Task<ResetPassword.Response> ExecuteAsync(
                ModelResetPasswordRequest body,
                string namespace_
            )
            {
                ResetPassword op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ResetPassword(ResetPasswordBuilder builder,
            ModelResetPasswordRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error400 { get; set; } = "";

            public string Error403 { get; set; } = "";

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::ResetPassword";
        }

        #endregion

        public ResetPassword(
            string namespace_,
            Model.ModelResetPasswordRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/resetPassword";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public ResetPassword.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ResetPassword.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error400!);
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error403!);
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}