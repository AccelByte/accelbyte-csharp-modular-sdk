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
    /// FleetServerInfo
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class FleetServerInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetServerInfoBuilder Builder { get => new FleetServerInfoBuilder(); }

        public class FleetServerInfoBuilder
            : OperationBuilder<FleetServerInfoBuilder>
        {





            internal FleetServerInfoBuilder() { }

            internal FleetServerInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetServerInfo Build(
                string namespace_,
                string serverID
            )
            {
                FleetServerInfo op = new FleetServerInfo(this,
                    namespace_,                    
                    serverID                    
                );

                op.SetBaseFields<FleetServerInfoBuilder>(this);
                return op;
            }

            public Model.ApiFleetServerInfoResponse? Execute(
                string namespace_,
                string serverID
            )
            {
                FleetServerInfo op = Build(
                    namespace_,
                    serverID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApiFleetServerInfoResponse?> ExecuteAsync(
                string namespace_,
                string serverID
            )
            {
                FleetServerInfo op = Build(
                    namespace_,
                    serverID
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

        private FleetServerInfo(FleetServerInfoBuilder builder,
            string namespace_,
            string serverID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetServerInfo(
            string namespace_,            
            string serverID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["serverID"] = serverID;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/servers/{serverID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiFleetServerInfoResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServerInfoResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetServerInfoResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}