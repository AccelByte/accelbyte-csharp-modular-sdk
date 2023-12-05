// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminPutPlayerRecordConcurrentHandlerV1
    ///
    /// Required Permission | `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [UPDATE]`
    /// --------------------|-----------------------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Description
    /// 
    /// 
    /// 
    /// This endpoints will create new player record or replace the existing player record.
    /// 
    ///  Replace behaviour:
    /// The existing value will be replaced completely with the new value.
    /// 
    /// Example
    /// - Existing JSON:
    /// 
    /// 
    /// 
    ///     { "data1": "value" }
    /// 
    /// 
    /// - New JSON:
    /// 
    /// 
    /// 
    ///     { "data2": "new value" }
    /// 
    /// 
    /// - Result:
    /// 
    /// 
    /// 
    ///     { "data2": "new value" }
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Restriction
    /// 
    /// 
    /// This is the restriction of Key Naming for the record:
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// 
    /// 
    /// 3. Cannot use empty string in key names
    /// -
    /// 
    /// 
    ///     { "": "value" }
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Reserved Word
    /// 
    /// 
    /// 
    /// Reserved Word List: __META
    /// 
    /// The reserved word cannot be used as a field in record value,
    /// If still defining the field when creating or updating the record, it will be ignored.
    /// 
    /// 
    /// 
    /// 
    /// ## Parameters Notes
    /// 
    /// 
    /// 1. set_by (default: CLIENT, type: string)
    /// Indicate which party that could modify the game record.
    /// SERVER: record can be modified by server only.
    /// CLIENT: record can be modified by client and server.
    /// 2. updatedAt (required: true)
    /// Time format style: RFC3339
    /// 3. value
    /// Json
    ///  Request Body Example:
    /// 
    /// 
    /// 
    /// 
    ///         {
    ///             "set_by": "SERVER",
    ///             "value": {},
    ///             "updatedAt": "2022-03-17T10:42:15.444Z"
    ///         }
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// ## Optimistic Concurrency Control
    /// 
    /// 
    /// 
    /// This endpoint implement optimistic concurrency control to avoid race condition.
    /// If the record has been updated since the client fetch it, the server will return HTTP status code 412 (precondition failed)
    /// and client need to redo the operation (fetch data and do update).
    /// Otherwise, the server will process the request.
    /// </summary>
    public class AdminPutPlayerRecordConcurrentHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerRecordConcurrentHandlerV1Builder Builder { get => new AdminPutPlayerRecordConcurrentHandlerV1Builder(); }

        public class AdminPutPlayerRecordConcurrentHandlerV1Builder
            : OperationBuilder<AdminPutPlayerRecordConcurrentHandlerV1Builder>
        {

            public bool? ResponseBody { get; set; }





            internal AdminPutPlayerRecordConcurrentHandlerV1Builder() { }

            internal AdminPutPlayerRecordConcurrentHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminPutPlayerRecordConcurrentHandlerV1Builder SetResponseBody(bool _responseBody)
            {
                ResponseBody = _responseBody;
                return this;
            }





            public AdminPutPlayerRecordConcurrentHandlerV1 Build(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordConcurrentHandlerV1 op = new AdminPutPlayerRecordConcurrentHandlerV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPlayerRecordConcurrentUpdateResponse? Execute(
                ModelsAdminConcurrentRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordConcurrentHandlerV1 op = Build(
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
        }

        private AdminPutPlayerRecordConcurrentHandlerV1(AdminPutPlayerRecordConcurrentHandlerV1Builder builder,
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

        public AdminPutPlayerRecordConcurrentHandlerV1(
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

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}";

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