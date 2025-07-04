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
    /// CreateAppV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP [CREATE]`
    /// 
    /// Create new extend app with name provided by {app} path parameter and specified scenario type
    /// 
    /// Available scenario:
    /// - scenario 1: `function-override`
    /// - scenario 2: `service-extension`
    /// - scenario 3: `event-handler`
    /// 
    /// 
    /// Available app status:
    /// - `app-creating`
    /// - `app-creation-failed`
    /// - `app-creation-timeout`
    /// - `app-undeployed`
    /// - `deployment-in-progress`
    /// - `deployment-failed`
    /// - `deployment-timeout`
    /// - `deployment-running`
    /// - `deployment-down`
    /// - `app-stopping`
    /// - `app-stop-failed`
    /// - `app-stop-timeout`
    /// - `app-stopped`
    /// - `app-removing`
    /// - `app-removed`
    /// - `app-remove-timeout`
    /// </summary>
    public class CreateAppV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateAppV2Builder Builder { get => new CreateAppV2Builder(); }

        public class CreateAppV2Builder
            : OperationBuilder<CreateAppV2Builder>
        {





            internal CreateAppV2Builder() { }

            internal CreateAppV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateAppV2 Build(
                ApimodelCreateAppV2Request body,
                string app,
                string namespace_
            )
            {
                CreateAppV2 op = new CreateAppV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateAppV2Builder>(this);
                return op;
            }

            public CreateAppV2.Response Execute(
                ApimodelCreateAppV2Request body,
                string app,
                string namespace_
            )
            {
                CreateAppV2 op = Build(
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
            public async Task<CreateAppV2.Response> ExecuteAsync(
                ApimodelCreateAppV2Request body,
                string app,
                string namespace_
            )
            {
                CreateAppV2 op = Build(
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

        private CreateAppV2(CreateAppV2Builder builder,
            ApimodelCreateAppV2Request body,
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
        public class Response : ApiResponse<Model.ApimodelAppItem>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error409 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::AppV2::CreateAppV2";
        }

        #endregion

        public CreateAppV2(
            string app,            
            string namespace_,            
            Model.ApimodelCreateAppV2Request body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateAppV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateAppV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelAppItem>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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