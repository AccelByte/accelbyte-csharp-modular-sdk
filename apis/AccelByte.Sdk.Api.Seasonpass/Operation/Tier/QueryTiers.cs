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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// queryTiers
    ///
    /// This API is used to query paginated tiers for a season.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of passes
    /// </summary>
    public class QueryTiers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryTiersBuilder Builder { get => new QueryTiersBuilder(); }

        public class QueryTiersBuilder
            : OperationBuilder<QueryTiersBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryTiersBuilder() { }

            internal QueryTiersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryTiersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryTiersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryTiers Build(
                string namespace_,
                string seasonId
            )
            {
                QueryTiers op = new QueryTiers(this,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<QueryTiersBuilder>(this);
                return op;
            }

            public Model.TierPagingSlicedResult? Execute(
                string namespace_,
                string seasonId
            )
            {
                QueryTiers op = Build(
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TierPagingSlicedResult?> ExecuteAsync(
                string namespace_,
                string seasonId
            )
            {
                QueryTiers op = Build(
                    namespace_,
                    seasonId
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

        private QueryTiers(QueryTiersBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryTiers(
            string namespace_,
            string seasonId,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.TierPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TierPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TierPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}