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
    /// queryDetailTickMatchPool
    ///
    /// Query xray match pool ticks.
    /// </summary>
    public class QueryDetailTickMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryDetailTickMatchPoolBuilder Builder { get => new QueryDetailTickMatchPoolBuilder(); }

        public class QueryDetailTickMatchPoolBuilder
            : OperationBuilder<QueryDetailTickMatchPoolBuilder>
        {

            public bool? All { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal QueryDetailTickMatchPoolBuilder() { }

            internal QueryDetailTickMatchPoolBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryDetailTickMatchPoolBuilder SetAll(bool _all)
            {
                All = _all;
                return this;
            }

            public QueryDetailTickMatchPoolBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryDetailTickMatchPoolBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryDetailTickMatchPool Build(
                string namespace_,
                string podName,
                string poolName,
                string endDate,
                string startDate
            )
            {
                QueryDetailTickMatchPool op = new QueryDetailTickMatchPool(this,
                    namespace_,
                    podName,
                    poolName,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryDetailTickMatchPoolBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayMatchPoolPodTickQueryResponse? Execute(
                string namespace_,
                string podName,
                string poolName,
                string endDate,
                string startDate
            )
            {
                QueryDetailTickMatchPool op = Build(
                    namespace_,
                    podName,
                    poolName,
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
            public async Task<Model.ApimodelsXRayMatchPoolPodTickQueryResponse?> ExecuteAsync(
                string namespace_,
                string podName,
                string poolName,
                string endDate,
                string startDate
            )
            {
                QueryDetailTickMatchPool op = Build(
                    namespace_,
                    podName,
                    poolName,
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

        private QueryDetailTickMatchPool(QueryDetailTickMatchPoolBuilder builder,
            string namespace_,
            string podName,
            string poolName,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            PathParams["poolName"] = poolName;

            if (builder.All != null) QueryParams["all"] = Convert.ToString(builder.All)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryDetailTickMatchPool(
            string namespace_,
            string podName,
            string poolName,
            bool? all,
            long? limit,
            long? offset,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            PathParams["poolName"] = poolName;

            if (all != null) QueryParams["all"] = Convert.ToString(all)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}/pods/{podName}/ticks";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayMatchPoolPodTickQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchPoolPodTickQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayMatchPoolPodTickQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}