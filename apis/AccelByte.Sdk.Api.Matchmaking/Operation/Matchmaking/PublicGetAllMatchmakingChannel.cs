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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// PublicGetAllMatchmakingChannel
    ///
    /// Reads all available channels in a namespace
    /// </summary>
    public class PublicGetAllMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetAllMatchmakingChannelBuilder Builder { get => new PublicGetAllMatchmakingChannelBuilder(); }

        public class PublicGetAllMatchmakingChannelBuilder
            : OperationBuilder<PublicGetAllMatchmakingChannelBuilder>
        {





            internal PublicGetAllMatchmakingChannelBuilder() { }

            internal PublicGetAllMatchmakingChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetAllMatchmakingChannel Build(
                string namespace_
            )
            {
                PublicGetAllMatchmakingChannel op = new PublicGetAllMatchmakingChannel(this,
                    namespace_
                );

                op.SetBaseFields<PublicGetAllMatchmakingChannelBuilder>(this);
                return op;
            }

            public List<Model.ModelsChannelV1>? Execute(
                string namespace_
            )
            {
                PublicGetAllMatchmakingChannel op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ModelsChannelV1>?> ExecuteAsync(
                string namespace_
            )
            {
                PublicGetAllMatchmakingChannel op = Build(
                    namespace_
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

        private PublicGetAllMatchmakingChannel(PublicGetAllMatchmakingChannelBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetAllMatchmakingChannel(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/public/namespaces/{namespace}/channels";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ModelsChannelV1>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsChannelV1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsChannelV1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}