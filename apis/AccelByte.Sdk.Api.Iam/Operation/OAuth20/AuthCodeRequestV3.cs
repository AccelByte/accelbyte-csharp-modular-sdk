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
    /// AuthCodeRequestV3
    ///
    /// Generate url to request auth code from third party platform
    /// 
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    ///               * steamopenid
    /// This endpoint redirects to steam login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating user steam.
    /// 
    ///               * xblweb
    /// This endpoint redirects to xbox login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating xbox user.
    /// 
    ///               * ps4web
    /// This endpoint redirects to psn login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating psn user.
    /// 
    ///               * epicgames
    /// This endpoint redirects to Epicgames OAuth login page. then redirect to platform
    /// authenticate endpoint after successfully authenticating an Epicgames credential
    /// 
    ///               * twitch
    /// This endpoint redirects to twitch login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating twitch user.
    /// 
    ///               * azure
    /// This endpoint redirects to azure login page, then redirect back to platform
    /// authenticate(saml) endpoint after successfully authenticating azure user.
    /// 
    ///               * facebook
    /// This endpoint redirects to facebook login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating facebook user.
    /// 
    ///               * google
    /// This endpoint redirects to google login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating google user.
    /// 
    ///               * snapchat
    /// This endpoint redirects to snapchat login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating snapchat user.
    /// 
    ///               * discord
    /// This endpoint redirects to discord login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating discord user.
    /// 
    ///               * amazon
    /// This endpoint redirects to amazon login page, then redirect back to platform
    /// authenticate endpoint after successfully authenticating amazon user.
    /// 
    ///               * oculusweb
    /// This endpoint redirects to oculus login page, then redirect back to Login Website page after successfully authenticating oculus user.
    /// action code : 10702'
    /// </summary>
    public class AuthCodeRequestV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AuthCodeRequestV3Builder Builder { get => new AuthCodeRequestV3Builder(); }

        public class AuthCodeRequestV3Builder
            : OperationBuilder<AuthCodeRequestV3Builder>
        {

            public string? ClientId { get; set; }

            public string? RedirectUri { get; set; }





            internal AuthCodeRequestV3Builder() { }

            internal AuthCodeRequestV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AuthCodeRequestV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public AuthCodeRequestV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }





            public AuthCodeRequestV3 Build(
                string platformId,
                string requestId
            )
            {
                AuthCodeRequestV3 op = new AuthCodeRequestV3(this,
                    platformId,
                    requestId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public string Execute(
                string platformId,
                string requestId
            )
            {
                AuthCodeRequestV3 op = Build(
                    platformId,
                    requestId
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

        private AuthCodeRequestV3(AuthCodeRequestV3Builder builder,
            string platformId,
            string requestId
        )
        {
            PathParams["platformId"] = platformId;

            if (builder.ClientId is not null) QueryParams["client_id"] = builder.ClientId;
            if (builder.RedirectUri is not null) QueryParams["redirect_uri"] = builder.RedirectUri;
            if (requestId is not null) QueryParams["request_id"] = requestId;





            LocationQuery = "code";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AuthCodeRequestV3(
            string platformId,
            string? clientId,
            string? redirectUri,
            string requestId
        )
        {
            PathParams["platformId"] = platformId;

            if (clientId is not null) QueryParams["client_id"] = clientId;
            if (redirectUri is not null) QueryParams["redirect_uri"] = redirectUri;
            if (requestId is not null) QueryParams["request_id"] = requestId;





            LocationQuery = "code";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/platforms/{platformId}/authorize";

        public override HttpMethod Method => HttpMethod.Get;

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