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
    /// AdminSendMyMFAEmailCodeV4
    ///
    /// This endpoint is used to send email code.
    /// --------------
    /// Supported actions:
    /// * ChangePassword
    /// * DisableMFAEmail
    /// </summary>
    public class AdminSendMyMFAEmailCodeV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSendMyMFAEmailCodeV4Builder Builder { get => new AdminSendMyMFAEmailCodeV4Builder(); }

        public class AdminSendMyMFAEmailCodeV4Builder
            : OperationBuilder<AdminSendMyMFAEmailCodeV4Builder>
        {



            public string? Action { get; set; }

            public string? LanguageTag { get; set; }



            internal AdminSendMyMFAEmailCodeV4Builder() { }

            internal AdminSendMyMFAEmailCodeV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminSendMyMFAEmailCodeV4Builder SetAction(string _action)
            {
                Action = _action;
                return this;
            }

            public AdminSendMyMFAEmailCodeV4Builder SetLanguageTag(string _languageTag)
            {
                LanguageTag = _languageTag;
                return this;
            }



            public AdminSendMyMFAEmailCodeV4 Build(
            )
            {
                AdminSendMyMFAEmailCodeV4 op = new AdminSendMyMFAEmailCodeV4(this
                );

                op.SetBaseFields<AdminSendMyMFAEmailCodeV4Builder>(this);
                return op;
            }

            public AdminSendMyMFAEmailCodeV4.Response Execute(
            )
            {
                AdminSendMyMFAEmailCodeV4 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminSendMyMFAEmailCodeV4.Response> ExecuteAsync(
            )
            {
                AdminSendMyMFAEmailCodeV4 op = Build(
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

        private AdminSendMyMFAEmailCodeV4(AdminSendMyMFAEmailCodeV4Builder builder
        )
        {


            if (builder.Action is not null) FormParams["action"] = builder.Action;
            if (builder.LanguageTag is not null) FormParams["languageTag"] = builder.LanguageTag;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error429 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::AdminSendMyMFAEmailCodeV4";
        }

        #endregion

        public AdminSendMyMFAEmailCodeV4(
            string? action,
            string? languageTag
        )
        {


            if (action is not null) FormParams["action"] = action;
            if (languageTag is not null) FormParams["languageTag"] = languageTag;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/email/code";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public AdminSendMyMFAEmailCodeV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminSendMyMFAEmailCodeV4.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)429)

            {
                response.Error429 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)

            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}