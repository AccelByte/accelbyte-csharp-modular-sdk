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
    /// UserAuthenticationV3
    ///
    /// This endpoint is being used to authenticate a user account.
    /// It validates user's email / username and password.
    /// Deactivated or login-banned users are unable to login.
    /// Redirect URI and Client ID must be specified as a pair and only used to redirect to the specified redirect URI in case the requestId is no longer valid.
    /// 
    /// ## Device Cookie Validation
    /// 
    /// Device Cookie is used to protect the user account from brute force login attack, [more detail from OWASP](https://owasp.org/www-community/Slow_Down_Online_Guessing_Attacks_with_Device_Cookies).
    /// This endpoint will read device cookie from cookie **auth-trust-id**. If device cookie not found, it will generate a new one and set it into cookie when successfully authenticate.
    /// 
    /// Action code: 10801
    /// </summary>
    public class UserAuthenticationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserAuthenticationV3Builder Builder { get => new UserAuthenticationV3Builder(); }

        public class UserAuthenticationV3Builder
            : OperationBuilder<UserAuthenticationV3Builder>
        {



            public string? ClientId { get; set; }

            public bool? ExtendExp { get; set; }

            public string? RedirectUri { get; set; }



            internal UserAuthenticationV3Builder() { }

            internal UserAuthenticationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UserAuthenticationV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public UserAuthenticationV3Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }

            public UserAuthenticationV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }



            public UserAuthenticationV3 Build(
                string password,
                string requestId,
                string userName
            )
            {
                UserAuthenticationV3 op = new UserAuthenticationV3(this,
                    password,
                    requestId,
                    userName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public string Execute(
                string password,
                string requestId,
                string userName
            )
            {
                UserAuthenticationV3 op = Build(
                    password,
                    requestId,
                    userName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UserAuthenticationV3(UserAuthenticationV3Builder builder,
            string password,
            string requestId,
            string userName
        )
        {


            if (builder.ClientId is not null) FormParams["client_id"] = builder.ClientId;
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (builder.RedirectUri is not null) FormParams["redirect_uri"] = builder.RedirectUri;
            if (password is not null) FormParams["password"] = password;
            if (requestId is not null) FormParams["request_id"] = requestId;
            if (userName is not null) FormParams["user_name"] = userName;




            LocationQuery = "code";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public UserAuthenticationV3(
            string? clientId,
            bool? extendExp,
            string? redirectUri,
            string password,
            string requestId,
            string userName
        )
        {


            if (clientId is not null) FormParams["client_id"] = clientId;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (redirectUri is not null) FormParams["redirect_uri"] = redirectUri;
            if (password is not null) FormParams["password"] = password;
            if (requestId is not null) FormParams["request_id"] = requestId;
            if (userName is not null) FormParams["user_name"] = userName;




            LocationQuery = "code";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/authenticate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = payload.ReadToString();

            if (code == (HttpStatusCode)302)
            {
                return payloadString;
            }

            throw new HttpResponseException(code, payloadString);
        }
    }

}