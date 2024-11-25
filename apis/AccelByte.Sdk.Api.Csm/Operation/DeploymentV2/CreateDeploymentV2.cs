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

using AccelByte.Sdk.Api.Csm.Model;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// CreateDeploymentV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:DEPLOYMENT [CREATE]`
    /// 
    /// Creates Deployment for extend service
    /// 
    /// This Endpoint will create new deployment and apply all of the secrets and variable as environment variable
    /// 
    /// Required:
    /// - Valid Access Token
    /// - Valid Image Version Created on Uploading image with docker or other method
    /// - Valid App name
    /// - Valid Namespace name
    /// </summary>
    public class CreateDeploymentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentV2Builder Builder { get => new CreateDeploymentV2Builder(); }

        public class CreateDeploymentV2Builder
            : OperationBuilder<CreateDeploymentV2Builder>
        {





            internal CreateDeploymentV2Builder() { }

            internal CreateDeploymentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateDeploymentV2 Build(
                ApimodelCreateDeploymentV2Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV2 op = new CreateDeploymentV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateDeploymentV2Builder>(this);
                return op;
            }

            public CreateDeploymentV2.Response Execute(
                ApimodelCreateDeploymentV2Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV2 op = Build(
                    body,
                    app,
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
            public async Task<CreateDeploymentV2.Response> ExecuteAsync(
                ApimodelCreateDeploymentV2Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV2 op = Build(
                    body,
                    app,
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

        private CreateDeploymentV2(CreateDeploymentV2Builder builder,
            ApimodelCreateDeploymentV2Request body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelCreateDeploymentV2Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::DeploymentV2::CreateDeploymentV2";
        }

        #endregion

        public CreateDeploymentV2(
            string app,            
            string namespace_,            
            Model.ApimodelCreateDeploymentV2Request body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/deployments";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateDeploymentV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateDeploymentV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelCreateDeploymentV2Response>(payload, ResponseJsonOptions);
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