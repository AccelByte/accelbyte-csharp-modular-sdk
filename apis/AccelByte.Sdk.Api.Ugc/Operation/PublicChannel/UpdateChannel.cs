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
    /// UpdateChannel
    ///
    /// Update user channel
    /// </summary>
    public class UpdateChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateChannelBuilder Builder { get => new UpdateChannelBuilder(); }

        public class UpdateChannelBuilder
            : OperationBuilder<UpdateChannelBuilder>
        {





            internal UpdateChannelBuilder() { }

            internal UpdateChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateChannel Build(
                ModelsUpdateChannelRequest body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                UpdateChannel op = new UpdateChannel(this,
                    body,
                    channelId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateChannelBuilder>(this);
                return op;
            }

            public Model.ModelsChannelResponse? Execute(
                ModelsUpdateChannelRequest body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                UpdateChannel op = Build(
                    body,
                    channelId,
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
            public async Task<Model.ModelsChannelResponse?> ExecuteAsync(
                ModelsUpdateChannelRequest body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                UpdateChannel op = Build(
                    body,
                    channelId,
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

        private UpdateChannel(UpdateChannelBuilder builder,
            ModelsUpdateChannelRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateChannel(
            string channelId,
            string namespace_,
            string userId,
            Model.ModelsUpdateChannelRequest body
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Put;

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