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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryIAPClawbackHistory
    ///
    /// Query clawback history.
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:IAP:CLAWBACK, action=2 (READ)
    ///   *  Returns : paginated clawback history
    /// </summary>
    public class QueryIAPClawbackHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryIAPClawbackHistoryBuilder Builder { get => new QueryIAPClawbackHistoryBuilder(); }

        public class QueryIAPClawbackHistoryBuilder
            : OperationBuilder<QueryIAPClawbackHistoryBuilder>
        {

            public string? EndTime { get; set; }

            public QueryIAPClawbackHistoryEventType? EventType { get; set; }

            public string? ExternalOrderId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? StartTime { get; set; }

            public QueryIAPClawbackHistoryStatus? Status { get; set; }

            public string? UserId { get; set; }





            internal QueryIAPClawbackHistoryBuilder() { }

            internal QueryIAPClawbackHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryIAPClawbackHistoryBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetEventType(QueryIAPClawbackHistoryEventType _eventType)
            {
                EventType = _eventType;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetExternalOrderId(string _externalOrderId)
            {
                ExternalOrderId = _externalOrderId;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetStatus(QueryIAPClawbackHistoryStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryIAPClawbackHistoryBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QueryIAPClawbackHistory Build(
                string namespace_
            )
            {
                QueryIAPClawbackHistory op = new QueryIAPClawbackHistory(this,
                    namespace_
                );

                op.SetBaseFields<QueryIAPClawbackHistoryBuilder>(this);
                return op;
            }

            public Model.IAPClawbackPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QueryIAPClawbackHistory op = Build(
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
        }

        private QueryIAPClawbackHistory(QueryIAPClawbackHistoryBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndTime is not null) QueryParams["endTime"] = builder.EndTime;
            if (builder.EventType is not null) QueryParams["eventType"] = builder.EventType.Value;
            if (builder.ExternalOrderId is not null) QueryParams["externalOrderId"] = builder.ExternalOrderId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartTime is not null) QueryParams["startTime"] = builder.StartTime;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryIAPClawbackHistory(
            string namespace_,
            string? endTime,
            QueryIAPClawbackHistoryEventType? eventType,
            string? externalOrderId,
            int? limit,
            int? offset,
            string? startTime,
            QueryIAPClawbackHistoryStatus? status,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (eventType is not null) QueryParams["eventType"] = eventType.Value;
            if (externalOrderId is not null) QueryParams["externalOrderId"] = externalOrderId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            if (status is not null) QueryParams["status"] = status.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/clawback/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.IAPClawbackPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.IAPClawbackPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPClawbackPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryIAPClawbackHistoryEventType : StringEnum<QueryIAPClawbackHistoryEventType>
    {
        public static readonly QueryIAPClawbackHistoryEventType CHARGEBACK
            = new QueryIAPClawbackHistoryEventType("CHARGEBACK");

        public static readonly QueryIAPClawbackHistoryEventType CHARGEBACKREVERSED
            = new QueryIAPClawbackHistoryEventType("CHARGEBACK_REVERSED");

        public static readonly QueryIAPClawbackHistoryEventType OTHER
            = new QueryIAPClawbackHistoryEventType("OTHER");

        public static readonly QueryIAPClawbackHistoryEventType REFUND
            = new QueryIAPClawbackHistoryEventType("REFUND");


        public static implicit operator QueryIAPClawbackHistoryEventType(string value)
        {
            return NewValue(value);
        }

        public QueryIAPClawbackHistoryEventType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryIAPClawbackHistoryStatus : StringEnum<QueryIAPClawbackHistoryStatus>
    {
        public static readonly QueryIAPClawbackHistoryStatus FAIL
            = new QueryIAPClawbackHistoryStatus("FAIL");

        public static readonly QueryIAPClawbackHistoryStatus IGNORED
            = new QueryIAPClawbackHistoryStatus("IGNORED");

        public static readonly QueryIAPClawbackHistoryStatus INIT
            = new QueryIAPClawbackHistoryStatus("INIT");

        public static readonly QueryIAPClawbackHistoryStatus SUCCESS
            = new QueryIAPClawbackHistoryStatus("SUCCESS");


        public static implicit operator QueryIAPClawbackHistoryStatus(string value)
        {
            return NewValue(value);
        }

        public QueryIAPClawbackHistoryStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}