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
    /// adminPutPlayerPublicRecordConcurrentHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new player public record or replace the existing player public record.
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
    /// ## Reserved Word
    /// 
    /// Reserved Word List: **__META**
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// ## Parameters Notes
    /// 1. set_by (default: CLIENT, type: string)
    /// Indicate which party that could modify the game record.
    /// SERVER: record can be modified by server only.
    /// CLIENT: record can be modified by client and server.
    /// 2. updatedAt (required: true)
    /// Time format style: RFC3339
    /// 3. value
    /// Json
    /// 4. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the game record.
    /// **Request Body Example:**
    /// ```
    /// {
    /// "set_by": "SERVER",
    /// "value": {},
    /// "updatedAt": "2022-03-17T10:42:15.444Z",
    /// "tags": ["tag1", "tag2"]
    /// }
    /// ```
    /// 
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutPlayerPublicRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerPublicRecordConcurrentHandlerV1Builder Builder { get => new AdminPutPlayerPublicRecordConcurrentHandlerV1Builder(); }

        public class AdminPutPlayerPublicRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutPlayerPublicRecordConcurrentHandlerV1Builder>
        {

            public bool? ResponseBody { get; set; }





            internal AdminPutPlayerPublicRecordConcurrentHandlerV1Builder() { }

            internal AdminPutPlayerPublicRecordConcurrentHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminPutPlayerPublicRecordConcurrentHandlerV1Builder SetResponseBody(bool _responseBody)
            {
                ResponseBody = _responseBody;
                return this;
            }





            public AdminPutPlayerPublicRecordConcurrentHandlerV1 Build(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordConcurrentHandlerV1 op = new AdminPutPlayerPublicRecordConcurrentHandlerV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<AdminPutPlayerPublicRecordConcurrentHandlerV1Builder>(this);
                return op;
            }

            public AdminPutPlayerPublicRecordConcurrentHandlerV1.Response Execute(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordConcurrentHandlerV1 op = Build(
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
            public async Task<AdminPutPlayerPublicRecordConcurrentHandlerV1.Response> ExecuteAsync(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordConcurrentHandlerV1 op = Build(
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
        }

        private AdminPutPlayerPublicRecordConcurrentHandlerV1(AdminPutPlayerPublicRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ResponseBody != null) QueryParams["responseBody"] = Convert.ToString(builder.ResponseBody)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPlayerRecordConcurrentUpdateResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error412 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminConcurrentRecord::AdminPutPlayerPublicRecordConcurrentHandlerV1";
        }

        #endregion

        public AdminPutPlayerPublicRecordConcurrentHandlerV1(
            string key,            
            string namespace_,            
            string userId,            
            bool? responseBody,            
            Model.ModelsAdminConcurrentRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (responseBody != null) QueryParams["responseBody"] = Convert.ToString(responseBody)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminPutPlayerPublicRecordConcurrentHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutPlayerPublicRecordConcurrentHandlerV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload, ResponseJsonOptions);
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