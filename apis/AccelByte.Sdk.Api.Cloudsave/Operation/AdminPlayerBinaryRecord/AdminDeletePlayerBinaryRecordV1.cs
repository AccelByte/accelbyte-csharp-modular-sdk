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
    /// adminDeletePlayerBinaryRecordV1
    ///
    /// Delete a player binary record.
    /// </summary>
    public class AdminDeletePlayerBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlayerBinaryRecordV1Builder Builder { get => new AdminDeletePlayerBinaryRecordV1Builder(); }

        public class AdminDeletePlayerBinaryRecordV1Builder
            : OperationBuilder<AdminDeletePlayerBinaryRecordV1Builder>
        {





            internal AdminDeletePlayerBinaryRecordV1Builder() { }

            internal AdminDeletePlayerBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeletePlayerBinaryRecordV1 Build(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerBinaryRecordV1 op = new AdminDeletePlayerBinaryRecordV1(this,
                    key,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminDeletePlayerBinaryRecordV1Builder>(this);
                return op;
            }

            public AdminDeletePlayerBinaryRecordV1.Response Execute(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerBinaryRecordV1 op = Build(
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
            public async Task<AdminDeletePlayerBinaryRecordV1.Response> ExecuteAsync(
                string key,
                string namespace_,
                string userId
            )
            {
                AdminDeletePlayerBinaryRecordV1 op = Build(
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

        private AdminDeletePlayerBinaryRecordV1(AdminDeletePlayerBinaryRecordV1Builder builder,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error404 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminPlayerBinaryRecord::AdminDeletePlayerBinaryRecordV1";
        }

        #endregion

        public AdminDeletePlayerBinaryRecordV1(
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminDeletePlayerBinaryRecordV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeletePlayerBinaryRecordV1.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)

            {
                response.Error401 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)

            {
                response.Error403 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)

            {
                response.Error404 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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