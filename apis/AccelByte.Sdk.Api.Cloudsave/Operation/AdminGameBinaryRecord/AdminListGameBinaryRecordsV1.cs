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
    /// adminListGameBinaryRecordsV1
    ///
    /// Retrieve list of binary records by namespace.
    /// </summary>
    public class AdminListGameBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGameBinaryRecordsV1Builder Builder { get => new AdminListGameBinaryRecordsV1Builder(); }

        public class AdminListGameBinaryRecordsV1Builder
            : OperationBuilder<AdminListGameBinaryRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }





            internal AdminListGameBinaryRecordsV1Builder() { }

            internal AdminListGameBinaryRecordsV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListGameBinaryRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListGameBinaryRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListGameBinaryRecordsV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public AdminListGameBinaryRecordsV1 Build(
                string namespace_
            )
            {
                AdminListGameBinaryRecordsV1 op = new AdminListGameBinaryRecordsV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsListGameBinaryRecordsResponse? Execute(
                string namespace_
            )
            {
                AdminListGameBinaryRecordsV1 op = Build(
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

        private AdminListGameBinaryRecordsV1(AdminListGameBinaryRecordsV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListGameBinaryRecordsV1(
            string namespace_,
            long? limit,
            long? offset,
            string? query
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query is not null) QueryParams["query"] = query;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/binaries";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListGameBinaryRecordsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameBinaryRecordsResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameBinaryRecordsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}