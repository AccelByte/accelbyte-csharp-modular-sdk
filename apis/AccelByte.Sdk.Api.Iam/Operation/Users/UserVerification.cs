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
    /// UserVerification
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/me/code/verify [POST]_**
    /// 
    /// Redeems a verification code sent to a user to verify the user's contact address is correct
    /// Available ContactType : *email* or *phone*
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UserVerification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserVerificationBuilder Builder { get => new UserVerificationBuilder(); }

        public class UserVerificationBuilder
            : OperationBuilder<UserVerificationBuilder>
        {





            internal UserVerificationBuilder() { }

            internal UserVerificationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UserVerification Build(
                ModelUserVerificationRequest body,
                string namespace_,
                string userId
            )
            {
                UserVerification op = new UserVerification(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UserVerificationBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public UserVerification.Response Execute(
                ModelUserVerificationRequest body,
                string namespace_,
                string userId
            )
            {
                UserVerification op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UserVerification.Response> ExecuteAsync(
                ModelUserVerificationRequest body,
                string namespace_,
                string userId
            )
            {
                UserVerification op = Build(
                    body,
                    namespace_,
                    userId
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

        private UserVerification(UserVerificationBuilder builder,
            ModelUserVerificationRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error400 { get; set; } = "";

            public RestErrorResponse? Error401 { get; set; } = null;

            public string Error403 { get; set; } = "";

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::UserVerification";
        }

        #endregion

        public UserVerification(
            string namespace_,
            string userId,
            Model.ModelUserVerificationRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/verification";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public UserVerification.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UserVerification.Response()
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
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
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