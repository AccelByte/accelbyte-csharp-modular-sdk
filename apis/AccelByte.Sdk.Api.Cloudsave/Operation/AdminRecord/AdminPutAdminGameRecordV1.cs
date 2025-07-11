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
    /// adminPutAdminGameRecordV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new admin game record or replace the existing admin game record.
    /// 
    /// **Append example:**
    /// 
    /// Example
    /// - Existing JSON:
    /// 
    /// `{ "data1": "value" }`
    /// 
    /// - New JSON:
    /// 
    /// `{ "data2": "new value" }`
    /// 
    /// - Result:
    /// 
    /// `{ "data2": "new value" }`
    /// 
    /// 
    /// 
    /// ## Record Metadata
    /// 
    /// Metadata allows user to define the behaviour of the record.
    /// Metadata can be defined in request body with field name **__META**.
    /// When creating record, if **__META** field is not defined, the metadata value will use the default value.
    /// When updating record, if **__META** field is not defined, the existing metadata value will stay as is.
    /// 
    /// **Metadata List:**
    /// 1. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the admin record.
    /// 2. ttl_config (default: *empty*, type: object)
    /// Indicate the TTL configuration for the admin record.
    /// action:
    /// - DELETE: record will be deleted after TTL is reached
    /// 
    /// **Request Body Example:**
    /// ```
    /// {
    /// "__META": {
    /// "tags": ["tag1", "tag2"],
    /// "ttl_config": {
    /// "expires_at": "2026-01-02T15:04:05Z", // should be in RFC3339 format
    /// "action": "DELETE"
    /// },
    /// }
    /// ...
    /// }
    /// ```
    /// 
    /// ## Recommended Request Body Size
    /// 
    /// To ensure optimal performance and efficient resource utilization, it is recommended that the request body size for this endpoint does not exceed 250 KB.
    /// 
    /// ## Exceeding the recommended limit
    /// 
    /// While it's possible to handle larger request, exceeding this limit may lead to increased processing time, potential performance degradation, and potential timeout issues.
    /// </summary>
    public class AdminPutAdminGameRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutAdminGameRecordV1Builder Builder { get => new AdminPutAdminGameRecordV1Builder(); }

        public class AdminPutAdminGameRecordV1Builder
            : OperationBuilder<AdminPutAdminGameRecordV1Builder>
        {





            internal AdminPutAdminGameRecordV1Builder() { }

            internal AdminPutAdminGameRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutAdminGameRecordV1 Build(
                ModelsAdminGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordV1 op = new AdminPutAdminGameRecordV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminPutAdminGameRecordV1Builder>(this);
                return op;
            }

            public AdminPutAdminGameRecordV1.Response Execute(
                ModelsAdminGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordV1 op = Build(
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
            public async Task<AdminPutAdminGameRecordV1.Response> ExecuteAsync(
                ModelsAdminGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordV1 op = Build(
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

            public AdminPutAdminGameRecordV1.Response<T1> Execute<T1>(
                ModelsAdminGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordV1 op = Build(
                    body,
                    key,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminPutAdminGameRecordV1.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminGameRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordV1 op = Build(
                    body,
                    key,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminPutAdminGameRecordV1(AdminPutAdminGameRecordV1Builder builder,
            ModelsAdminGameRecordRequest body,
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
        public class Response : ApiResponse<Model.ModelsAdminGameRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPutAdminGameRecordV1";
        }

        public class Response<T1> : ApiResponse<Model.ModelsAdminGameRecordResponse<T1>>
        {
            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPutAdminGameRecordV1";
        }
        #endregion

        public AdminPutAdminGameRecordV1(
            string key,            
            string namespace_,            
            Model.ModelsAdminGameRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminPutAdminGameRecordV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutAdminGameRecordV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsAdminGameRecordResponse>(payload, ResponseJsonOptions);
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

        public AdminPutAdminGameRecordV1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutAdminGameRecordV1.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsAdminGameRecordResponse<T1>>(payload, ResponseJsonOptions);
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