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
    /// PublicPlatformUnlinkAllV3
    ///
    /// Unlink user's account from third platform in all namespaces.
    /// 
    /// This API support to handling platform group use case:
    /// i.e.
    /// 1. Steam group: steam, steamopenid
    /// 2. PSN group: ps4, ps5, psnweb
    /// 3. XBOX group: live, xblweb
    /// 
    /// Example: if user unlink from ps4, the API logic will unlink ps5 and psnweb as well.
    /// </summary>
    public class PublicPlatformUnlinkAllV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformUnlinkAllV3Builder Builder { get => new PublicPlatformUnlinkAllV3Builder(); }

        public class PublicPlatformUnlinkAllV3Builder
            : OperationBuilder<PublicPlatformUnlinkAllV3Builder>
        {





            internal PublicPlatformUnlinkAllV3Builder() { }

            internal PublicPlatformUnlinkAllV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicPlatformUnlinkAllV3 Build(
                string namespace_,
                string platformId
            )
            {
                PublicPlatformUnlinkAllV3 op = new PublicPlatformUnlinkAllV3(this,
                    namespace_,
                    platformId
                );

                op.SetBaseFields<PublicPlatformUnlinkAllV3Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string platformId
            )
            {
                PublicPlatformUnlinkAllV3 op = Build(
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

        private PublicPlatformUnlinkAllV3(PublicPlatformUnlinkAllV3Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPlatformUnlinkAllV3(
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/all";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

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