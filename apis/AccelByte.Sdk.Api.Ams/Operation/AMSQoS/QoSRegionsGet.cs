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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// QoSRegionsGet
    ///
    /// ```
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:QOS:SERVER [READ]
    /// 
    /// This endpoint lists all QoS services available in all regions.
    /// 
    /// This endpoint is intended to be called by game client to find out all available regions.
    /// After getting a list of QoS on each region, game client is expected to ping each one with UDP
    /// connection as described below:
    /// 
    /// 1. Make UDP connection to each QoS's IP:Port
    /// 2. Send string "PING" after connection established
    /// 3. Wait for string "PONG" response
    /// 4. Note the request-response latency for each QoS in each region
    /// 
    /// The game then can use ping latency information to either:
    /// 1. Inform the player on these latencies and let player choose preferred region
    /// 2. Send the latency list to Matchmaking Service so that player can be matched with other players
    /// in nearby regions
    /// </summary>
    public class QoSRegionsGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QoSRegionsGetBuilder Builder { get => new QoSRegionsGetBuilder(); }

        public class QoSRegionsGetBuilder
            : OperationBuilder<QoSRegionsGetBuilder>
        {

            public string? Status { get; set; }





            internal QoSRegionsGetBuilder() { }

            internal QoSRegionsGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QoSRegionsGetBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public QoSRegionsGet Build(
                string namespace_
            )
            {
                QoSRegionsGet op = new QoSRegionsGet(this,
                    namespace_
                );

                op.SetBaseFields<QoSRegionsGetBuilder>(this);
                return op;
            }

            public Model.ApiQoSEndpointResponse? Execute(
                string namespace_
            )
            {
                QoSRegionsGet op = Build(
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
            public async Task<Model.ApiQoSEndpointResponse?> ExecuteAsync(
                string namespace_
            )
            {
                QoSRegionsGet op = Build(
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

        private QoSRegionsGet(QoSRegionsGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QoSRegionsGet(
            string namespace_,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/qos";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApiQoSEndpointResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiQoSEndpointResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiQoSEndpointResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}