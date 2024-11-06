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
    /// PublicGetUserPlatformAccountsV3
    ///
    /// This endpoint retrieves platform accounts linked to user.
    /// 
    /// 
    /// **Supported Platforms:**
    /// - Steam group (steamnetwork):
    /// - steam
    /// - steamopenid
    /// - PSN group (psn):
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox):
    /// - live
    /// - xblweb
    /// - Oculus group (oculusgroup):
    /// - oculus
    /// - oculusweb
    /// - Google group (google):
    /// - google
    /// - googleplaygames:
    /// - epicgames
    /// - facebook
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - nintendo
    /// - awscognito
    /// - amazon
    /// - netflix
    /// - snapchat
    /// - _oidc platform id_
    /// 
    /// Note:
    /// - You can use either platform id or platform group as **platformId** parameter.
    /// - **Nintendo platform user id**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// 
    /// 
    /// **Authentication:**
    /// The _**userId**_ parameter should match the one in the access token.
    /// 
    /// action code: 10128
    /// </summary>
    public class PublicGetUserPlatformAccountsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserPlatformAccountsV3Builder Builder { get => new PublicGetUserPlatformAccountsV3Builder(); }

        public class PublicGetUserPlatformAccountsV3Builder
            : OperationBuilder<PublicGetUserPlatformAccountsV3Builder>
        {

            public string? After { get; set; }

            public string? Before { get; set; }

            public long? Limit { get; set; }

            public string? PlatformId { get; set; }





            internal PublicGetUserPlatformAccountsV3Builder() { }

            internal PublicGetUserPlatformAccountsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetUserPlatformAccountsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public PublicGetUserPlatformAccountsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public PublicGetUserPlatformAccountsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetUserPlatformAccountsV3Builder SetPlatformId(string _platformId)
            {
                PlatformId = _platformId;
                return this;
            }





            public PublicGetUserPlatformAccountsV3 Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPlatformAccountsV3 op = new PublicGetUserPlatformAccountsV3(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicGetUserPlatformAccountsV3Builder>(this);
                return op;
            }

            public PublicGetUserPlatformAccountsV3.Response Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPlatformAccountsV3 op = Build(
                    namespace_,
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
            public async Task<PublicGetUserPlatformAccountsV3.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPlatformAccountsV3 op = Build(
                    namespace_,
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

        private PublicGetUserPlatformAccountsV3(PublicGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.After is not null) QueryParams["after"] = builder.After;
            if (builder.Before is not null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.PlatformId is not null) QueryParams["platformId"] = builder.PlatformId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AccountcommonUserLinkedPlatformsResponseV3>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicGetUserPlatformAccountsV3";
        }

        #endregion

        public PublicGetUserPlatformAccountsV3(
            string namespace_,            
            string userId,            
            string? after,            
            string? before,            
            long? limit,            
            string? platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (after is not null) QueryParams["after"] = after;
            if (before is not null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (platformId is not null) QueryParams["platformId"] = platformId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetUserPlatformAccountsV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUserPlatformAccountsV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AccountcommonUserLinkedPlatformsResponseV3>(payload, ResponseJsonOptions);
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