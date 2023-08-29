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
    /// bulkGetPlayerPublicBinaryRecordsV1
    ///
    /// Required Permission: `NAMESPACE:{namespace}:USER:{userId}:PUBLIC:CLOUDSAVE:RECORD [READ]`
    /// Required Scope: `social`
    /// 
    /// Bulk get other player's public binary record by userIds, max allowed 20 at a time. Only record with `isPublic=true` can be
    /// retrieved using this endpoint.
    /// </summary>
    public class BulkGetPlayerPublicBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetPlayerPublicBinaryRecordsV1Builder Builder { get => new BulkGetPlayerPublicBinaryRecordsV1Builder(); }

        public class BulkGetPlayerPublicBinaryRecordsV1Builder
            : OperationBuilder<BulkGetPlayerPublicBinaryRecordsV1Builder>
        {





            internal BulkGetPlayerPublicBinaryRecordsV1Builder() { }

            internal BulkGetPlayerPublicBinaryRecordsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkGetPlayerPublicBinaryRecordsV1 Build(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetPlayerPublicBinaryRecordsV1 op = new BulkGetPlayerPublicBinaryRecordsV1(this,
                    body,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsBulkGetPlayerBinaryRecordResponse? Execute(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetPlayerPublicBinaryRecordsV1 op = Build(
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
        }

        private BulkGetPlayerPublicBinaryRecordsV1(BulkGetPlayerPublicBinaryRecordsV1Builder builder,
            ModelsBulkUserIDsRequest body,
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

        public BulkGetPlayerPublicBinaryRecordsV1(
            string key,
            string namespace_,
            Model.ModelsBulkUserIDsRequest body
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/bulk/binaries/{key}/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsBulkGetPlayerBinaryRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}