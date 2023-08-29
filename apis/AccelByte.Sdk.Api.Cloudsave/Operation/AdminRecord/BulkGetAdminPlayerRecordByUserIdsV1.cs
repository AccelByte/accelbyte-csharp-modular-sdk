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
    /// bulkGetAdminPlayerRecordByUserIdsV1
    ///
    /// Required Permission | `ADMIN:NAMESPACE:{namespace}:CLOUDSAVE:RECORD [READ]`
    /// --------------------|-------------------------------------------------------
    /// Required Scope      | `social`
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Bulk get admin player record by userIds, max allowed 20 at a time.
    /// </summary>
    public class BulkGetAdminPlayerRecordByUserIdsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetAdminPlayerRecordByUserIdsV1Builder Builder { get => new BulkGetAdminPlayerRecordByUserIdsV1Builder(); }

        public class BulkGetAdminPlayerRecordByUserIdsV1Builder
            : OperationBuilder<BulkGetAdminPlayerRecordByUserIdsV1Builder>
        {





            internal BulkGetAdminPlayerRecordByUserIdsV1Builder() { }

            internal BulkGetAdminPlayerRecordByUserIdsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkGetAdminPlayerRecordByUserIdsV1 Build(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetAdminPlayerRecordByUserIdsV1 op = new BulkGetAdminPlayerRecordByUserIdsV1(this,
                    body,
                    key,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsBulkGetAdminPlayerRecordResponse? Execute(
                ModelsBulkUserIDsRequest body,
                string key,
                string namespace_
            )
            {
                BulkGetAdminPlayerRecordByUserIdsV1 op = Build(
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

        private BulkGetAdminPlayerRecordByUserIdsV1(BulkGetAdminPlayerRecordByUserIdsV1Builder builder,
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

        public BulkGetAdminPlayerRecordByUserIdsV1(
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

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/adminrecords/{key}/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsBulkGetAdminPlayerRecordResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsBulkGetAdminPlayerRecordResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}