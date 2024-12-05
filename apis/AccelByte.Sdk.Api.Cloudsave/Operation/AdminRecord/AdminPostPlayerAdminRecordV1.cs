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
    /// adminPostPlayerAdminRecordV1
    ///
    /// ## Description
    /// 
    /// This endpoints will create new admin player record or append the existing admin game record.
    /// 
    /// **Append example:**
    /// 
    /// Example 1
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
    /// `{ "data1": "value", "data2": "new value" }`
    /// 
    /// 
    /// Example 2
    /// - Existing JSON:
    /// 
    /// `{ "data1": { "data2": "value" }`
    /// 
    /// - New JSON:
    /// 
    /// `{ "data1": { "data3": "new value" }`
    /// 
    /// - Result:
    /// 
    /// `{ "data1": { "data2": "value", "data3": "new value" }`
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
    public class AdminPostPlayerAdminRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPostPlayerAdminRecordV1Builder Builder { get => new AdminPostPlayerAdminRecordV1Builder(); }

        public class AdminPostPlayerAdminRecordV1Builder
            : OperationBuilder<AdminPostPlayerAdminRecordV1Builder>
        {





            internal AdminPostPlayerAdminRecordV1Builder() { }

            internal AdminPostPlayerAdminRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPostPlayerAdminRecordV1 Build(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = new AdminPostPlayerAdminRecordV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminPostPlayerAdminRecordV1Builder>(this);
                return op;
            }

            public AdminPostPlayerAdminRecordV1.Response Execute(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = Build(
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
            public async Task<AdminPostPlayerAdminRecordV1.Response> ExecuteAsync(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = Build(
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

            public AdminPostPlayerAdminRecordV1.Response<T1> Execute<T1>(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = Build(
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
            public async Task<AdminPostPlayerAdminRecordV1.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPostPlayerAdminRecordV1 op = Build(
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

        private AdminPostPlayerAdminRecordV1(AdminPostPlayerAdminRecordV1Builder builder,
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


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPostPlayerAdminRecordV1";
        }

        public class Response<T1> : ApiResponse<Model.ModelsAdminPlayerRecordResponse<T1>>
        {
            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminRecord::AdminPostPlayerAdminRecordV1";
        }
        #endregion

        public AdminPostPlayerAdminRecordV1(
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

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminPostPlayerAdminRecordV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPostPlayerAdminRecordV1.Response()
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

        public AdminPostPlayerAdminRecordV1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPostPlayerAdminRecordV1.Response<T1>()
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