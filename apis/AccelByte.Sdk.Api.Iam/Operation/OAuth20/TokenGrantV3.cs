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
    /// TokenGrantV3
    ///
    /// 
    /// 
    /// This endpoint supports grant type:
    /// 
    /// 
    /// 
    ///                 1. Grant Type == `authorization_code`:
    /// 
    ///     It generates the user token by given the authorization
    /// code which generated in "/iam/v3/authenticate" API response. It should also pass
    /// in the redirect_uri, which should be the same as generating the
    /// authorization code request.
    /// 
    /// 
    /// 
    ///                 2. Grant Type == `password`:
    /// 
    ///     The grant type to use for authenticating a user, whether it's by email / username and password combination
    /// or through platform.
    /// 
    /// 
    /// 
    ///                 3. Grant Type == `refresh_token`:
    /// 
    ///     Used to get a new access token for a valid refresh token.
    /// 
    /// 
    /// 
    ///                 4. Grant Type == `client_credentials`:
    /// 
    ///     It generates a token by checking the client credentials provided through Authorization header.
    /// 
    /// 
    /// 
    ///                 5. Grant Type == `urn:ietf:params:oauth:grant-type:extend_client_credentials`:
    /// 
    ///     It generates a token by checking the client credentials provided through Authorization header.
    ///    It only allow publisher namespace client.
    ///    In generated token:
    ///      1.There wil be no roles, namespace_roles & permission.
    ///      2.The scope will be fixed as 'extend'.
    ///      3.There will have a new field 'extend_namespace', the value is from token request body.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Access Token Content
    /// 
    /// 
    /// 
    /// 
    /// Following is the access tokenâs content:
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// namespace. It is the namespace the token was generated from.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// display_name. The display name of the sub. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// roles. The subâs roles. It is empty if the token is generated from the client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// namespace_roles. The subâs roles scoped to namespace. Improvement from roles, which make the role scoped to specific namespace instead of global to publisher namespace
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// permissions. The sub or audâ permissions
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// bans. The subâs list of bans. It is used by the IAM client for validating the token.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// jflgs. It stands for Justice Flags. It is a special flag used for storing additional status information regarding the sub. It is implemented as a bit mask. Following explains what each bit represents:
    /// 
    /// 
    /// 
    /// 
    ///                   * 1: Email Address Verified
    /// 
    /// 
    /// 
    ///                   * 2: Phone Number Verified
    /// 
    /// 
    /// 
    ///                   * 4: Anonymous
    /// 
    /// 
    /// 
    ///                   * 8: Suspicious Login
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// aud. The aud is the targeted resource server.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// iat. The time the token issues at. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// exp. The time the token expires. It is in Epoch time format
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// client_id. The UserID. The sub is omitted if the token is generated from client credential
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 *
    /// 
    /// 
    /// scope. The scope of the access request, expressed as a list of space-delimited, case-sensitive strings
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Bans
    /// 
    /// 
    /// 
    /// 
    /// The JWT contains user's active bans with its expiry date. List of ban types can be obtained from /bans.
    /// 
    /// 
    /// 
    /// 
    /// ## Device Cookie Validation
    /// 
    /// 
    /// 
    /// 
    /// For grant type "password" only
    /// 
    /// 
    /// 
    /// 
    /// Device Cookie is used to protect the user account from brute force login attack, [more detail from OWASP.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will read device cookie from request header Auth-Trust-Id. If device cookie not found, it will generate a new one and set it into response body auth_trust_id when successfully login.
    /// 
    /// 
    /// 
    /// 
    /// ## Track Login History
    /// 
    /// 
    /// 
    /// 
    /// This endpoint will track login history to detect suspicious login activity, please provide Device-Id (alphanumeric) in request header parameter otherwise it will set to "unknown".
    /// 
    /// 
    /// 
    /// 
    /// Align with General Data Protection Regulation in Europe, user login history will be kept within 28 days by default"
    /// 
    /// 
    /// 
    /// 
    /// ## 2FA remember device
    /// 
    /// 
    /// 
    /// 
    /// To remember device for 2FA, should provide cookie: device_token or header: Device-Token
    /// 
    /// 
    /// 
    /// 
    /// ## Response note
    /// 
    /// 
    /// 
    /// 
    /// If it is a user token request and user hasn't accepted required legal policy, the field `is_comply` will be false in response and responsed token will have no permission.
    /// 
    /// 
    /// 
    /// 
    /// action code: 10703
    /// </summary>
    public class TokenGrantV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenGrantV3Builder Builder { get => new TokenGrantV3Builder(); }

        public class TokenGrantV3Builder
            : OperationBuilder<TokenGrantV3Builder>
        {



            public string? AdditionalData { get; set; }

            public string? ClientId { get; set; }

            public string? Code { get; set; }

            public string? CodeVerifier { get; set; }

            public string? ExtendNamespace { get; set; }

            public bool? ExtendExp { get; set; }

            public string? Password { get; set; }

            public string? RedirectUri { get; set; }

            public string? RefreshToken { get; set; }

            public string? Username { get; set; }



            internal TokenGrantV3Builder() { }

            internal TokenGrantV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public TokenGrantV3Builder SetAdditionalData(string _additionalData)
            {
                AdditionalData = _additionalData;
                return this;
            }

            public TokenGrantV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public TokenGrantV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public TokenGrantV3Builder SetCodeVerifier(string _codeVerifier)
            {
                CodeVerifier = _codeVerifier;
                return this;
            }

            public TokenGrantV3Builder SetExtendNamespace(string _extendNamespace)
            {
                ExtendNamespace = _extendNamespace;
                return this;
            }

            public TokenGrantV3Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }

            public TokenGrantV3Builder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }

            public TokenGrantV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public TokenGrantV3Builder SetRefreshToken(string _refreshToken)
            {
                RefreshToken = _refreshToken;
                return this;
            }

            public TokenGrantV3Builder SetUsername(string _username)
            {
                Username = _username;
                return this;
            }



            public TokenGrantV3 Build(
                TokenGrantV3GrantType grantType
            )
            {
                TokenGrantV3 op = new TokenGrantV3(this,
                    grantType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.OauthmodelTokenWithDeviceCookieResponseV3? Execute(
                string grantType
            )
            {
                TokenGrantV3 op = Build(
                    grantType
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

        private TokenGrantV3(TokenGrantV3Builder builder,
            TokenGrantV3GrantType grantType
        )
        {


            if (builder.AdditionalData is not null) FormParams["additionalData"] = builder.AdditionalData;
            if (builder.ClientId is not null) FormParams["client_id"] = builder.ClientId;
            if (builder.Code is not null) FormParams["code"] = builder.Code;
            if (builder.CodeVerifier is not null) FormParams["code_verifier"] = builder.CodeVerifier;
            if (builder.ExtendNamespace is not null) FormParams["extendNamespace"] = builder.ExtendNamespace;
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (builder.Password is not null) FormParams["password"] = builder.Password;
            if (builder.RedirectUri is not null) FormParams["redirect_uri"] = builder.RedirectUri;
            if (builder.RefreshToken is not null) FormParams["refresh_token"] = builder.RefreshToken;
            if (builder.Username is not null) FormParams["username"] = builder.Username;
            if (grantType is not null) FormParams["grant_type"] = grantType.Value;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public TokenGrantV3(
            string? additionalData,
            string? clientId,
            string? code,
            string? codeVerifier,
            string? extendNamespace,
            bool? extendExp,
            string? password,
            string? redirectUri,
            string? refreshToken,
            string? username,
            TokenGrantV3GrantType grantType
        )
        {


            if (additionalData is not null) FormParams["additionalData"] = additionalData;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (code is not null) FormParams["code"] = code;
            if (codeVerifier is not null) FormParams["code_verifier"] = codeVerifier;
            if (extendNamespace is not null) FormParams["extendNamespace"] = extendNamespace;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (password is not null) FormParams["password"] = password;
            if (redirectUri is not null) FormParams["redirect_uri"] = redirectUri;
            if (refreshToken is not null) FormParams["refresh_token"] = refreshToken;
            if (username is not null) FormParams["username"] = username;
            if (grantType is not null) FormParams["grant_type"] = grantType.Value;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenWithDeviceCookieResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenWithDeviceCookieResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenWithDeviceCookieResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class TokenGrantV3GrantType : StringEnum<TokenGrantV3GrantType>
    {
        public static readonly TokenGrantV3GrantType AuthorizationCode
            = new TokenGrantV3GrantType("authorization_code");

        public static readonly TokenGrantV3GrantType ClientCredentials
            = new TokenGrantV3GrantType("client_credentials");

        public static readonly TokenGrantV3GrantType Password
            = new TokenGrantV3GrantType("password");

        public static readonly TokenGrantV3GrantType RefreshToken
            = new TokenGrantV3GrantType("refresh_token");

        public static readonly TokenGrantV3GrantType UrnietfparamsoauthgrantTypeextendClientCredentials
            = new TokenGrantV3GrantType("urn:ietf:params:oauth:grant-type:extend_client_credentials");


        public static implicit operator TokenGrantV3GrantType(string value)
        {
            return NewValue(value);
        }

        public TokenGrantV3GrantType(string enumValue)
            : base(enumValue)
        {

        }
    }

}