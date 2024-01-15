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
    /// adminPutPlayerPublicRecordHandlerV1
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
    /// 3. Cannot use empty string in key names
    /// - `{ "": "value" }`
    /// 
    /// 
    /// ## Warning: This endpoint is going to deprecate
    /// 
    /// This endpoint is going to deprecate in the future please don't use it.
    /// 
    /// For alternative, please use these endpoints:
    /// - **POST /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **PUT /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}** and utilizing **__META** functionality
    /// - **DELETE /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}**
    /// </summary>
    public class AdminPutPlayerPublicRecordHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerPublicRecordHandlerV1Builder Builder { get => new AdminPutPlayerPublicRecordHandlerV1Builder(); }

        public class AdminPutPlayerPublicRecordHandlerV1Builder
            : OperationBuilder<AdminPutPlayerPublicRecordHandlerV1Builder>
        {





            internal AdminPutPlayerPublicRecordHandlerV1Builder() { }

            internal AdminPutPlayerPublicRecordHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutPlayerPublicRecordHandlerV1 Build(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordHandlerV1 op = new AdminPutPlayerPublicRecordHandlerV1(this,
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

            public Model.ModelsPlayerRecordResponse? Execute(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordHandlerV1 op = Build(
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

            public Model.ModelsPlayerRecordResponse<T1>? Execute<T1>(
                ModelsPlayerRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerPublicRecordHandlerV1 op = Build(
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
        }

        private AdminPutPlayerPublicRecordHandlerV1(AdminPutPlayerPublicRecordHandlerV1Builder builder,
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

        public AdminPutPlayerPublicRecordHandlerV1(
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

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public";

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