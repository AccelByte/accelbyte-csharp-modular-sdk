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
    /// PublicListUserIDByPlatformUserIDsV4
    ///
    /// List User ID By Platform User ID
    /// This endpoint intended to list game user ID from the given namespace
    /// This endpoint return list of user ID by given platform ID and list of platform user ID, the max count is 100.
    /// 
    /// Supported platform:
    /// - steam
    /// - steamopenid
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - live
    /// - xblweb
    /// - oculus
    /// - oculusweb
    /// - facebook
    /// - google
    /// - googleplaygames
    /// - twitch
    /// - discord
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
    /// 
    /// If the request body exceed the max limitation, the max count will be in response body's messageVariables: "messageVariables": {"maxCount": "100"}
    /// </summary>
    public class PublicListUserIDByPlatformUserIDsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserIDByPlatformUserIDsV4Builder Builder { get => new PublicListUserIDByPlatformUserIDsV4Builder(); }

        public class PublicListUserIDByPlatformUserIDsV4Builder
            : OperationBuilder<PublicListUserIDByPlatformUserIDsV4Builder>
        {

            public bool? RawPUID { get; set; }





            internal PublicListUserIDByPlatformUserIDsV4Builder() { }

            internal PublicListUserIDByPlatformUserIDsV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListUserIDByPlatformUserIDsV4Builder SetRawPUID(bool _rawPUID)
            {
                RawPUID = _rawPUID;
                return this;
            }





            public PublicListUserIDByPlatformUserIDsV4 Build(
                ModelPlatformUserIDRequestV4 body,
                string namespace_,
                string platformId
            )
            {
                PublicListUserIDByPlatformUserIDsV4 op = new PublicListUserIDByPlatformUserIDsV4(this,
                    body,
                    namespace_,
                    platformId
                );

                op.SetBaseFields<PublicListUserIDByPlatformUserIDsV4Builder>(this);
                return op;
            }

            public Model.AccountcommonUserPlatforms? Execute(
                ModelPlatformUserIDRequestV4 body,
                string namespace_,
                string platformId
            )
            {
                PublicListUserIDByPlatformUserIDsV4 op = Build(
                    body,
                    namespace_,
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.AccountcommonUserPlatforms?> ExecuteAsync(
                ModelPlatformUserIDRequestV4 body,
                string namespace_,
                string platformId
            )
            {
                PublicListUserIDByPlatformUserIDsV4 op = Build(
                    body,
                    namespace_,
                    platformId
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

        private PublicListUserIDByPlatformUserIDsV4(PublicListUserIDByPlatformUserIDsV4Builder builder,
            ModelPlatformUserIDRequestV4 body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (builder.RawPUID != null) QueryParams["rawPUID"] = Convert.ToString(builder.RawPUID)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserIDByPlatformUserIDsV4(
            string namespace_,
            string platformId,
            bool? rawPUID,
            Model.ModelPlatformUserIDRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;

            if (rawPUID != null) QueryParams["rawPUID"] = Convert.ToString(rawPUID)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/platforms/{platformId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountcommonUserPlatforms? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}