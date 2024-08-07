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
    /// GetSingleMatchmakingChannel
    ///
    /// Reads single channel based on namespace and channel name
    /// 
    /// Action Code: 510112
    /// </summary>
    public class GetSingleMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleMatchmakingChannelBuilder Builder { get => new GetSingleMatchmakingChannelBuilder(); }

        public class GetSingleMatchmakingChannelBuilder
            : OperationBuilder<GetSingleMatchmakingChannelBuilder>
        {





            internal GetSingleMatchmakingChannelBuilder() { }

            internal GetSingleMatchmakingChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSingleMatchmakingChannel Build(
                string channelName,
                string namespace_
            )
            {
                GetSingleMatchmakingChannel op = new GetSingleMatchmakingChannel(this,
                    channelName,
                    namespace_
                );

                op.SetBaseFields<GetSingleMatchmakingChannelBuilder>(this);
                return op;
            }

            public Model.ModelsChannelV1? Execute(
                string channelName,
                string namespace_
            )
            {
                GetSingleMatchmakingChannel op = Build(
                    channelName,
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
            public async Task<Model.ModelsChannelV1?> ExecuteAsync(
                string channelName,
                string namespace_
            )
            {
                GetSingleMatchmakingChannel op = Build(
                    channelName,
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

        private GetSingleMatchmakingChannel(GetSingleMatchmakingChannelBuilder builder,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSingleMatchmakingChannel(
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsChannelV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}