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
    /// adminListAdminUserRecordsV1
    ///
    /// Required permission: `ADMIN:NAMESPACE:{namespace}:USER:{userId}:CLOUDSAVE:RECORD [READ]`
    /// 
    /// Required scope: `social`
    /// 
    /// Retrieve list of admin player records key and userID under given namespace.
    /// </summary>
    public class AdminListAdminUserRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListAdminUserRecordsV1Builder Builder { get => new AdminListAdminUserRecordsV1Builder(); }

        public class AdminListAdminUserRecordsV1Builder
            : OperationBuilder<AdminListAdminUserRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminListAdminUserRecordsV1Builder() { }

            internal AdminListAdminUserRecordsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListAdminUserRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListAdminUserRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminListAdminUserRecordsV1 Build(
                string namespace_,
                string userId
            )
            {
                AdminListAdminUserRecordsV1 op = new AdminListAdminUserRecordsV1(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsListAdminPlayerRecordKeysResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminListAdminUserRecordsV1 op = Build(
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

        private AdminListAdminUserRecordsV1(AdminListAdminUserRecordsV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListAdminUserRecordsV1(
            string namespace_,
            string userId,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListAdminPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListAdminPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListAdminPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}