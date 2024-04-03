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
    /// querySubscriptions
    ///
    /// Query subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscriptions
    /// </summary>
    public class QuerySubscriptions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySubscriptionsBuilder Builder { get => new QuerySubscriptionsBuilder(); }

        public class QuerySubscriptionsBuilder
            : OperationBuilder<QuerySubscriptionsBuilder>
        {

            public QuerySubscriptionsChargeStatus? ChargeStatus { get; set; }

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Sku { get; set; }

            public QuerySubscriptionsStatus? Status { get; set; }

            public QuerySubscriptionsSubscribedBy? SubscribedBy { get; set; }

            public string? UserId { get; set; }





            internal QuerySubscriptionsBuilder() { }

            internal QuerySubscriptionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QuerySubscriptionsBuilder SetChargeStatus(QuerySubscriptionsChargeStatus _chargeStatus)
            {
                ChargeStatus = _chargeStatus;
                return this;
            }

            public QuerySubscriptionsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QuerySubscriptionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySubscriptionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySubscriptionsBuilder SetSku(string _sku)
            {
                Sku = _sku;
                return this;
            }

            public QuerySubscriptionsBuilder SetStatus(QuerySubscriptionsStatus _status)
            {
                Status = _status;
                return this;
            }

            public QuerySubscriptionsBuilder SetSubscribedBy(QuerySubscriptionsSubscribedBy _subscribedBy)
            {
                SubscribedBy = _subscribedBy;
                return this;
            }

            public QuerySubscriptionsBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QuerySubscriptions Build(
                string namespace_
            )
            {
                QuerySubscriptions op = new QuerySubscriptions(this,
                    namespace_
                );

                op.SetBaseFields<QuerySubscriptionsBuilder>(this);
                return op;
            }

            public Model.SubscriptionPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QuerySubscriptions op = Build(
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
            public async Task<Model.SubscriptionPagingSlicedResult?> ExecuteAsync(
                string namespace_
            )
            {
                QuerySubscriptions op = Build(
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

        private QuerySubscriptions(QuerySubscriptionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ChargeStatus is not null) QueryParams["chargeStatus"] = builder.ChargeStatus.Value;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Sku is not null) QueryParams["sku"] = builder.Sku;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.SubscribedBy is not null) QueryParams["subscribedBy"] = builder.SubscribedBy.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySubscriptions(
            string namespace_,
            QuerySubscriptionsChargeStatus? chargeStatus,
            string? itemId,
            int? limit,
            int? offset,
            string? sku,
            QuerySubscriptionsStatus? status,
            QuerySubscriptionsSubscribedBy? subscribedBy,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (chargeStatus is not null) QueryParams["chargeStatus"] = chargeStatus.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sku is not null) QueryParams["sku"] = sku;
            if (status is not null) QueryParams["status"] = status.Value;
            if (subscribedBy is not null) QueryParams["subscribedBy"] = subscribedBy.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SubscriptionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QuerySubscriptionsChargeStatus : StringEnum<QuerySubscriptionsChargeStatus>
    {
        public static readonly QuerySubscriptionsChargeStatus CHARGED
            = new QuerySubscriptionsChargeStatus("CHARGED");

        public static readonly QuerySubscriptionsChargeStatus CHARGEFAILED
            = new QuerySubscriptionsChargeStatus("CHARGE_FAILED");

        public static readonly QuerySubscriptionsChargeStatus NEVER
            = new QuerySubscriptionsChargeStatus("NEVER");

        public static readonly QuerySubscriptionsChargeStatus RECURRINGCHARGING
            = new QuerySubscriptionsChargeStatus("RECURRING_CHARGING");

        public static readonly QuerySubscriptionsChargeStatus SETUP
            = new QuerySubscriptionsChargeStatus("SETUP");


        public static implicit operator QuerySubscriptionsChargeStatus(string value)
        {
            return NewValue(value);
        }

        public QuerySubscriptionsChargeStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QuerySubscriptionsStatus : StringEnum<QuerySubscriptionsStatus>
    {
        public static readonly QuerySubscriptionsStatus ACTIVE
            = new QuerySubscriptionsStatus("ACTIVE");

        public static readonly QuerySubscriptionsStatus CANCELLED
            = new QuerySubscriptionsStatus("CANCELLED");

        public static readonly QuerySubscriptionsStatus EXPIRED
            = new QuerySubscriptionsStatus("EXPIRED");

        public static readonly QuerySubscriptionsStatus INIT
            = new QuerySubscriptionsStatus("INIT");


        public static implicit operator QuerySubscriptionsStatus(string value)
        {
            return NewValue(value);
        }

        public QuerySubscriptionsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QuerySubscriptionsSubscribedBy : StringEnum<QuerySubscriptionsSubscribedBy>
    {
        public static readonly QuerySubscriptionsSubscribedBy PLATFORM
            = new QuerySubscriptionsSubscribedBy("PLATFORM");

        public static readonly QuerySubscriptionsSubscribedBy USER
            = new QuerySubscriptionsSubscribedBy("USER");


        public static implicit operator QuerySubscriptionsSubscribedBy(string value)
        {
            return NewValue(value);
        }

        public QuerySubscriptionsSubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}