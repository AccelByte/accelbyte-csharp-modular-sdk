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
    /// PublicDeleteContentByShareCode
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class PublicDeleteContentByShareCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeleteContentByShareCodeBuilder Builder { get => new PublicDeleteContentByShareCodeBuilder(); }

        public class PublicDeleteContentByShareCodeBuilder
            : OperationBuilder<PublicDeleteContentByShareCodeBuilder>
        {





            internal PublicDeleteContentByShareCodeBuilder() { }

            internal PublicDeleteContentByShareCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeleteContentByShareCode Build(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicDeleteContentByShareCode op = new PublicDeleteContentByShareCode(this,
                    channelId,
                    namespace_,
                    shareCode,
                    userId
                );

                op.SetBaseFields<PublicDeleteContentByShareCodeBuilder>(this);
                return op;
            }

            public void Execute(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                PublicDeleteContentByShareCode op = Build(
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
                PublicDeleteContentByShareCode op = Build(
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

        private PublicDeleteContentByShareCode(PublicDeleteContentByShareCodeBuilder builder,
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

        public PublicDeleteContentByShareCode(
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

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}";

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