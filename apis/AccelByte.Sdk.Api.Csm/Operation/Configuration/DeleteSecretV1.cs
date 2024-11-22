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
    /// DeleteSecretV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:SECRET [DELETE]`
    /// 
    /// Delete an environment secret.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteSecretV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSecretV1Builder Builder { get => new DeleteSecretV1Builder(); }

        public class DeleteSecretV1Builder
            : OperationBuilder<DeleteSecretV1Builder>
        {





            internal DeleteSecretV1Builder() { }

            internal DeleteSecretV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSecretV1 Build(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteSecretV1 op = new DeleteSecretV1(this,
                    app,                    
                    configId,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteSecretV1Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public DeleteSecretV1.Response Execute(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteSecretV1 op = Build(
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
            public async Task<DeleteSecretV1.Response> ExecuteAsync(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteSecretV1 op = Build(
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

        private DeleteSecretV1(DeleteSecretV1Builder builder,
            string app,
            string configId,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error404 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Csm::Configuration::DeleteSecretV1";
        }

        #endregion

        public DeleteSecretV1(
            string app,            
            string configId,            
            string namespace_            
        )
        {
            PathParams["app"] = app;
            PathParams["configId"] = configId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteSecretV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteSecretV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
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