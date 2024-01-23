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
    /// adminPutPlayerBinaryRecordV1
    ///
    /// Update a player binary record file by its key
    /// </summary>
    public class AdminPutPlayerBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPutPlayerBinaryRecordV1Builder Builder { get => new AdminPutPlayerBinaryRecordV1Builder(); }

        public class AdminPutPlayerBinaryRecordV1Builder
            : OperationBuilder<AdminPutPlayerBinaryRecordV1Builder>
        {





            internal AdminPutPlayerBinaryRecordV1Builder() { }

            internal AdminPutPlayerBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPutPlayerBinaryRecordV1 Build(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerBinaryRecordV1 op = new AdminPutPlayerBinaryRecordV1(this,
                    body,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminPutPlayerBinaryRecordV1Builder>(this);
                return op;
            }

            public Model.ModelsPlayerBinaryRecordResponse? Execute(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                AdminPutPlayerBinaryRecordV1 op = Build(
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

        private AdminPutPlayerBinaryRecordV1(AdminPutPlayerBinaryRecordV1Builder builder,
            ModelsBinaryRecordRequest body,
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

        public AdminPutPlayerBinaryRecordV1(
            string key,
            string namespace_,
            string userId,
            Model.ModelsBinaryRecordRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPlayerBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}