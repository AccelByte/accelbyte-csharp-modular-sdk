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
    /// AuthenticationWithPlatformLinkV4
    ///
    /// This endpoint is being used to authenticate a user account and perform platform link.
    /// It validates user's email / username and password.
    /// If user already enable 2FA, then invoke _/mfa/verify_ using **mfa_token** from this endpoint response.
    /// 
    /// ## Device Cookie Validation
    /// 
    /// Device Cookie is used to protect the user account from brute force login attack, [more detail from OWASP](https://owasp.org/www-community/Slow_Down_Online_Guessing_Attacks_with_Device_Cookies).
    /// This endpoint will read device cookie from cookie **auth-trust-id**. If device cookie not found, it will generate a new one and set it into cookie when successfully authenticate.
    /// </summary>
    public class AuthenticationWithPlatformLinkV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthenticationWithPlatformLinkV4Builder Builder { get => new AuthenticationWithPlatformLinkV4Builder(); }

        public class AuthenticationWithPlatformLinkV4Builder
            : OperationBuilder<AuthenticationWithPlatformLinkV4Builder>
        {



            public bool? ExtendExp { get; set; }



            internal AuthenticationWithPlatformLinkV4Builder() { }

            internal AuthenticationWithPlatformLinkV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AuthenticationWithPlatformLinkV4Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }



            public AuthenticationWithPlatformLinkV4 Build(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV4 op = new AuthenticationWithPlatformLinkV4(this,
                    clientId,
                    linkingToken,
                    password,
                    username
                );

                op.SetBaseFields<AuthenticationWithPlatformLinkV4Builder>(this);
                return op;
            }

            public AuthenticationWithPlatformLinkV4.Response Execute(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV4 op = Build(
                    clientId,
                    linkingToken,
                    password,
                    username
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AuthenticationWithPlatformLinkV4.Response> ExecuteAsync(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV4 op = Build(
                    clientId,
                    linkingToken,
                    password,
                    username
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

        private AuthenticationWithPlatformLinkV4(AuthenticationWithPlatformLinkV4Builder builder,
            string clientId,
            string linkingToken,
            string password,
            string username
        )
        {


            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;
            if (password is not null) FormParams["password"] = password;
            if (username is not null) FormParams["username"] = username;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthmodelTokenResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public OauthmodelErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OAuth20V4::AuthenticationWithPlatformLinkV4";
        }

        #endregion

        public AuthenticationWithPlatformLinkV4(
            bool? extendExp,
            string clientId,
            string linkingToken,
            string password,
            string username
        )
        {


            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;
            if (password is not null) FormParams["password"] = password;
            if (username is not null) FormParams["username"] = username;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/oauth/authenticateWithLink";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public AuthenticationWithPlatformLinkV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AuthenticationWithPlatformLinkV4.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}