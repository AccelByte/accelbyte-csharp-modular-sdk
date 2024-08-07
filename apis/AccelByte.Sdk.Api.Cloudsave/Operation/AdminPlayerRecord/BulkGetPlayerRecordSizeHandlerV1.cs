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

            public Model.ModelsBulkGetPlayerRecordSizeResponse? Execute(
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
            public async Task<Model.ModelsBulkGetPlayerRecordSizeResponse?> ExecuteAsync(
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

        public Model.ModelsBulkGetPlayerRecordSizeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerRecordSizeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}