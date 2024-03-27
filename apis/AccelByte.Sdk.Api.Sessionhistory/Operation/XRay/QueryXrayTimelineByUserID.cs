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
    /// queryXrayTimelineByUserID
    ///
    /// Query xray timeline by userID or ticketID
    /// </summary>
    public class QueryXrayTimelineByUserID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryXrayTimelineByUserIDBuilder Builder { get => new QueryXrayTimelineByUserIDBuilder(); }

        public class QueryXrayTimelineByUserIDBuilder
            : OperationBuilder<QueryXrayTimelineByUserIDBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal QueryXrayTimelineByUserIDBuilder() { }

            internal QueryXrayTimelineByUserIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryXrayTimelineByUserIDBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryXrayTimelineByUserIDBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryXrayTimelineByUserID Build(
                string namespace_,
                string userId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByUserID op = new QueryXrayTimelineByUserID(this,
                    namespace_,
                    userId,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryXrayTimelineByUserIDBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayTicketQueryResponse? Execute(
                string namespace_,
                string userId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByUserID op = Build(
                    namespace_,
                    userId,
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

        private QueryXrayTimelineByUserID(QueryXrayTimelineByUserIDBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryXrayTimelineByUserID(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/users/{userId}/tickets";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsXRayTicketQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayTicketQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsXRayTicketQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}