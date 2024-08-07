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
    /// queryMatchHistories
    ///
    /// Query xray match histories.
    /// </summary>
    public class QueryMatchHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryMatchHistoriesBuilder Builder { get => new QueryMatchHistoriesBuilder(); }

        public class QueryMatchHistoriesBuilder
            : OperationBuilder<QueryMatchHistoriesBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal QueryMatchHistoriesBuilder() { }

            internal QueryMatchHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryMatchHistoriesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryMatchHistoriesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryMatchHistories Build(
                string matchId,
                string namespace_
            )
            {
                QueryMatchHistories op = new QueryMatchHistories(this,
                    matchId,
                    namespace_
                );

                op.SetBaseFields<QueryMatchHistoriesBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayMatchHistorQueryResponse? Execute(
                string matchId,
                string namespace_
            )
            {
                QueryMatchHistories op = Build(
                    matchId,
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
            public async Task<Model.ApimodelsXRayMatchHistorQueryResponse?> ExecuteAsync(
                string matchId,
                string namespace_
            )
            {
                QueryMatchHistories op = Build(
                    matchId,
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

        private QueryMatchHistories(QueryMatchHistoriesBuilder builder,
            string matchId,
            string namespace_
        )
        {
            PathParams["matchId"] = matchId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryMatchHistories(
            string matchId,
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["matchId"] = matchId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/matches/{matchId}/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayMatchHistorQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchHistorQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchHistorQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}