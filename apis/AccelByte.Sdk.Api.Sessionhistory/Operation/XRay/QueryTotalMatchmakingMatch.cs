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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// queryTotalMatchmakingMatch
    ///
    /// Query total match.
    /// </summary>
    public class QueryTotalMatchmakingMatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryTotalMatchmakingMatchBuilder Builder { get => new QueryTotalMatchmakingMatchBuilder(); }

        public class QueryTotalMatchmakingMatchBuilder
            : OperationBuilder<QueryTotalMatchmakingMatchBuilder>
        {

            public string? MatchPool { get; set; }





            internal QueryTotalMatchmakingMatchBuilder() { }

            internal QueryTotalMatchmakingMatchBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryTotalMatchmakingMatchBuilder SetMatchPool(string _matchPool)
            {
                MatchPool = _matchPool;
                return this;
            }





            public QueryTotalMatchmakingMatch Build(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingMatch op = new QueryTotalMatchmakingMatch(this,
                    namespace_,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryTotalMatchmakingMatchBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayMatchMatchmakingQueryResponse? Execute(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingMatch op = Build(
                    namespace_,
                    endDate,
                    startDate
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

        private QueryTotalMatchmakingMatch(QueryTotalMatchmakingMatchBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.MatchPool is not null) QueryParams["matchPool"] = builder.MatchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryTotalMatchmakingMatch(
            string namespace_,
            string? matchPool,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (matchPool is not null) QueryParams["matchPool"] = matchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-match";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayMatchMatchmakingQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchMatchmakingQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchMatchmakingQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}