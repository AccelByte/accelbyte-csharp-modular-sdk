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
    /// CreateDeploymentV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:DEPLOYMENT [CREATE]`
    /// 
    /// Creates Deployment for extend service
    /// 
    /// This endpoint intended to apply the helm release or deploying the custom service image.
    /// Logic in this endpoint:
    /// - Getting the repo from AppHistory table and image tag from request
    /// - Getting the Helm Manifest template from S3
    /// - Filling the Helm Manifest values
    /// - Installing the Helm Manifest to deploy the custom service image into K8s based on given namespace
    /// - Storing the filled Helm Manifest to S3
    /// - Storing the Deployment information to Database
    /// 
    /// Required: Valid Access Token
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class CreateDeploymentV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateDeploymentV1Builder Builder { get => new CreateDeploymentV1Builder(); }

        public class CreateDeploymentV1Builder
            : OperationBuilder<CreateDeploymentV1Builder>
        {





            internal CreateDeploymentV1Builder() { }

            internal CreateDeploymentV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateDeploymentV1 Build(
                GeneratedCreateDeploymentV1Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV1 op = new CreateDeploymentV1(this,
                    body,                    
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateDeploymentV1Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public CreateDeploymentV1.Response Execute(
                GeneratedCreateDeploymentV1Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV1 op = Build(
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
            public async Task<CreateDeploymentV1.Response> ExecuteAsync(
                GeneratedCreateDeploymentV1Request body,
                string app,
                string namespace_
            )
            {
                CreateDeploymentV1 op = Build(
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

        private CreateDeploymentV1(CreateDeploymentV1Builder builder,
            GeneratedCreateDeploymentV1Request body,
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
        public class Response : ApiResponse<Model.GeneratedCreateDeploymentV1Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::Deployment::CreateDeploymentV1";
        }

        #endregion

        public CreateDeploymentV1(
            string app,            
            string namespace_,            
            Model.GeneratedCreateDeploymentV1Request body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/deployments";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateDeploymentV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateDeploymentV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.GeneratedCreateDeploymentV1Response>(payload, ResponseJsonOptions);
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