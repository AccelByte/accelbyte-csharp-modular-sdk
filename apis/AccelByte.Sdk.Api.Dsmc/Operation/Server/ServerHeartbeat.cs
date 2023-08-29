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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ServerHeartbeat
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server
    /// which already has claimed to extend its lifetime.
    /// DS should call this periodically after it claimed.
    /// The timeframe between 2 heartbeat call should be smaller than
    /// the session timout in the deployment configuration.
    /// If the last heartbeat is longer than the session timout, the server.
    /// will be considered as expired and will be terminated by DSMC.```
    /// </summary>
    public class ServerHeartbeat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ServerHeartbeatBuilder Builder { get => new ServerHeartbeatBuilder(); }

        public class ServerHeartbeatBuilder
            : OperationBuilder<ServerHeartbeatBuilder>
        {





            internal ServerHeartbeatBuilder() { }

            internal ServerHeartbeatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ServerHeartbeat Build(
                ModelsDSHeartbeatRequest body,
                string namespace_
            )
            {
                ServerHeartbeat op = new ServerHeartbeat(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsDSHeartbeatRequest body,
                string namespace_
            )
            {
                ServerHeartbeat op = Build(
                    body,
                    namespace_
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

        private ServerHeartbeat(ServerHeartbeatBuilder builder,
            ModelsDSHeartbeatRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ServerHeartbeat(
            string namespace_,            
            Model.ModelsDSHeartbeatRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/heartbeat";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)202)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}