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
    /// UpdateSecretV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [UPDATE]`
    /// 
    /// Update an environment secret.
    /// Request body:
    /// - value : configuration value - Required.
    /// - description : description of the configuration - Optional.
    /// - applyMask : mask the value in the Helm manifest for sensitive information (true or false) - Optional.
    /// </summary>
    public class UpdateSecretV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSecretV2Builder Builder { get => new UpdateSecretV2Builder(); }

        public class UpdateSecretV2Builder
            : OperationBuilder<UpdateSecretV2Builder>
        {





            internal UpdateSecretV2Builder() { }

            internal UpdateSecretV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateSecretV2 Build(
                ApimodelUpdateConfigurationV2Request body,
                string app,
                string configId,
                string namespace_
            )
            {
                UpdateSecretV2 op = new UpdateSecretV2(this,
                    body,                    
                    app,                    
                    configId,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateSecretV2Builder>(this);
                return op;
            }

            public UpdateSecretV2.Response Execute(
                ApimodelUpdateConfigurationV2Request body,
                string app,
                string configId,
                string namespace_
            )
            {
                UpdateSecretV2 op = Build(
                    body,
                    app,
                    configId,
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
            public async Task<UpdateSecretV2.Response> ExecuteAsync(
                ApimodelUpdateConfigurationV2Request body,
                string app,
                string configId,
                string namespace_
            )
            {
                UpdateSecretV2 op = Build(
                    body,
                    app,
                    configId,
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

        private UpdateSecretV2(UpdateSecretV2Builder builder,
            ApimodelUpdateConfigurationV2Request body,
            string app,
            string configId,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelUpdateConfigurationV2Response>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::ConfigurationV2::UpdateSecretV2";
        }

        #endregion

        public UpdateSecretV2(
            string app,            
            string configId,            
            string namespace_,            
            Model.ApimodelUpdateConfigurationV2Request body            
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateSecretV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateSecretV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelUpdateConfigurationV2Response>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}