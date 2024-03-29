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
    /// listGameRecordsHandlerV1
    ///
    /// Retrieve list of records key by namespace
    /// </summary>
    public class ListGameRecordsHandlerV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListGameRecordsHandlerV1Builder Builder { get => new ListGameRecordsHandlerV1Builder(); }

        public class ListGameRecordsHandlerV1Builder
            : OperationBuilder<ListGameRecordsHandlerV1Builder>
        {

            public string? Query { get; set; }





            internal ListGameRecordsHandlerV1Builder() { }

            internal ListGameRecordsHandlerV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListGameRecordsHandlerV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }





            public ListGameRecordsHandlerV1 Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                ListGameRecordsHandlerV1 op = new ListGameRecordsHandlerV1(this,
                    namespace_,
                    limit,
                    offset
                );

                op.SetBaseFields<ListGameRecordsHandlerV1Builder>(this);
                return op;
            }

            public Model.ModelsListGameRecordKeysResponse? Execute(
                string namespace_,
                long limit,
                long offset
            )
            {
                ListGameRecordsHandlerV1 op = Build(
                    namespace_,
                    limit,
                    offset
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

        private ListGameRecordsHandlerV1(ListGameRecordsHandlerV1Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Query is not null) QueryParams["query"] = builder.Query;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListGameRecordsHandlerV1(
            string namespace_,
            string? query,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (query is not null) QueryParams["query"] = query;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListGameRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameRecordKeysResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameRecordKeysResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}