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
    /// DeleteVariableV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:VARIABLE [DELETE]`
    /// 
    /// Delete an environment variable.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteVariableV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteVariableV1Builder Builder { get => new DeleteVariableV1Builder(); }

        public class DeleteVariableV1Builder
            : OperationBuilder<DeleteVariableV1Builder>
        {





            internal DeleteVariableV1Builder() { }

            internal DeleteVariableV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteVariableV1 Build(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteVariableV1 op = new DeleteVariableV1(this,
                    app,                    
                    configId,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteVariableV1Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public DeleteVariableV1.Response Execute(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteVariableV1 op = Build(
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
            public async Task<DeleteVariableV1.Response> ExecuteAsync(
                string app,
                string configId,
                string namespace_
            )
            {
                DeleteVariableV1 op = Build(
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

        private DeleteVariableV1(DeleteVariableV1Builder builder,
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


            protected override string GetFullOperationId() => "Csm::Configuration::DeleteVariableV1";
        }

        #endregion

        public DeleteVariableV1(
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

        public override string Path => "/csm/v1/admin/namespaces/{namespace}/apps/{app}/variables/{configId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteVariableV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteVariableV1.Response()
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