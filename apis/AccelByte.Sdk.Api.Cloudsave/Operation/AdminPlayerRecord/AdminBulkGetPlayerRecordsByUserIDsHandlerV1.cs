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
    /// adminBulkGetPlayerRecordsByUserIDsHandlerV1
    ///
    /// Retrieve player record key and payload in bulk under given namespace.
    /// Maximum number of user ids per request is 20.
    /// </summary>
    public class AdminBulkGetPlayerRecordsByUserIDsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder Builder { get => new AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder(); }

        public class AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder
            : OperationBuilder<AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder>
        {





            internal AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder() { }

            internal AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkGetPlayerRecordsByUserIDsHandlerV1 Build(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                AdminBulkGetPlayerRecordsByUserIDsHandlerV1 op = new AdminBulkGetPlayerRecordsByUserIDsHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder>(this);
                return op;
            }

            public AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response Execute(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                AdminBulkGetPlayerRecordsByUserIDsHandlerV1 op = Build(
                    body,
                    key,
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
            public async Task<AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response> ExecuteAsync(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                AdminBulkGetPlayerRecordsByUserIDsHandlerV1 op = Build(
                    body,
                    key,
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

        private AdminBulkGetPlayerRecordsByUserIDsHandlerV1(AdminBulkGetPlayerRecordsByUserIDsHandlerV1Builder builder,
            ModelsBulkUserIDsRequest body,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsBulkGetPlayerRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminPlayerRecord::AdminBulkGetPlayerRecordsByUserIDsHandlerV1";
        }

        #endregion

        public AdminBulkGetPlayerRecordsByUserIDsHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsBulkUserIDsRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/records/{key}/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminBulkGetPlayerRecordsByUserIDsHandlerV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}