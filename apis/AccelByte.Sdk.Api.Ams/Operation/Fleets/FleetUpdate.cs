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
    /// FleetUpdate
    ///
    /// Optionally, sampling rules for the fleet can also be updated
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:FLEET [UPDATE]
    /// </summary>
    public class FleetUpdate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetUpdateBuilder Builder { get => new FleetUpdateBuilder(); }

        public class FleetUpdateBuilder
            : OperationBuilder<FleetUpdateBuilder>
        {





            internal FleetUpdateBuilder() { }

            internal FleetUpdateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetUpdate Build(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = new FleetUpdate(this,
                    body,                    
                    fleetID,                    
                    namespace_                    
                );

                op.SetBaseFields<FleetUpdateBuilder>(this);
                return op;
            }

            public FleetUpdate.Response Execute(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = Build(
                    body,
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
            public async Task<FleetUpdate.Response> ExecuteAsync(
                ApiFleetParameters body,
                string fleetID,
                string namespace_
            )
            {
                FleetUpdate op = Build(
                    body,
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

        private FleetUpdate(FleetUpdateBuilder builder,
            ApiFleetParameters body,
            string fleetID,
            string namespace_
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ams::Fleets::FleetUpdate";
        }

        #endregion

        public FleetUpdate(
            string fleetID,            
            string namespace_,            
            Model.ApiFleetParameters body            
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public FleetUpdate.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new FleetUpdate.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}