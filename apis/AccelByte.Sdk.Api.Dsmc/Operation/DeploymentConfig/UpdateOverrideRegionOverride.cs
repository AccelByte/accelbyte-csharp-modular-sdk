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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// UpdateOverrideRegionOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint update a dedicated servers deployment override in a namespace in a region for deployment overrides.
    /// </summary>
    public class UpdateOverrideRegionOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateOverrideRegionOverrideBuilder Builder { get => new UpdateOverrideRegionOverrideBuilder(); }

        public class UpdateOverrideRegionOverrideBuilder
            : OperationBuilder<UpdateOverrideRegionOverrideBuilder>
        {





            internal UpdateOverrideRegionOverrideBuilder() { }

            internal UpdateOverrideRegionOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateOverrideRegionOverride Build(
                ModelsUpdateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                UpdateOverrideRegionOverride op = new UpdateOverrideRegionOverride(this,
                    body,                    
                    deployment,                    
                    namespace_,                    
                    region,                    
                    version                    
                );

                op.SetBaseFields<UpdateOverrideRegionOverrideBuilder>(this);
                return op;
            }

            public UpdateOverrideRegionOverride.Response Execute(
                ModelsUpdateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                UpdateOverrideRegionOverride op = Build(
                    body,
                    deployment,
                    namespace_,
                    region,
                    version
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateOverrideRegionOverride.Response> ExecuteAsync(
                ModelsUpdateRegionOverrideRequest body,
                string deployment,
                string namespace_,
                string region,
                string version
            )
            {
                UpdateOverrideRegionOverride op = Build(
                    body,
                    deployment,
                    namespace_,
                    region,
                    version
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

        private UpdateOverrideRegionOverride(UpdateOverrideRegionOverrideBuilder builder,
            ModelsUpdateRegionOverrideRequest body,
            string deployment,
            string namespace_,
            string region,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDeploymentWithOverride>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::DeploymentConfig::UpdateOverrideRegionOverride";
        }

        #endregion

        public UpdateOverrideRegionOverride(
            string deployment,            
            string namespace_,            
            string region,            
            string version,            
            Model.ModelsUpdateRegionOverrideRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["region"] = region;
            PathParams["version"] = version;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateOverrideRegionOverride.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateOverrideRegionOverride.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsDeploymentWithOverride>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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