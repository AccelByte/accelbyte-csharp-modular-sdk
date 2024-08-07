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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicDeleteContentByShareCodeV2
    ///
    /// Delete existing content by share code
    /// </summary>
    public class PublicDeleteContentByShareCodeV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeleteContentByShareCodeV2Builder Builder { get => new PublicDeleteContentByShareCodeV2Builder(); }

        public class PublicDeleteContentByShareCodeV2Builder
            : OperationBuilder<PublicDeleteContentByShareCodeV2Builder>
        {





            internal PublicDeleteContentByShareCodeV2Builder() { }

            internal PublicDeleteContentByShareCodeV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeleteContentByShareCodeV2 Build(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicDeleteContentByShareCodeV2 op = new PublicDeleteContentByShareCodeV2(this,
                    channelId,
                    namespace_,
                    shareCode,
                    userId
                );

                op.SetBaseFields<PublicDeleteContentByShareCodeV2Builder>(this);
                return op;
            }

            public void Execute(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicDeleteContentByShareCodeV2 op = Build(
                    channelId,
                    namespace_,
                    shareCode,
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
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicDeleteContentByShareCodeV2 op = Build(
                    channelId,
                    namespace_,
                    shareCode,
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

        private PublicDeleteContentByShareCodeV2(PublicDeleteContentByShareCodeV2Builder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeleteContentByShareCodeV2(
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

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