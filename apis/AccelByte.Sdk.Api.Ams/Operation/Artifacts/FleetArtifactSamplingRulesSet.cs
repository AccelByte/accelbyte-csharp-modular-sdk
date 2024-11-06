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
    /// FleetArtifactSamplingRulesSet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:ARTIFACT [UPDATE]
    /// </summary>
    public class FleetArtifactSamplingRulesSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FleetArtifactSamplingRulesSetBuilder Builder { get => new FleetArtifactSamplingRulesSetBuilder(); }

        public class FleetArtifactSamplingRulesSetBuilder
            : OperationBuilder<FleetArtifactSamplingRulesSetBuilder>
        {





            internal FleetArtifactSamplingRulesSetBuilder() { }

            internal FleetArtifactSamplingRulesSetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FleetArtifactSamplingRulesSet Build(
                ApiFleetArtifactsSampleRules body,
                string fleetID,
                string namespace_
            )
            {
                FleetArtifactSamplingRulesSet op = new FleetArtifactSamplingRulesSet(this,
                    body,                    
                    fleetID,                    
                    namespace_                    
                );

                op.SetBaseFields<FleetArtifactSamplingRulesSetBuilder>(this);
                return op;
            }

            public FleetArtifactSamplingRulesSet.Response Execute(
                ApiFleetArtifactsSampleRules body,
                string fleetID,
                string namespace_
            )
            {
                FleetArtifactSamplingRulesSet op = Build(
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
            public async Task<FleetArtifactSamplingRulesSet.Response> ExecuteAsync(
                ApiFleetArtifactsSampleRules body,
                string fleetID,
                string namespace_
            )
            {
                FleetArtifactSamplingRulesSet op = Build(
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

        private FleetArtifactSamplingRulesSet(FleetArtifactSamplingRulesSetBuilder builder,
            ApiFleetArtifactsSampleRules body,
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
        public class Response : ApiResponse<Model.ApiFleetArtifactsSampleRules>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ams::Artifacts::FleetArtifactSamplingRulesSet";
        }

        #endregion

        public FleetArtifactSamplingRulesSet(
            string fleetID,            
            string namespace_,            
            Model.ApiFleetArtifactsSampleRules body            
        )
        {
            PathParams["fleetID"] = fleetID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/artifacts-sampling-rules";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public FleetArtifactSamplingRulesSet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new FleetArtifactSamplingRulesSet.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApiFleetArtifactsSampleRules>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
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