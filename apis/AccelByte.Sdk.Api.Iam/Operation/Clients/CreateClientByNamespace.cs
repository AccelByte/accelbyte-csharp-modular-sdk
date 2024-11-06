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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// CreateClientByNamespace
    ///
    /// ## The endpoint is going to be deprecated
    /// **Endpoint migration guide**
    /// - **Substitute endpoint: _/v3/admin/namespaces/{namespace}/clients [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class CreateClientByNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateClientByNamespaceBuilder Builder { get => new CreateClientByNamespaceBuilder(); }

        public class CreateClientByNamespaceBuilder
            : OperationBuilder<CreateClientByNamespaceBuilder>
        {





            internal CreateClientByNamespaceBuilder() { }

            internal CreateClientByNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateClientByNamespace Build(
                ClientmodelClientCreateRequest body,
                string namespace_
            )
            {
                CreateClientByNamespace op = new CreateClientByNamespace(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateClientByNamespaceBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public CreateClientByNamespace.Response Execute(
                ClientmodelClientCreateRequest body,
                string namespace_
            )
            {
                CreateClientByNamespace op = Build(
                    body,
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
            public async Task<CreateClientByNamespace.Response> ExecuteAsync(
                ClientmodelClientCreateRequest body,
                string namespace_
            )
            {
                CreateClientByNamespace op = Build(
                    body,
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

        private CreateClientByNamespace(CreateClientByNamespaceBuilder builder,
            ClientmodelClientCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ClientmodelClientCreationResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public string Error409 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Clients::CreateClientByNamespace";
        }

        #endregion

        public CreateClientByNamespace(
            string namespace_,            
            Model.ClientmodelClientCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateClientByNamespace.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateClientByNamespace.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ClientmodelClientCreationResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error409!);
            }

            return response;
        }
    }

}