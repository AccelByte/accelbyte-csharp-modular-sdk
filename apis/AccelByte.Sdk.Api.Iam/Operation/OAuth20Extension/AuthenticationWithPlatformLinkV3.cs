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
    /// AuthenticationWithPlatformLinkV3
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
    public class AuthenticationWithPlatformLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthenticationWithPlatformLinkV3Builder Builder { get => new AuthenticationWithPlatformLinkV3Builder(); }

        public class AuthenticationWithPlatformLinkV3Builder
            : OperationBuilder<AuthenticationWithPlatformLinkV3Builder>
        {



            public bool? ExtendExp { get; set; }



            internal AuthenticationWithPlatformLinkV3Builder() { }

            internal AuthenticationWithPlatformLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AuthenticationWithPlatformLinkV3Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }



            public AuthenticationWithPlatformLinkV3 Build(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV3 op = new AuthenticationWithPlatformLinkV3(this,
                    clientId,
                    linkingToken,
                    password,
                    username
                );

                op.SetBaseFields<AuthenticationWithPlatformLinkV3Builder>(this);
                return op;
            }

            public Model.OauthmodelTokenResponseV3? Execute(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV3 op = Build(
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
            public async Task<Model.OauthmodelTokenResponseV3?> ExecuteAsync(
                string clientId,
                string linkingToken,
                string password,
                string username
            )
            {
                AuthenticationWithPlatformLinkV3 op = Build(
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

        private AuthenticationWithPlatformLinkV3(AuthenticationWithPlatformLinkV3Builder builder,
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

        public AuthenticationWithPlatformLinkV3(
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

        public override string Path => "/iam/v3/authenticateWithLink";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}