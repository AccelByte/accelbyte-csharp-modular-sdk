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
    /// bulkGetPlayerRecordSizeHandlerV1
    ///
    /// Bulk get player's record size, max allowed 20 at a time, that can be
    /// retrieved using this endpoint.
    /// </summary>
    public class BulkGetPlayerRecordSizeHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetPlayerRecordSizeHandlerV1Builder Builder { get => new BulkGetPlayerRecordSizeHandlerV1Builder(); }

        public class BulkGetPlayerRecordSizeHandlerV1Builder
            : OperationBuilder<BulkGetPlayerRecordSizeHandlerV1Builder>
        {





            internal BulkGetPlayerRecordSizeHandlerV1Builder() { }

            internal BulkGetPlayerRecordSizeHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkGetPlayerRecordSizeHandlerV1 Build(
                ModelsBulkUserKeyRequest body,
                string namespace_
            )
            {
                BulkGetPlayerRecordSizeHandlerV1 op = new BulkGetPlayerRecordSizeHandlerV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<BulkGetPlayerRecordSizeHandlerV1Builder>(this);
                return op;
            }

            public BulkGetPlayerRecordSizeHandlerV1.Response Execute(
                ModelsBulkUserKeyRequest body,
                string namespace_
            )
            {
                BulkGetPlayerRecordSizeHandlerV1 op = Build(
                    body,
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
            public async Task<BulkGetPlayerRecordSizeHandlerV1.Response> ExecuteAsync(
                ModelsBulkUserKeyRequest body,
                string namespace_
            )
            {
                BulkGetPlayerRecordSizeHandlerV1 op = Build(
                    body,
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

        private BulkGetPlayerRecordSizeHandlerV1(BulkGetPlayerRecordSizeHandlerV1Builder builder,
            ModelsBulkUserKeyRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsBulkGetPlayerRecordSizeResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::AdminPlayerRecord::BulkGetPlayerRecordSizeHandlerV1";
        }

        #endregion

        public BulkGetPlayerRecordSizeHandlerV1(
            string namespace_,
            Model.ModelsBulkUserKeyRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/bulk/records/size";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public BulkGetPlayerRecordSizeHandlerV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkGetPlayerRecordSizeHandlerV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload, ResponseJsonOptions);
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