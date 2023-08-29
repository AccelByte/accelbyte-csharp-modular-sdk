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
    /// AuthorizeV3
    ///
    /// Initializes OAuth2.0 authorization code flow
    /// 
    /// 
    /// 
    /// The endpoint stores authorization request and redirects to login page with the authorization request id.
    /// The user can then do the authentication on the login page.
    /// The user will be redirected back to the requesting client with authorization code if successfully authenticated.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Only authorization code flow supported by this endpoint, implicit flow is not supported.
    /// 
    /// 
    /// 
    /// 
    ///                 * Authorize success :
    /// redirects to login page with the following information: ?request_id={authorization_request_id}
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * Authorize failure :
    /// redirects to the given redirect uri with the following information:
    /// ?error={error_code}&error;_description={error description}
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Following are the error code based on the specification:
    /// 
    /// 
    /// 
    /// 
    ///                 * invalid_request: The request is missing a required parameter,
    /// includes an invalid parameter value, includes a parameter more than once, or is otherwise malformed.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * server_error:
    /// The authorization server encountered an unexpected condition that prevented it from fulfilling the request.
    /// 
    /// 
    /// 
    /// 
    /// 
    ///                 * unauthorized_client: The client is not authorized to request a token using this method.
    /// 
    /// 
    /// 
    ///                 * access_denied: The resource owner or authorization server denied the request.
    /// 
    /// 
    /// 
    ///                 * invalid_scope: The requested scope is invalid, unknown, or malformed.
    /// 
    /// 
    /// 
    ///                 * unsupported_response_type: The authorization server does not support obtaining a token using this method.
    /// 
    /// 
    /// 
    ///                 * temporarily_unavailable: The authorization server is currently unable to handle the request
    /// due to a temporary overloading or maintenance of the server.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Please refer to the RFC for more information about authorization code flow: https://tools.ietf.org/html/rfc6749#section-4.1
    /// 
    /// 
    /// 
    /// action code: 10701
    /// </summary>
    public class AuthorizeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthorizeV3Builder Builder { get => new AuthorizeV3Builder(); }

        public class AuthorizeV3Builder
            : OperationBuilder<AuthorizeV3Builder>
        {

            public string? CodeChallenge { get; set; }

            public AuthorizeV3CodeChallengeMethod? CodeChallengeMethod { get; set; }

            public bool? CreateHeadless { get; set; }

            public string? OneTimeLinkCode { get; set; }

            public string? RedirectUri { get; set; }

            public string? Scope { get; set; }

            public string? State { get; set; }

            public string? TargetAuthPage { get; set; }

            public bool? UseRedirectUriAsLoginUrlWhenLocked { get; set; }





            internal AuthorizeV3Builder() { }

            internal AuthorizeV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AuthorizeV3Builder SetCodeChallenge(string _codeChallenge)
            {
                CodeChallenge = _codeChallenge;
                return this;
            }

            public AuthorizeV3Builder SetCodeChallengeMethod(AuthorizeV3CodeChallengeMethod _codeChallengeMethod)
            {
                CodeChallengeMethod = _codeChallengeMethod;
                return this;
            }

            public AuthorizeV3Builder SetCreateHeadless(bool _createHeadless)
            {
                CreateHeadless = _createHeadless;
                return this;
            }

            public AuthorizeV3Builder SetOneTimeLinkCode(string _oneTimeLinkCode)
            {
                OneTimeLinkCode = _oneTimeLinkCode;
                return this;
            }

            public AuthorizeV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public AuthorizeV3Builder SetScope(string _scope)
            {
                Scope = _scope;
                return this;
            }

            public AuthorizeV3Builder SetState(string _state)
            {
                State = _state;
                return this;
            }

            public AuthorizeV3Builder SetTargetAuthPage(string _targetAuthPage)
            {
                TargetAuthPage = _targetAuthPage;
                return this;
            }

            public AuthorizeV3Builder SetUseRedirectUriAsLoginUrlWhenLocked(bool _useRedirectUriAsLoginUrlWhenLocked)
            {
                UseRedirectUriAsLoginUrlWhenLocked = _useRedirectUriAsLoginUrlWhenLocked;
                return this;
            }





            public AuthorizeV3 Build(
                string clientId,
                AuthorizeV3ResponseType responseType
            )
            {
                AuthorizeV3 op = new AuthorizeV3(this,
                    clientId,                    
                    responseType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public string Execute(
                string clientId,
                string responseType
            )
            {
                AuthorizeV3 op = Build(
                    clientId,
                    responseType
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

        private AuthorizeV3(AuthorizeV3Builder builder,
            string clientId,
            AuthorizeV3ResponseType responseType
        )
        {
            
            if (builder.CodeChallenge is not null) QueryParams["code_challenge"] = builder.CodeChallenge;
            if (builder.CodeChallengeMethod is not null) QueryParams["code_challenge_method"] = builder.CodeChallengeMethod.Value;
            if (builder.CreateHeadless != null) QueryParams["createHeadless"] = Convert.ToString(builder.CreateHeadless)!;
            if (builder.OneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = builder.OneTimeLinkCode;
            if (builder.RedirectUri is not null) QueryParams["redirect_uri"] = builder.RedirectUri;
            if (builder.Scope is not null) QueryParams["scope"] = builder.Scope;
            if (builder.State is not null) QueryParams["state"] = builder.State;
            if (builder.TargetAuthPage is not null) QueryParams["target_auth_page"] = builder.TargetAuthPage;
            if (builder.UseRedirectUriAsLoginUrlWhenLocked != null) QueryParams["useRedirectUriAsLoginUrlWhenLocked"] = Convert.ToString(builder.UseRedirectUriAsLoginUrlWhenLocked)!;
            if (clientId is not null) QueryParams["client_id"] = clientId;
            if (responseType is not null) QueryParams["response_type"] = responseType.Value;
            

            
            
            
            LocationQuery = "request_id";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public AuthorizeV3(
            string? codeChallenge,            
            AuthorizeV3CodeChallengeMethod? codeChallengeMethod,            
            bool? createHeadless,            
            string? oneTimeLinkCode,            
            string? redirectUri,            
            string? scope,            
            string? state,            
            string? targetAuthPage,            
            bool? useRedirectUriAsLoginUrlWhenLocked,            
            string clientId,            
            AuthorizeV3ResponseType responseType            
        )
        {
            
            if (codeChallenge is not null) QueryParams["code_challenge"] = codeChallenge;
            if (codeChallengeMethod is not null) QueryParams["code_challenge_method"] = codeChallengeMethod.Value;
            if (createHeadless != null) QueryParams["createHeadless"] = Convert.ToString(createHeadless)!;
            if (oneTimeLinkCode is not null) QueryParams["oneTimeLinkCode"] = oneTimeLinkCode;
            if (redirectUri is not null) QueryParams["redirect_uri"] = redirectUri;
            if (scope is not null) QueryParams["scope"] = scope;
            if (state is not null) QueryParams["state"] = state;
            if (targetAuthPage is not null) QueryParams["target_auth_page"] = targetAuthPage;
            if (useRedirectUriAsLoginUrlWhenLocked != null) QueryParams["useRedirectUriAsLoginUrlWhenLocked"] = Convert.ToString(useRedirectUriAsLoginUrlWhenLocked)!;
            if (clientId is not null) QueryParams["client_id"] = clientId;
            if (responseType is not null) QueryParams["response_type"] = responseType.Value;
            

            
            
            
            LocationQuery = "request_id";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

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

    public class AuthorizeV3CodeChallengeMethod : StringEnum<AuthorizeV3CodeChallengeMethod>
    {
        public static readonly AuthorizeV3CodeChallengeMethod S256
            = new AuthorizeV3CodeChallengeMethod("S256");

        public static readonly AuthorizeV3CodeChallengeMethod Plain
            = new AuthorizeV3CodeChallengeMethod("plain");


        public static implicit operator AuthorizeV3CodeChallengeMethod(string value)
        {
            return NewValue(value);
        }

        public AuthorizeV3CodeChallengeMethod(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AuthorizeV3ResponseType : StringEnum<AuthorizeV3ResponseType>
    {
        public static readonly AuthorizeV3ResponseType Code
            = new AuthorizeV3ResponseType("code");


        public static implicit operator AuthorizeV3ResponseType(string value)
        {
            return NewValue(value);
        }

        public AuthorizeV3ResponseType(string enumValue)
            : base(enumValue)
        {

        }
    }

}