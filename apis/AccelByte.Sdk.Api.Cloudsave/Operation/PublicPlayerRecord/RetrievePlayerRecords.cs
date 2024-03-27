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
    /// RetrievePlayerRecords
    ///
    /// Retrieve list of player records key under given namespace.
    /// </summary>
    public class RetrievePlayerRecords : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrievePlayerRecordsBuilder Builder { get => new RetrievePlayerRecordsBuilder(); }

        public class RetrievePlayerRecordsBuilder
            : OperationBuilder<RetrievePlayerRecordsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public List<string>? Tags { get; set; }





            internal RetrievePlayerRecordsBuilder() { }

            internal RetrievePlayerRecordsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrievePlayerRecordsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public RetrievePlayerRecordsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public RetrievePlayerRecordsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public RetrievePlayerRecords Build(
                string namespace_
            )
            {
                RetrievePlayerRecords op = new RetrievePlayerRecords(this,
                    namespace_
                );

                op.SetBaseFields<RetrievePlayerRecordsBuilder>(this);
                return op;
            }

            public Model.ModelsListPlayerRecordKeysResponse? Execute(
                string namespace_
            )
            {
                RetrievePlayerRecords op = Build(
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

        private RetrievePlayerRecords(RetrievePlayerRecordsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrievePlayerRecords(
            string namespace_,
            long? limit,
            long? offset,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsListPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}