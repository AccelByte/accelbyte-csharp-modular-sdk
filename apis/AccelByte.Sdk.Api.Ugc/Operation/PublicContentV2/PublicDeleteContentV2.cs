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
    /// PublicDeleteContentV2
    ///
    /// Delete existing content
    /// </summary>
    public class PublicDeleteContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeleteContentV2Builder Builder { get => new PublicDeleteContentV2Builder(); }

        public class PublicDeleteContentV2Builder
            : OperationBuilder<PublicDeleteContentV2Builder>
        {





            internal PublicDeleteContentV2Builder() { }

            internal PublicDeleteContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeleteContentV2 Build(
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                PublicDeleteContentV2 op = new PublicDeleteContentV2(this,
                    channelId,
                    contentId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicDeleteContentV2Builder>(this);
                return op;
            }

            public void Execute(
                string channelId,
                string contentId,
                string namespace_,
                string userId
            )
            {
                PublicDeleteContentV2 op = Build(
                    channelId,
                    contentId,
                    namespace_,
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
                string contentId,
                string namespace_,
                string userId
            )
            {
                PublicDeleteContentV2 op = Build(
                    channelId,
                    contentId,
                    namespace_,
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

        private PublicDeleteContentV2(PublicDeleteContentV2Builder builder,
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeleteContentV2(
            string channelId,
            string contentId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}";

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