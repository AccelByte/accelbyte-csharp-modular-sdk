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
    /// PublicForcePlatformLinkV3
    ///
    /// Force linking user account with platform.
    /// 
    /// If this platform account was already linked to another user account, this endpoint will perform force linking and remove platform from that conflict user, not only from the current request namespace but also include all the enrolled namespaces.
    /// 
    /// If current user have linked to this platform with another platform account (include once linked but it is unlinked now), it will not allow user to perform linking.
    /// 
    /// 
    /// ## Supported platforms:
    /// 
    /// 
    /// 
    /// 
    ///                       * steam : The platform_tokenâs value is the binary ticket returned by Steam.
    /// 
    /// 
    ///                       * steamopenid : Steam's user authentication method using OpenID 2.0. The platform_token's value is URL generated by Steam on web authentication
    /// 
    /// 
    ///                       * facebook : The platform_tokenâs value is the authorization code returned by Facebook OAuth
    /// 
    /// 
    ///                       * google : The platform_tokenâs value is the authorization code returned by Google OAuth
    /// 
    /// 
    ///                       * oculus : The platform_tokenâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// 
    /// 
    ///                       * twitch : The platform_tokenâs value is the authorization code returned by Twitch OAuth.
    /// 
    /// 
    ///                       * discord : The platform_tokenâs value is the authorization code returned by Discord OAuth
    /// 
    /// 
    ///                       * android : The device_id is the Androidâs device ID
    /// 
    /// 
    ///                       * ios : The device_id is the iOSâs device ID.
    /// 
    /// 
    ///                       * apple : The platform_tokenâs value is the authorization code returned by Apple OAuth.(We will use this code to generate APP token)
    /// 
    /// 
    ///                       * device : Every device that doesânt run Android and iOS is categorized as a device. The device_id is the deviceâs ID.
    /// 
    /// 
    ///                       * justice : The platform_tokenâs value is the designated userâs access token.
    /// 
    /// 
    ///                       * epicgames : The platform_tokenâs value is an access-token obtained from Epicgames EOS Account Service.
    /// 
    /// 
    ///                       * ps4 : The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// 
    /// 
    ///                       * ps5 : The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// 
    /// 
    ///                       * nintendo : The platform_tokenâs value is the id_token returned by Nintendo OAuth.
    /// 
    /// 
    ///                       * awscognito : The platform_tokenâs value is the aws cognito access token or id token (JWT).
    /// 
    /// 
    ///                       * live : The platform_tokenâs value is xbox XSTS token
    /// 
    /// 
    ///                       * xblweb : The platform_tokenâs value is code returned by xbox after login
    /// 
    /// 
    ///                       * netflix : The platform_tokenâs value is GAT (Gamer Access Token) returned by Netflix backend
    /// 
    /// 
    ///                       * snapchat : The platform_tokenâs value is the authorization code returned by Snapchat OAuth.
    /// 
    /// 
    ///                       * for specific generic oauth (OIDC) : The platform_tokenâs value should be the same type as created OIDC auth type whether it is auth code, idToken or bearerToken.
    /// </summary>
    public class PublicForcePlatformLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicForcePlatformLinkV3Builder Builder { get => new PublicForcePlatformLinkV3Builder(); }

        public class PublicForcePlatformLinkV3Builder
            : OperationBuilder<PublicForcePlatformLinkV3Builder>
        {





            internal PublicForcePlatformLinkV3Builder() { }

            internal PublicForcePlatformLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicForcePlatformLinkV3 Build(
                string ticket,
                string namespace_,
                string platformId
            )
            {
                PublicForcePlatformLinkV3 op = new PublicForcePlatformLinkV3(this,
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
                PublicForcePlatformLinkV3 op = Build(
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

        private PublicForcePlatformLinkV3(PublicForcePlatformLinkV3Builder builder,
            string ticket,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicForcePlatformLinkV3(
            string namespace_,
            string platformId,
            string ticket
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/force";

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