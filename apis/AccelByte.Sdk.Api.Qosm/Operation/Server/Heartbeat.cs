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

using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// Heartbeat
    ///
    /// ```
    /// Required permission: QOS:SERVER [CREATE][UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by QoS service
    /// to register and periodically let QoS Manager know that it is still alive.
    /// ```
    /// </summary>
    public class Heartbeat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static HeartbeatBuilder Builder { get => new HeartbeatBuilder(); }

        public class HeartbeatBuilder
            : OperationBuilder<HeartbeatBuilder>
        {





            internal HeartbeatBuilder() { }

            internal HeartbeatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Heartbeat Build(
                ModelsHeartbeatRequest body
            )
            {
                Heartbeat op = new Heartbeat(this,
                    body                    
                );

                op.SetBaseFields<HeartbeatBuilder>(this);
                return op;
            }

            public Heartbeat.Response Execute(
                ModelsHeartbeatRequest body
            )
            {
                Heartbeat op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Heartbeat.Response> ExecuteAsync(
                ModelsHeartbeatRequest body
            )
            {
                Heartbeat op = Build(
                    body
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

        private Heartbeat(HeartbeatBuilder builder,
            ModelsHeartbeatRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Qosm::Server::Heartbeat";
        }

        #endregion

        public Heartbeat(
            Model.ModelsHeartbeatRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/servers/heartbeat";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public Heartbeat.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Heartbeat.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}