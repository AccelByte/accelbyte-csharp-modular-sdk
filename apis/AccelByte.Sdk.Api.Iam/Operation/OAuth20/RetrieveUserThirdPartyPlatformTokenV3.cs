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
    /// RetrieveUserThirdPartyPlatformTokenV3
    ///
    /// Retrieve User Third Party Platform Token
    /// 
    /// 
    /// 
    /// 
    /// This endpoint used for retrieving third party platform token for user that login using third party,
    /// if user have not link requested platform in game namespace, will try to retrieving third party platform token from publisher namespace.
    /// Passing platform group name or it's member will return same access token that can be used across the platform members.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// The third party platform and platform group covered for this is:
    /// 
    /// 
    /// 
    /// 
    ///                 * (psn) ps4web
    /// 
    /// 
    ///                 * (psn) ps4
    /// 
    /// 
    ///                 * (psn) ps5
    /// 
    /// 
    ///                 * epicgames
    /// 
    /// 
    ///                 * twitch
    /// 
    /// 
    ///                 * awscognito
    /// </summary>
    public class RetrieveUserThirdPartyPlatformTokenV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveUserThirdPartyPlatformTokenV3Builder Builder { get => new RetrieveUserThirdPartyPlatformTokenV3Builder(); }

        public class RetrieveUserThirdPartyPlatformTokenV3Builder
            : OperationBuilder<RetrieveUserThirdPartyPlatformTokenV3Builder>
        {





            internal RetrieveUserThirdPartyPlatformTokenV3Builder() { }

            internal RetrieveUserThirdPartyPlatformTokenV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveUserThirdPartyPlatformTokenV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                RetrieveUserThirdPartyPlatformTokenV3 op = new RetrieveUserThirdPartyPlatformTokenV3(this,
                    namespace_,
                    platformId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.OauthmodelTokenThirdPartyResponse? Execute(
                string namespace_,
                string platformId,
                string userId
            )
            {
                RetrieveUserThirdPartyPlatformTokenV3 op = Build(
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
        }

        private RetrieveUserThirdPartyPlatformTokenV3(RetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveUserThirdPartyPlatformTokenV3(
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenThirdPartyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}