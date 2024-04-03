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
    /// queryXrayTimelineByTicketID
    ///
    /// Query xray timeline by ticketID
    /// </summary>
    public class QueryXrayTimelineByTicketID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryXrayTimelineByTicketIDBuilder Builder { get => new QueryXrayTimelineByTicketIDBuilder(); }

        public class QueryXrayTimelineByTicketIDBuilder
            : OperationBuilder<QueryXrayTimelineByTicketIDBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal QueryXrayTimelineByTicketIDBuilder() { }

            internal QueryXrayTimelineByTicketIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryXrayTimelineByTicketIDBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryXrayTimelineByTicketIDBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryXrayTimelineByTicketID Build(
                string namespace_,
                string ticketId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByTicketID op = new QueryXrayTimelineByTicketID(this,
                    namespace_,
                    ticketId,
                    endDate,
                    startDate
                );

                op.SetBaseFields<QueryXrayTimelineByTicketIDBuilder>(this);
                return op;
            }

            public Model.ApimodelsXRayTicketQueryResponse? Execute(
                string namespace_,
                string ticketId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByTicketID op = Build(
                    namespace_,
                    ticketId,
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
            public async Task<Model.ApimodelsXRayTicketQueryResponse?> ExecuteAsync(
                string namespace_,
                string ticketId,
                string endDate,
                string startDate
            )
            {
                QueryXrayTimelineByTicketID op = Build(
                    namespace_,
                    ticketId,
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

        private QueryXrayTimelineByTicketID(QueryXrayTimelineByTicketIDBuilder builder,
            string namespace_,
            string ticketId,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryXrayTimelineByTicketID(
            string namespace_,
            string ticketId,
            long? limit,
            long? offset,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ticketId"] = ticketId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/tickets/{ticketId}";

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