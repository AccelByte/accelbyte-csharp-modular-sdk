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
    /// AdminPlatformLinkV3
    ///
    /// **Prerequisite:** Platform client configuration need to be added to database for specific platformId. Namespace service URL need to be specified (refer to required environment variables).
    /// ## Supported platforms:
    /// - **steam**: The ticketâs value is the authentication code returned by Steam.
    /// - **steamopenid**: Steam's user authentication method using OpenID 2.0. The ticket's value is URL generated by Steam on web authentication
    /// - **facebook**: The ticketâs value is the authorization code returned by Facebook OAuth
    /// - **google**: The ticketâs value is the authorization code returned by Google OAuth
    /// - **oculus**: The ticketâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// - **twitch**: The ticketâs value is the authorization code returned by Twitch OAuth.
    /// - **android**: The ticket's value is the Androidâs device ID
    /// - **ios**: The ticket's value is the iOSâs device ID.
    /// - **apple**: The ticketâs value is the authorization code returned by Apple OAuth.
    /// - **device**: Every device that doesânt run Android and iOS is categorized as a device platform. The ticket's value is the deviceâs ID.
    /// - **discord**: The ticketâs value is the authorization code returned by Discord OAuth.
    /// - **awscognito**: The ticketâs value is the aws cognito access token (JWT).
    /// - **epicgames**: The ticketâs value is an access-token obtained from Epicgames EOS Account Service.
    /// - **nintendo**: The ticketâs value is the authorization code(id_token) returned by Nintendo OAuth.
    /// </summary>
    public class AdminPlatformLinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPlatformLinkV3Builder Builder { get => new AdminPlatformLinkV3Builder(); }

        public class AdminPlatformLinkV3Builder
            : OperationBuilder<AdminPlatformLinkV3Builder>
        {





            internal AdminPlatformLinkV3Builder() { }

            internal AdminPlatformLinkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPlatformLinkV3 Build(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminPlatformLinkV3 op = new AdminPlatformLinkV3(this,
                    ticket,
                    namespace_,
                    platformId,
                    userId
                );

                op.SetBaseFields<AdminPlatformLinkV3Builder>(this);
                return op;
            }

            public void Execute(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminPlatformLinkV3 op = Build(
                    ticket,
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminPlatformLinkV3 op = Build(
                    ticket,
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminPlatformLinkV3(AdminPlatformLinkV3Builder builder,
            string ticket,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminPlatformLinkV3(
            string namespace_,
            string platformId,
            string userId,
            string ticket
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (ticket is not null) FormParams["ticket"] = ticket;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link";

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