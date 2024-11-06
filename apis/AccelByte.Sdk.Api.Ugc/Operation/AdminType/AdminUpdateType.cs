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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminUpdateType
    ///
    /// Updates a type and subtype
    /// </summary>
    public class AdminUpdateType : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateTypeBuilder Builder { get => new AdminUpdateTypeBuilder(); }

        public class AdminUpdateTypeBuilder
            : OperationBuilder<AdminUpdateTypeBuilder>
        {





            internal AdminUpdateTypeBuilder() { }

            internal AdminUpdateTypeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateType Build(
                ModelsCreateTypeRequest body,
                string namespace_,
                string typeId
            )
            {
                AdminUpdateType op = new AdminUpdateType(this,
                    body,                    
                    namespace_,                    
                    typeId                    
                );

                op.SetBaseFields<AdminUpdateTypeBuilder>(this);
                return op;
            }

            public AdminUpdateType.Response Execute(
                ModelsCreateTypeRequest body,
                string namespace_,
                string typeId
            )
            {
                AdminUpdateType op = Build(
                    body,
                    namespace_,
                    typeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminUpdateType.Response> ExecuteAsync(
                ModelsCreateTypeRequest body,
                string namespace_,
                string typeId
            )
            {
                AdminUpdateType op = Build(
                    body,
                    namespace_,
                    typeId
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

        private AdminUpdateType(AdminUpdateTypeBuilder builder,
            ModelsCreateTypeRequest body,
            string namespace_,
            string typeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsCreateTypeResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminType::AdminUpdateType";
        }

        #endregion

        public AdminUpdateType(
            string namespace_,            
            string typeId,            
            Model.ModelsCreateTypeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["typeId"] = typeId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/types/{typeId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateType.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateType.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsCreateTypeResponse>(payload, ResponseJsonOptions);
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