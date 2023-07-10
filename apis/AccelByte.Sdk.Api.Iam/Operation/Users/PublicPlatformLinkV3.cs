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
    /// PublicPlatformLinkV3
    ///
    /// Required valid user authorization.
    /// 
    /// 
    /// 
    /// Prerequisite:
    /// Platform client configuration need to be added to database for specific platformId. Namespace service URL need to be specified (refer to required environment variables).
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    ///                       * steam : The ticketâs value is the binary ticket returned by Steam.
    /// 
    /// 
    ///                       * steamopenid : Steam's user authentication method using OpenID 2.0. The ticket's value is URL generated by Steam on web authentication
    /// 
    /// 
    ///                       * facebook : The ticketâs value is the authorization code returned by Facebook OAuth
    /// 
    /// 
    ///                       * google : The ticketâs value is the authorization code returned by Google OAuth
    /// 
    /// 
    ///                       * oculus : The ticketâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// 
    /// 
    ///                       * twitch : The ticketâs value is the authorization code returned by Twitch OAuth.
    /// 
    /// 
    ///                       * android : The ticket's value is the Androidâs device ID
    /// 
    /// 
    ///                       * ios : The ticket's value is the iOSâs device ID.
    /// 
    /// 
    ///                       * apple : The ticketâs value is the authorization code returned by Apple OAuth.
    /// 
    /// 
    ///                       * device : Every device that doesn't run Android and iOS is categorized as a device platform. The ticket's value is the deviceâs ID.
    /// 
    /// 
    ///                       * discord : The ticketâs value is the authorization code returned by Discord OAuth.
    /// 
    /// 
    ///                       * ps4web : The ticketâs value is the authorization code returned by PSN OAuth.
    /// 
    /// 
    ///                       * ps4 : The ticketâs value is the authorization code returned by PSN OAuth.
    /// 
    /// 
    ///                       * ps5 : The ticketâs value is the authorization code returned by PSN OAuth.
    /// 
    /// 
    ///                       * xblweb : The ticketâs value is the authorization code returned by XBox Live OAuth.
    /// 
    /// 
    ///                       * live : The ticketâs value is the XSTS token.
    /// 
    /// 
    ///                       * awscognito : The ticketâs value is the aws cognito access token (JWT).
    /// 
    /// 
    ///                       * epicgames : The ticketâs value is an access-token or authorization code obtained from Epicgames EOS Account Service.
    /// 
    /// 
    ///                       * nintendo : The ticketâs value is the id_token returned by Nintendo OAuth.
    /// 
    /// 
    ///                       * netflix : The ticketâs value is GAT (Gamer Access Token) returned by Netflix backend.
    /// 
    /// 
    ///                       * snapchat : The ticketâs value is authorization code returned by Snapchat OAuth.
    /// 
    /// 
    ///                       * for specific generic oauth (OIDC) : The platform_tokenâs value should be the same type as created OIDC auth type whether it is auth code, idToken or bearerToken.
    /// 
    /// 
    /// 
    /// action code : 10144
    /// </summary>
    public class PublicPlatformLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformLinkV3Builder Builder { get => new PublicPlatformLinkV3Builder(); }

        public class PublicPlatformLinkV3Builder
            : OperationBuilder<PublicPlatformLinkV3Builder>
        {



            public string? RedirectUri { get; set; }



            internal PublicPlatformLinkV3Builder() { }

            internal PublicPlatformLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public PublicPlatformLinkV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }



            public PublicPlatformLinkV3 Build(
                string ticket,
                string namespace_,
                string platformId
            )
            {
                PublicPlatformLinkV3 op = new PublicPlatformLinkV3(this,
                    ticket,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string ticket,
                string namespace_,
                string platformId
            )
            {
                PublicPlatformLinkV3 op = Build(
                    ticket,
                    namespace_,
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicPlatformLinkV3(PublicPlatformLinkV3Builder builder,
            string ticket,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (builder.RedirectUri is not null) FormParams["redirectUri"] = builder.RedirectUri;
            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPlatformLinkV3(
            string namespace_,
            string platformId,
            string? redirectUri,
            string ticket
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (redirectUri is not null) FormParams["redirectUri"] = redirectUri;
            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}