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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicCreateChannel
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CHANNEL [CREATE]
    /// </summary>
    public class PublicCreateChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateChannelBuilder Builder { get => new PublicCreateChannelBuilder(); }

        public class PublicCreateChannelBuilder
            : OperationBuilder<PublicCreateChannelBuilder>
        {





            internal PublicCreateChannelBuilder() { }

            internal PublicCreateChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateChannel Build(
                ModelsPublicChannelRequest body,
                string namespace_,
                string userId
            )
            {
                PublicCreateChannel op = new PublicCreateChannel(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsChannelResponse? Execute(
                ModelsPublicChannelRequest body,
                string namespace_,
                string userId
            )
            {
                PublicCreateChannel op = Build(
                    body,
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
        }

        private PublicCreateChannel(PublicCreateChannelBuilder builder,
            ModelsPublicChannelRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateChannel(
            string namespace_,
            string userId,
            Model.ModelsPublicChannelRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json", "application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}