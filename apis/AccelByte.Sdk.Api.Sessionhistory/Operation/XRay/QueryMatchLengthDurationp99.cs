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
    /// queryMatchLengthDurationp99
    ///
    /// Query match length duration p99. time in seconds
    /// </summary>
    public class QueryMatchLengthDurationp99 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryMatchLengthDurationp99Builder Builder { get => new QueryMatchLengthDurationp99Builder(); }

        public class QueryMatchLengthDurationp99Builder
            : OperationBuilder<QueryMatchLengthDurationp99Builder>
        {

            public List<string>? MatchPool { get; set; }





            internal QueryMatchLengthDurationp99Builder() { }

            internal QueryMatchLengthDurationp99Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryMatchLengthDurationp99Builder SetMatchPool(List<string> _matchPool)
            {
                MatchPool = _matchPool;
                return this;
            }





            public QueryMatchLengthDurationp99 Build(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryMatchLengthDurationp99 op = new QueryMatchLengthDurationp99(this,
                    namespace_,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryMatchLengthDurationp99Builder>(this);
                return op;
            }

            public Model.ApimodelsXRayMatchLengthDurationQueryResponse? Execute(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryMatchLengthDurationp99 op = Build(
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
            public async Task<Model.ApimodelsXRayMatchLengthDurationQueryResponse?> ExecuteAsync(
                string namespace_,
                string endDate,
                string startDate
            )
            {
                QueryMatchLengthDurationp99 op = Build(
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

        private QueryMatchLengthDurationp99(QueryMatchLengthDurationp99Builder builder,
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

        public QueryMatchLengthDurationp99(
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

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/match-length-duration-p99";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayMatchLengthDurationQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchLengthDurationQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchLengthDurationQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}