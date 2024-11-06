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
    /// PublicPlatformLinkV2
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId} [POST]_**
    /// 
    /// **Prerequisite:**
    /// Platform client configuration need to be added to database for specific platformId. Namespace service URL need to be specified (refer to required environment variables).
    /// 
    /// ## Supported platforms:
    /// - **steam**: The ticketâs value is the authentication code returned by Steam.
    /// - **steamopenid**: Steam's user authentication method using OpenID 2.0. The ticket's value is URL generated by Steam on web authentication
    /// - **facebook**: The ticketâs value is the authorization code returned by Facebook OAuth
    /// - **google**: The ticketâs value is the authorization code returned by Google OAuth
    /// - **oculus**: The ticketâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// - **twitch**: The ticketâs value is the authorization code returned by Twitch OAuth.
    /// - **android**: The ticket's value is the Androidâs device ID
    /// - **ios**: The ticket's value is the iOSâs device ID.
    /// - **device**: Every device that doesn't run Android and iOS is categorized as a device platform. The ticket's value is the deviceâs ID.
    /// - **discord**: The ticketâs value is the authorization code returned by Discord OAuth.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class PublicPlatformLinkV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformLinkV2Builder Builder { get => new PublicPlatformLinkV2Builder(); }

        public class PublicPlatformLinkV2Builder
            : OperationBuilder<PublicPlatformLinkV2Builder>
        {





            internal PublicPlatformLinkV2Builder() { }

            internal PublicPlatformLinkV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPlatformLinkV2 Build(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                PublicPlatformLinkV2 op = new PublicPlatformLinkV2(this,
                    ticket,                    
                    namespace_,                    
                    platformId,                    
                    userId                    
                );

                op.SetBaseFields<PublicPlatformLinkV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public PublicPlatformLinkV2.Response Execute(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                PublicPlatformLinkV2 op = Build(
                    ticket,
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
            public async Task<PublicPlatformLinkV2.Response> ExecuteAsync(
                string ticket,
                string namespace_,
                string platformId,
                string userId
            )
            {
                PublicPlatformLinkV2 op = Build(
                    ticket,
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

        private PublicPlatformLinkV2(PublicPlatformLinkV2Builder builder,
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

        #region Response Part        
        public class Response : ApiResponse
        {

            public string Error400 { get; set; } = "";

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error404 { get; set; } = "";

            public string Error409 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::PublicPlatformLinkV2";
        }

        #endregion

        public PublicPlatformLinkV2(
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

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicPlatformLinkV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicPlatformLinkV2.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error400!);
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
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)409)
            
            {
                response.Error409 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error409!);
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}