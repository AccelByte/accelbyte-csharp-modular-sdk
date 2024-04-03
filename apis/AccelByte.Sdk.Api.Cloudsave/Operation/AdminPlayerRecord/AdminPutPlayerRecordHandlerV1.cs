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
    /// adminPutPlayerRecordHandlerV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new player record or replace the existing player record.
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
    /// ## Record Metadata
    /// 
    /// Metadata allows user to define the behaviour of the record.
    /// Metadata can be defined in request body with field name **__META**.
    /// When creating record, if **__META** field is not defined, the metadata value will use the default value.
    /// When updating record, if **__META** field is not defined, the existing metadata value will stay as is.
    /// 
    /// **Metadata List:**
    /// 1. set_by (default: CLIENT, type: string)
    /// Indicate which party that could modify the game record.
    /// SERVER: record can be modified by server only.
    /// CLIENT: record can be modified by client and server.
    /// 2. is_public (default: false, type: bool)
    /// Indicate whether the player record is a public record or not.
    /// 3. tags (default: *empty array*, type: array of string)
    /// Indicate the tagging for the game record.
    /// 
    /// **Request Body Example:**
    /// ```
    /// {
    /// "__META": {
    /// "set_by": "SERVER",
    /// "is_public": true,
    /// "tags": ["tag1", "tag2"]
    /// }
    /// ...
    /// }
    /// ```
    /// </summary>
    public class AdminPutPlayerRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerRecordHandlerV1Builder Builder { get => new AdminPutPlayerRecordHandlerV1Builder(); }

        public class AdminPutPlayerRecordHandlerV1Builder
            : OperationBuilder<AdminPutPlayerRecordHandlerV1Builder>
        {





            internal AdminPutPlayerRecordHandlerV1Builder() { }

            internal AdminPutPlayerRecordHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutPlayerRecordHandlerV1 Build(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordHandlerV1 op = new AdminPutPlayerRecordHandlerV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminPutPlayerRecordHandlerV1Builder>(this);
                return op;
            }

            public Model.ModelsPlayerRecordResponse? Execute(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordHandlerV1 op = Build(
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
            public async Task<Model.ModelsPlayerRecordResponse?> ExecuteAsync(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordHandlerV1 op = Build(
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

            public Model.ModelsPlayerRecordResponse<T1>? Execute<T1>(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordHandlerV1 op = Build(
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
            public async Task<Model.ModelsPlayerRecordResponse<T1>?> ExecuteAsync<T1>(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerRecordHandlerV1 op = Build(
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

        private AdminPutPlayerRecordHandlerV1(AdminPutPlayerRecordHandlerV1Builder builder,
            ModelsPlayerRecordRequest body,
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

        public AdminPutPlayerRecordHandlerV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsPlayerRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsPlayerRecordResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerRecordResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}