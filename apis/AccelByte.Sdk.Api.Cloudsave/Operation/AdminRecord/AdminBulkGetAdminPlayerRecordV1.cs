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
    /// adminBulkGetAdminPlayerRecordV1
    ///
    /// Bulk get admin player records. Maximum key per request 20.
    /// </summary>
    public class AdminBulkGetAdminPlayerRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkGetAdminPlayerRecordV1Builder Builder { get => new AdminBulkGetAdminPlayerRecordV1Builder(); }

        public class AdminBulkGetAdminPlayerRecordV1Builder
            : OperationBuilder<AdminBulkGetAdminPlayerRecordV1Builder>
        {





            internal AdminBulkGetAdminPlayerRecordV1Builder() { }

            internal AdminBulkGetAdminPlayerRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkGetAdminPlayerRecordV1 Build(
                ModelsBulkGetAdminPlayerRecordRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkGetAdminPlayerRecordV1 op = new AdminBulkGetAdminPlayerRecordV1(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminBulkGetAdminPlayerRecordV1Builder>(this);
                return op;
            }

            public Model.ModelsBulkGetAdminPlayerRecordResponse? Execute(
                ModelsBulkGetAdminPlayerRecordRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkGetAdminPlayerRecordV1 op = Build(
                    body,
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
            public async Task<Model.ModelsBulkGetAdminPlayerRecordResponse?> ExecuteAsync(
                ModelsBulkGetAdminPlayerRecordRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkGetAdminPlayerRecordV1 op = Build(
                    body,
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

        private AdminBulkGetAdminPlayerRecordV1(AdminBulkGetAdminPlayerRecordV1Builder builder,
            ModelsBulkGetAdminPlayerRecordRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBulkGetAdminPlayerRecordV1(
            string namespace_,
            string userId,
            Model.ModelsBulkGetAdminPlayerRecordRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/bulk";

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