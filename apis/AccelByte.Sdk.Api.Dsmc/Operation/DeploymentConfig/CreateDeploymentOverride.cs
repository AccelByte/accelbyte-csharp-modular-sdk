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
    /// CreateDeploymentOverride
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint create a dedicated servers deployment override in a namespace.
    /// </summary>
    public class CreateDeploymentOverride : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentOverrideBuilder Builder { get => new CreateDeploymentOverrideBuilder(); }

        public class CreateDeploymentOverrideBuilder
            : OperationBuilder<CreateDeploymentOverrideBuilder>
        {





            internal CreateDeploymentOverrideBuilder() { }

            internal CreateDeploymentOverrideBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateDeploymentOverride Build(
                ModelsCreateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                CreateDeploymentOverride op = new CreateDeploymentOverride(this,
                    body,                    
                    deployment,                    
                    namespace_,                    
                    version                    
                );

                op.SetBaseFields<CreateDeploymentOverrideBuilder>(this);
                return op;
            }

            public CreateDeploymentOverride.Response Execute(
                ModelsCreateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                CreateDeploymentOverride op = Build(
                    body,
                    deployment,
                    namespace_,
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
            public async Task<CreateDeploymentOverride.Response> ExecuteAsync(
                ModelsCreateDeploymentOverrideRequest body,
                string deployment,
                string namespace_,
                string version
            )
            {
                CreateDeploymentOverride op = Build(
                    body,
                    deployment,
                    namespace_,
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

        private CreateDeploymentOverride(CreateDeploymentOverrideBuilder builder,
            ModelsCreateDeploymentOverrideRequest body,
            string deployment,
            string namespace_,
            string version
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
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

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsmc::DeploymentConfig::CreateDeploymentOverride";
        }

        #endregion

        public CreateDeploymentOverride(
            string deployment,            
            string namespace_,            
            string version,            
            Model.ModelsCreateDeploymentOverrideRequest body            
        )
        {
            PathParams["deployment"] = deployment;
            PathParams["namespace"] = namespace_;
            PathParams["version"] = version;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateDeploymentOverride.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateDeploymentOverride.Response()
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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