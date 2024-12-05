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
    /// AdminGetThirdPartyPlatformTokenLinkStatusV3
    ///
    /// Admin get the link status of the third party platform token with user id.
    /// 
    /// This endpoint is used for checking whether the third party user represented by third party token is
    /// linked with the corresponding user id.
    /// 
    /// ## Supported platforms:
    /// - **steam**: The platform_tokenâs value is the authentication code returned by Steam.
    /// - **steamopenid**: Steam's user authentication method using OpenID 2.0. The platform_token's value is URL generated by Steam on web authentication
    /// - **facebook**: The platform_tokenâs value is the authorization code returned by Facebook OAuth
    /// - **google**: The platform_tokenâs value is the authorization code returned by Google OAuth
    /// - **googleplaygames**: The platform_tokenâs value is the authorization code returned by Google play games OAuth
    /// - **oculus**: The platform_tokenâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// - **twitch**: The platform_tokenâs value is the authorization code returned by Twitch OAuth.
    /// - **discord**: The platform_tokenâs value is the authorization code returned by Discord OAuth
    /// - **android**: The device_id is the Androidâs device ID
    /// - **ios**: The device_id is the iOSâs device ID.
    /// - **apple**: The platform_tokenâs value is the authorization code returned by Apple OAuth.(We will use this code to generate APP token)
    /// - **device**: Every device that doesânt run Android and iOS is categorized as a device. The device_id is the deviceâs ID.
    /// - **justice**: The platform_tokenâs value is the designated userâs access token.
    /// - **epicgames**: The platform_tokenâs value is an access-token obtained from Epicgames EOS Account Service.
    /// - **ps4**: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// - **ps5**: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// - **nintendo**: The platform_tokenâs value is the authorization code(id_token) returned by Nintendo OAuth.
    /// - **awscognito**: The platform_tokenâs value is the aws cognito access token or id token (JWT).
    /// - **live**: The platform_tokenâs value is xbox XSTS token
    /// - **xblweb**: The platform_tokenâs value is code returned by xbox after login
    /// - **netflix**: The platform_tokenâs value is GAT (Gamer Access Token) returned by Netflix backend
    /// - **snapchat**: The platform_tokenâs value is the authorization code returned by Snapchat OAuth.
    /// </summary>
    public class AdminGetThirdPartyPlatformTokenLinkStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetThirdPartyPlatformTokenLinkStatusV3Builder Builder { get => new AdminGetThirdPartyPlatformTokenLinkStatusV3Builder(); }

        public class AdminGetThirdPartyPlatformTokenLinkStatusV3Builder
            : OperationBuilder<AdminGetThirdPartyPlatformTokenLinkStatusV3Builder>
        {





            internal AdminGetThirdPartyPlatformTokenLinkStatusV3Builder() { }

            internal AdminGetThirdPartyPlatformTokenLinkStatusV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetThirdPartyPlatformTokenLinkStatusV3 Build(
                string platformToken,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetThirdPartyPlatformTokenLinkStatusV3 op = new AdminGetThirdPartyPlatformTokenLinkStatusV3(this,
                    platformToken,
                    namespace_,
                    platformId,
                    userId
                );

                op.SetBaseFields<AdminGetThirdPartyPlatformTokenLinkStatusV3Builder>(this);
                return op;
            }

            public AdminGetThirdPartyPlatformTokenLinkStatusV3.Response Execute(
                string platformToken,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetThirdPartyPlatformTokenLinkStatusV3 op = Build(
                    platformToken,
                    namespace_,
                    platformId,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGetThirdPartyPlatformTokenLinkStatusV3.Response> ExecuteAsync(
                string platformToken,
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminGetThirdPartyPlatformTokenLinkStatusV3 op = Build(
                    platformToken,
                    namespace_,
                    platformId,
                    userId
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

        private AdminGetThirdPartyPlatformTokenLinkStatusV3(AdminGetThirdPartyPlatformTokenLinkStatusV3Builder builder,
            string platformToken,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (platformToken is not null) FormParams["platformToken"] = platformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelTokenThirdPartyLinkStatusResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminGetThirdPartyPlatformTokenLinkStatusV3";
        }

        #endregion

        public AdminGetThirdPartyPlatformTokenLinkStatusV3(
            string namespace_,
            string platformId,
            string userId,
            string platformToken
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;


            if (platformToken is not null) FormParams["platformToken"] = platformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/linkStatus";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public AdminGetThirdPartyPlatformTokenLinkStatusV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetThirdPartyPlatformTokenLinkStatusV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelTokenThirdPartyLinkStatusResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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