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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// queryTotalMatchmakingExpired
    ///
    /// Query total ticket expired.
    /// </summary>
    public class QueryTotalMatchmakingExpired : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryTotalMatchmakingExpiredBuilder Builder { get => new QueryTotalMatchmakingExpiredBuilder(); }

        public class QueryTotalMatchmakingExpiredBuilder
            : OperationBuilder<QueryTotalMatchmakingExpiredBuilder>
        {

            public List<string>? MatchPool { get; set; }





            internal QueryTotalMatchmakingExpiredBuilder() { }

            internal QueryTotalMatchmakingExpiredBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryTotalMatchmakingExpiredBuilder SetMatchPool(List<string> _matchPool)
            {
                MatchPool = _matchPool;
                return this;
            }





            public QueryTotalMatchmakingExpired Build(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = new QueryTotalMatchmakingExpired(this,
                    namespace_,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryTotalMatchmakingExpiredBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse? Execute(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = Build(
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
            public async Task<Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse?> ExecuteAsync(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryTotalMatchmakingExpired op = Build(
                    namespace_,
                    endDate,
                    startDate
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

        private QueryTotalMatchmakingExpired(QueryTotalMatchmakingExpiredBuilder builder,
            string namespace_,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.MatchPool is not null) QueryParams["matchPool"] = builder.MatchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;



            CollectionFormatMap["matchPool"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryTotalMatchmakingExpired(
            string namespace_,
            List<string>? matchPool,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (matchPool is not null) QueryParams["matchPool"] = matchPool;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;



            CollectionFormatMap["matchPool"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-expired";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayExpiredMatchmakingTicketQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}