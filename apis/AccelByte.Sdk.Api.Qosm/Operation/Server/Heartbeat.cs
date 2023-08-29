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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsHeartbeatRequest body
            )
            {
                Heartbeat op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
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