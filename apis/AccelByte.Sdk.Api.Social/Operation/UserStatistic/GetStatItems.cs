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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getStatItems
    ///
    /// Get users' stat item values for a given namespace and statCode.
    /// Other info:
    /// + *Returns*: list of users' stat item values
    /// </summary>
    public class GetStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatItemsBuilder Builder { get => new GetStatItemsBuilder(); }

        public class GetStatItemsBuilder
            : OperationBuilder<GetStatItemsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }





            internal GetStatItemsBuilder() { }

            internal GetStatItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetStatItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetStatItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetStatItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public GetStatItems Build(
                string namespace_,
                string statCode
            )
            {
                GetStatItems op = new GetStatItems(this,
                    namespace_,
                    statCode
                );

                op.SetBaseFields<GetStatItemsBuilder>(this);
                return op;
            }

            public Model.StatItemValuePagingSlicedResult? Execute(
                string namespace_,
                string statCode
            )
            {
                GetStatItems op = Build(
                    namespace_,
                    statCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.StatItemValuePagingSlicedResult?> ExecuteAsync(
                string namespace_,
                string statCode
            )
            {
                GetStatItems op = Build(
                    namespace_,
                    statCode
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

        private GetStatItems(GetStatItemsBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetStatItems(
            string namespace_,
            string statCode,
            int? limit,
            int? offset,
            string? sortBy
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatItemValuePagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemValuePagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemValuePagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}