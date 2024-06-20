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
    /// FleetGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [READ]
    /// </summary>
    public class FleetGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetGetBuilder Builder { get => new FleetGetBuilder(); }

        public class FleetGetBuilder
            : OperationBuilder<FleetGetBuilder>
        {





            internal FleetGetBuilder() { }

            internal FleetGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetGet Build(
                string fleetID,
                string namespace_
            )
            {
                FleetGet op = new FleetGet(this,
                    fleetID,                    
                    namespace_                    
                );

                op.SetBaseFields<FleetGetBuilder>(this);
                return op;
            }

            public Model.ApiFleetGetResponse? Execute(
                string fleetID,
                string namespace_
            )
            {
                FleetGet op = Build(
                    fleetID,
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
            public async Task<Model.ApiFleetGetResponse?> ExecuteAsync(
                string fleetID,
                string namespace_
            )
            {
                FleetGet op = Build(
                    fleetID,
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

        private FleetGet(FleetGetBuilder builder,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FleetGet(
            string fleetID,            
            string namespace_            
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiFleetGetResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetGetResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiFleetGetResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}