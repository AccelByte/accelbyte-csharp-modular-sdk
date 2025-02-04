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
    /// adminPutGameRecordConcurrentHandlerV1
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
    /// ## Reserved Word
    /// 
    /// Reserved Word List: **__META**
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// ## Recommended Request Body Size
    /// 
    /// To ensure optimal performance and efficient resource utilization, it is recommended that the request body size for this endpoint does not exceed 250 KB.
    /// 
    /// ## Exceeding the recommended limit
    /// 
    /// While it's possible to handle larger request, exceeding this limit may lead to increased processing time, potential performance degradation, and potential timeout issues.
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
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutGameRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutGameRecordConcurrentHandlerV1Builder Builder { get => new AdminPutGameRecordConcurrentHandlerV1Builder(); }

        public class AdminPutGameRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutGameRecordConcurrentHandlerV1Builder>
        {





            internal AdminPutGameRecordConcurrentHandlerV1Builder() { }

            internal AdminPutGameRecordConcurrentHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutGameRecordConcurrentHandlerV1 Build(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutGameRecordConcurrentHandlerV1 op = new AdminPutGameRecordConcurrentHandlerV1(this,
                    body,
                    key,
                    namespace_
                );

                op.SetBaseFields<AdminPutGameRecordConcurrentHandlerV1Builder>(this);
                return op;
            }

            public AdminPutGameRecordConcurrentHandlerV1.Response Execute(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutGameRecordConcurrentHandlerV1 op = Build(
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
            public async Task<AdminPutGameRecordConcurrentHandlerV1.Response> ExecuteAsync(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_
            )
            {
                AdminPutGameRecordConcurrentHandlerV1 op = Build(
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

        private AdminPutGameRecordConcurrentHandlerV1(AdminPutGameRecordConcurrentHandlerV1Builder builder,
            ModelsAdminConcurrentRecordRequest body,
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


            protected override string GetFullOperationId() => "Cloudsave::AdminConcurrentRecord::AdminPutGameRecordConcurrentHandlerV1";
        }

        #endregion

        public AdminPutGameRecordConcurrentHandlerV1(
            string key,
            string namespace_,
            Model.ModelsAdminConcurrentRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/concurrent/records/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminPutGameRecordConcurrentHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPutGameRecordConcurrentHandlerV1.Response()
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