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
    /// adminGetPlayerRecordsHandlerV1
    ///
    /// Retrieve player record key and payload in bulk under given namespace.
    /// Maximum bulk key limit per request 20.
    /// </summary>
    public class AdminGetPlayerRecordsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerRecordsHandlerV1Builder Builder { get => new AdminGetPlayerRecordsHandlerV1Builder(); }

        public class AdminGetPlayerRecordsHandlerV1Builder
            : OperationBuilder<AdminGetPlayerRecordsHandlerV1Builder>
        {





            internal AdminGetPlayerRecordsHandlerV1Builder() { }

            internal AdminGetPlayerRecordsHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetPlayerRecordsHandlerV1 Build(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerRecordsHandlerV1 op = new AdminGetPlayerRecordsHandlerV1(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminGetPlayerRecordsHandlerV1Builder>(this);
                return op;
            }

            public Model.ModelsBulkGetAdminPlayerRecordResponse? Execute(
                ModelsBulkGetPlayerRecordsRequest body,
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerRecordsHandlerV1 op = Build(
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
        }

        private AdminGetPlayerRecordsHandlerV1(AdminGetPlayerRecordsHandlerV1Builder builder,
            ModelsBulkGetPlayerRecordsRequest body,
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

        public AdminGetPlayerRecordsHandlerV1(
            string namespace_,
            string userId,
            Model.ModelsBulkGetPlayerRecordsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk";

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