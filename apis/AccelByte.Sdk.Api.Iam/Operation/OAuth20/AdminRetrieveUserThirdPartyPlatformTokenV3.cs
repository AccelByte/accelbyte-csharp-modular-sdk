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
    /// AdminRetrieveUserThirdPartyPlatformTokenV3
    ///
    /// Admin Retrieve User Third Party Platform Token
    /// This endpoint used for retrieving third party platform token for user that login using third party,
    /// if user have not link requested platform in game namespace, will try to retrieving third party platform token from publisher namespace.
    /// Passing platform group name or it's member will return same access token that can be used across the platform members.
    /// If platformUserId provided, IAM will prefer to get platform token by platform user id.
    /// 
    /// Notes:
    /// The third party platform and platform group covered for this is:
    /// - (psn) ps4web
    /// - (psn) ps4
    /// - (psn) ps5
    /// - epicgames
    /// - twitch
    /// - awscognito
    /// - amazon
    /// - eaorigin
    /// - snapchat
    /// - twitch
    /// - live
    /// </summary>
    public class AdminRetrieveUserThirdPartyPlatformTokenV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRetrieveUserThirdPartyPlatformTokenV3Builder Builder { get => new AdminRetrieveUserThirdPartyPlatformTokenV3Builder(); }

        public class AdminRetrieveUserThirdPartyPlatformTokenV3Builder
            : OperationBuilder<AdminRetrieveUserThirdPartyPlatformTokenV3Builder>
        {

            public string? PlatformUserId { get; set; }





            internal AdminRetrieveUserThirdPartyPlatformTokenV3Builder() { }

            internal AdminRetrieveUserThirdPartyPlatformTokenV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminRetrieveUserThirdPartyPlatformTokenV3Builder SetPlatformUserId(string _platformUserId)
            {
                PlatformUserId = _platformUserId;
                return this;
            }





            public AdminRetrieveUserThirdPartyPlatformTokenV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminRetrieveUserThirdPartyPlatformTokenV3 op = new AdminRetrieveUserThirdPartyPlatformTokenV3(this,
                    namespace_,                    
                    platformId,                    
                    userId                    
                );

                op.SetBaseFields<AdminRetrieveUserThirdPartyPlatformTokenV3Builder>(this);
                return op;
            }

            public AdminRetrieveUserThirdPartyPlatformTokenV3.Response Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminRetrieveUserThirdPartyPlatformTokenV3 op = Build(
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
            public async Task<AdminRetrieveUserThirdPartyPlatformTokenV3.Response> ExecuteAsync(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminRetrieveUserThirdPartyPlatformTokenV3 op = Build(
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

        private AdminRetrieveUserThirdPartyPlatformTokenV3(AdminRetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            if (builder.PlatformUserId is not null) QueryParams["platformUserId"] = builder.PlatformUserId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.OauthmodelTokenThirdPartyResponse>
        {

            public OauthmodelErrorResponse? Error401 { get; set; } = null;

            public OauthmodelErrorResponse? Error403 { get; set; } = null;

            public OauthmodelErrorResponse? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OAuth20::AdminRetrieveUserThirdPartyPlatformTokenV3";
        }

        #endregion

        public AdminRetrieveUserThirdPartyPlatformTokenV3(
            string namespace_,            
            string platformId,            
            string userId,            
            string? platformUserId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            if (platformUserId is not null) QueryParams["platformUserId"] = platformUserId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminRetrieveUserThirdPartyPlatformTokenV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminRetrieveUserThirdPartyPlatformTokenV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<OauthmodelErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}