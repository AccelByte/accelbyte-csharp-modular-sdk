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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryRedeemHistory
    ///
    /// Query redeem history.
    /// Other detail info:
    /// 
    ///   * Returns : slice of redeem history
    /// </summary>
    public class QueryRedeemHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRedeemHistoryBuilder Builder { get => new QueryRedeemHistoryBuilder(); }

        public class QueryRedeemHistoryBuilder
            : OperationBuilder<QueryRedeemHistoryBuilder>
        {

            public string? Code { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? UserId { get; set; }





            internal QueryRedeemHistoryBuilder() { }

            internal QueryRedeemHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryRedeemHistoryBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public QueryRedeemHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRedeemHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRedeemHistoryBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryRedeemHistory Build(
                string campaignId,
                string namespace_
            )
            {
                QueryRedeemHistory op = new QueryRedeemHistory(this,
                    campaignId,
                    namespace_
                );

                op.SetBaseFields<QueryRedeemHistoryBuilder>(this);
                return op;
            }

            public Model.RedeemHistoryPagingSlicedResult? Execute(
                string campaignId,
                string namespace_
            )
            {
                QueryRedeemHistory op = Build(
                    campaignId,
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
            public async Task<Model.RedeemHistoryPagingSlicedResult?> ExecuteAsync(
                string campaignId,
                string namespace_
            )
            {
                QueryRedeemHistory op = Build(
                    campaignId,
                    namespace_
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

        private QueryRedeemHistory(QueryRedeemHistoryBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRedeemHistory(
            string campaignId,
            string namespace_,
            string? code,
            int? limit,
            int? offset,
            string? userId
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.RedeemHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RedeemHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RedeemHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}