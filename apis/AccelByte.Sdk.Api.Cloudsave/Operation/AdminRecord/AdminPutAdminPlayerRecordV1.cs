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
    /// adminPutAdminPlayerRecordV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new admin player record or replace the existing admin player record.
    /// 
    /// **Replace behaviour:**
    /// The existing value will be replaced completely with the new value.
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
    /// ## Restriction
    /// This is the restriction of Key Naming for the record:
    /// 1. Cannot use **"."** as the key name
    /// - `{ "data.2": "value" }`
    /// 2. Cannot use **"$"** as the prefix in key names
    /// - `{ "$data": "value" }`
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
    /// </summary>
    public class AdminPutAdminPlayerRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutAdminPlayerRecordV1Builder Builder { get => new AdminPutAdminPlayerRecordV1Builder(); }

        public class AdminPutAdminPlayerRecordV1Builder
            : OperationBuilder<AdminPutAdminPlayerRecordV1Builder>
        {





            internal AdminPutAdminPlayerRecordV1Builder() { }

            internal AdminPutAdminPlayerRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutAdminPlayerRecordV1 Build(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordV1 op = new AdminPutAdminPlayerRecordV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminPutAdminPlayerRecordV1Builder>(this);
                return op;
            }

            public AdminPutAdminPlayerRecordV1.Response Execute(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordV1 op = Build(
                    body,
                    key,
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
            public async Task<AdminPutAdminPlayerRecordV1.Response> ExecuteAsync(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordV1 op = Build(
                    body,
                    key,
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

            public AdminPutAdminPlayerRecordV1.Response<T1> Execute<T1>(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordV1 op = Build(
                    body,
                    key,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminPutAdminPlayerRecordV1.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordV1 op = Build(
                    body,
                    key,
                    namespace_,
                    userId
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

        private AdminPutAdminPlayerRecordV1(AdminPutAdminPlayerRecordV1Builder builder,
            ModelsAdminPlayerRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsAdminPlayerRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPutAdminPlayerRecordV1";
        }

        public class Response<T1> : ApiResponse<Model.ModelsAdminPlayerRecordResponse<T1>>
        {
            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPutAdminPlayerRecordV1";
        }
        #endregion

        public AdminPutAdminPlayerRecordV1(
            string key,            
            string namespace_,            
            string userId,            
            Model.ModelsAdminPlayerRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminPutAdminPlayerRecordV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutAdminPlayerRecordV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
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

        public AdminPutAdminPlayerRecordV1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutAdminPlayerRecordV1.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsAdminPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
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