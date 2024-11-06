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
    /// PublicDisableMyAuthenticatorV4
    ///
    /// This endpoint is used to disable 2FA authenticator.
    /// ------
    /// **Note**: **mfaToken** is required when all the following are enabled:
    /// - The environment variable **SENSITIVE_MFA_AUTH_ENABLED** is true
    /// - The **Two-Factor Authentication** is enabled in the IAM client where user logs in
    /// - Users already enabled the MFA
    /// </summary>
    public class PublicDisableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDisableMyAuthenticatorV4Builder Builder { get => new PublicDisableMyAuthenticatorV4Builder(); }

        public class PublicDisableMyAuthenticatorV4Builder
            : OperationBuilder<PublicDisableMyAuthenticatorV4Builder>
        {





            internal PublicDisableMyAuthenticatorV4Builder() { }

            internal PublicDisableMyAuthenticatorV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDisableMyAuthenticatorV4 Build(
                ModelDisableMFARequest body,
                string namespace_
            )
            {
                PublicDisableMyAuthenticatorV4 op = new PublicDisableMyAuthenticatorV4(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicDisableMyAuthenticatorV4Builder>(this);
                return op;
            }

            public PublicDisableMyAuthenticatorV4.Response Execute(
                ModelDisableMFARequest body,
                string namespace_
            )
            {
                PublicDisableMyAuthenticatorV4 op = Build(
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
            public async Task<PublicDisableMyAuthenticatorV4.Response> ExecuteAsync(
                ModelDisableMFARequest body,
                string namespace_
            )
            {
                PublicDisableMyAuthenticatorV4 op = Build(
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

        private PublicDisableMyAuthenticatorV4(PublicDisableMyAuthenticatorV4Builder builder,
            ModelDisableMFARequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

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

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::UsersV4::PublicDisableMyAuthenticatorV4";
        }

        #endregion

        public PublicDisableMyAuthenticatorV4(
            string namespace_,            
            Model.ModelDisableMFARequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/disable";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicDisableMyAuthenticatorV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicDisableMyAuthenticatorV4.Response()
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
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}