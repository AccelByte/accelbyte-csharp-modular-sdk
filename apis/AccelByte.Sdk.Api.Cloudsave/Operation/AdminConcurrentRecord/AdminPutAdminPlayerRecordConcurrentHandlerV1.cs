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
    /// adminPutAdminPlayerRecordConcurrentHandlerV1
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
    /// 
    /// ## Optimistic Concurrency Control
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutAdminPlayerRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutAdminPlayerRecordConcurrentHandlerV1Builder Builder { get => new AdminPutAdminPlayerRecordConcurrentHandlerV1Builder(); }

        public class AdminPutAdminPlayerRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutAdminPlayerRecordConcurrentHandlerV1Builder>
        {

            public bool? ResponseBody { get; set; }





            internal AdminPutAdminPlayerRecordConcurrentHandlerV1Builder() { }

            internal AdminPutAdminPlayerRecordConcurrentHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminPutAdminPlayerRecordConcurrentHandlerV1Builder SetResponseBody(bool _responseBody)
            {
                ResponseBody = _responseBody;
                return this;
            }





            public AdminPutAdminPlayerRecordConcurrentHandlerV1 Build(
                ModelsAdminPlayerConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordConcurrentHandlerV1 op = new AdminPutAdminPlayerRecordConcurrentHandlerV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminPutAdminPlayerRecordConcurrentHandlerV1Builder>(this);
                return op;
            }

            public Model.ModelsPlayerRecordConcurrentUpdateResponse? Execute(
                ModelsAdminPlayerConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordConcurrentHandlerV1 op = Build(
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
            public async Task<Model.ModelsPlayerRecordConcurrentUpdateResponse?> ExecuteAsync(
                ModelsAdminPlayerConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutAdminPlayerRecordConcurrentHandlerV1 op = Build(
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

        private AdminPutAdminPlayerRecordConcurrentHandlerV1(AdminPutAdminPlayerRecordConcurrentHandlerV1Builder builder,
            ModelsAdminPlayerConcurrentRecordRequest body,
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

        public AdminPutAdminPlayerRecordConcurrentHandlerV1(
            string key,
            string namespace_,
            string userId,
            bool? responseBody,
            Model.ModelsAdminPlayerConcurrentRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (responseBody != null) QueryParams["responseBody"] = Convert.ToString(responseBody)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/adminrecords/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPlayerRecordConcurrentUpdateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordConcurrentUpdateResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}