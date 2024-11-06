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
    /// adminPutAdminGameRecordConcurrentHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new game record or replace the existing game record.
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
    /// 3. Cannot use empty string in key names
    /// - `{ "": "value" }`
    /// 
    /// 
    /// ## Reserved Word
    /// 
    /// Reserved Word List: **__META**
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// ## Parameters Notes
    /// 1. updatedAt (required: true)
    /// Time format style: RFC3339
    /// 2. value
    /// Json
    /// 3. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the admin record.
    /// **Request Body Example:**
    /// ```
    /// {
    /// "value": {},
    /// "updatedAt": "2022-03-17T10:42:15.444Z",
    /// "tags": ["tag1", "tag2"]
    /// }
    /// ```
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutAdminGameRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutAdminGameRecordConcurrentHandlerV1Builder Builder { get => new AdminPutAdminGameRecordConcurrentHandlerV1Builder(); }

        public class AdminPutAdminGameRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutAdminGameRecordConcurrentHandlerV1Builder>
        {





            internal AdminPutAdminGameRecordConcurrentHandlerV1Builder() { }

            internal AdminPutAdminGameRecordConcurrentHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutAdminGameRecordConcurrentHandlerV1 Build(
                ModelsAdminGameConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordConcurrentHandlerV1 op = new AdminPutAdminGameRecordConcurrentHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminPutAdminGameRecordConcurrentHandlerV1Builder>(this);
                return op;
            }

            public AdminPutAdminGameRecordConcurrentHandlerV1.Response Execute(
                ModelsAdminGameConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordConcurrentHandlerV1 op = Build(
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
            public async Task<AdminPutAdminGameRecordConcurrentHandlerV1.Response> ExecuteAsync(
                ModelsAdminGameConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutAdminGameRecordConcurrentHandlerV1 op = Build(
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

        private AdminPutAdminGameRecordConcurrentHandlerV1(AdminPutAdminGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminGameConcurrentRecordRequest body,
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
        public class Response : ApiResponse
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error412 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminConcurrentRecord::AdminPutAdminGameRecordConcurrentHandlerV1";
        }

        #endregion

        public AdminPutAdminGameRecordConcurrentHandlerV1(
            string key,            
            string namespace_,            
            Model.ModelsAdminGameConcurrentRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/concurrent/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminPutAdminGameRecordConcurrentHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutAdminGameRecordConcurrentHandlerV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
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
            else if (code == (HttpStatusCode)412)
            
            {
                response.Error412 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error412!.TranslateToApiError();
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