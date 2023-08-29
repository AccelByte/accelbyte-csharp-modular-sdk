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

using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// ListServer
    ///
    /// ```
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
    /// ```
    /// </summary>
    public class ListServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerBuilder Builder { get => new ListServerBuilder(); }

        public class ListServerBuilder
            : OperationBuilder<ListServerBuilder>
        {





            internal ListServerBuilder() { }

            internal ListServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ListServer Build(
            )
            {
                ListServer op = new ListServer(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsListServerResponse? Execute(
            )
            {
                ListServer op = Build(
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

        private ListServer(ListServerBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListServer(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/public/qos";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsListServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}