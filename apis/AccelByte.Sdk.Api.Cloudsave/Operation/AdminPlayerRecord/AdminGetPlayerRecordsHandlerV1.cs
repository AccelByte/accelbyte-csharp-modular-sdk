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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminGetPlayerRecordsHandlerV1
    ///
    /// Retrieve player record key and payload in bulk under given namespace.
    /// Maximum bulk key limit per request 20.
    /// </summary>
    public class AdminGetPlayerRecordsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerRecordsHandlerV1Builder Builder { get => new AdminGetPlayerRecordsHandlerV1Builder(); }

        public class AdminGetPlayerRecordsHandlerV1Builder
            : OperationBuilder<AdminGetPlayerRecordsHandlerV1Builder>
        {





            internal AdminGetPlayerRecordsHandlerV1Builder() { }

            internal AdminGetPlayerRecordsHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetPlayerRecordsHandlerV1 Build(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerRecordsHandlerV1 op = new AdminGetPlayerRecordsHandlerV1(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminGetPlayerRecordsHandlerV1Builder>(this);
                return op;
            }

            public AdminGetPlayerRecordsHandlerV1.Response Execute(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerRecordsHandlerV1 op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGetPlayerRecordsHandlerV1.Response> ExecuteAsync(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerRecordsHandlerV1 op = Build(
                    body,
                    namespace_,
                    userId
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

        private AdminGetPlayerRecordsHandlerV1(AdminGetPlayerRecordsHandlerV1Builder builder,
            ModelsBulkGetPlayerRecordsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsBulkGetAdminPlayerRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error404 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminPlayerRecord::AdminGetPlayerRecordsHandlerV1";
        }

        #endregion

        public AdminGetPlayerRecordsHandlerV1(
            string namespace_,            
            string userId,            
            Model.ModelsBulkGetPlayerRecordsRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetPlayerRecordsHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetPlayerRecordsHandlerV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}