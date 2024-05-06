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
    /// PublicGetUserByPlatformUserIDV3
    ///
    /// Get User By Platform User ID.
    /// This endpoint return user information by given platform ID and platform user ID.
    /// Several platforms are grouped under account groups, you can use either platform ID or platform group as platformId path parameter.
    /// example: for steam network platform, you can use steamnetwork / steam / steamopenid as platformId path parameter.
    /// 
    /// Supported platform:
    /// - Steam group(steamnetwork)
    /// - steam
    /// - steamopenid
    /// - PSN group(psn)
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox)
    /// - live
    /// - xblweb
    /// - Oculus group(oculusgroup)
    /// - oculus
    /// - oculusweb
    /// - facebook
    /// - google
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - justice
    /// - epicgames
    /// - nintendo
    /// - awscognito
    /// - netflix
    /// - snapchat
    /// - oidc platform id
    /// 
    /// Note:
    /// **nintendo platform user ID**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class PublicGetUserByPlatformUserIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserByPlatformUserIDV3Builder Builder { get => new PublicGetUserByPlatformUserIDV3Builder(); }

        public class PublicGetUserByPlatformUserIDV3Builder
            : OperationBuilder<PublicGetUserByPlatformUserIDV3Builder>
        {





            internal PublicGetUserByPlatformUserIDV3Builder() { }

            internal PublicGetUserByPlatformUserIDV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserByPlatformUserIDV3 Build(
                string namespace_,
                string platformId,
                string platformUserId
            )
            {
                PublicGetUserByPlatformUserIDV3 op = new PublicGetUserByPlatformUserIDV3(this,
                    namespace_,
                    platformId,
                    platformUserId
                );

                op.SetBaseFields<PublicGetUserByPlatformUserIDV3Builder>(this);
                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                string namespace_,
                string platformId,
                string platformUserId
            )
            {
                PublicGetUserByPlatformUserIDV3 op = Build(
                    namespace_,
                    platformId,
                    platformUserId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelUserResponseV3?> ExecuteAsync(
                string namespace_,
                string platformId,
                string platformUserId
            )
            {
                PublicGetUserByPlatformUserIDV3 op = Build(
                    namespace_,
                    platformId,
                    platformUserId
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

        private PublicGetUserByPlatformUserIDV3(PublicGetUserByPlatformUserIDV3Builder builder,
            string namespace_,
            string platformId,
            string platformUserId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["platformUserId"] = platformUserId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserByPlatformUserIDV3(
            string namespace_,
            string platformId,
            string platformUserId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["platformUserId"] = platformUserId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}