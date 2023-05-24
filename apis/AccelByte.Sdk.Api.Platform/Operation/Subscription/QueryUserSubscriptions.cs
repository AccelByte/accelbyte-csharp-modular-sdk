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
    /// queryUserSubscriptions
    ///
    /// Query user subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscription
    /// </summary>
    public class QueryUserSubscriptions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserSubscriptionsBuilder Builder { get => new QueryUserSubscriptionsBuilder(); }

        public class QueryUserSubscriptionsBuilder
            : OperationBuilder<QueryUserSubscriptionsBuilder>
        {

            public QueryUserSubscriptionsChargeStatus? ChargeStatus { get; set; }

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Sku { get; set; }

            public QueryUserSubscriptionsStatus? Status { get; set; }

            public QueryUserSubscriptionsSubscribedBy? SubscribedBy { get; set; }





            internal QueryUserSubscriptionsBuilder() { }

            internal QueryUserSubscriptionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserSubscriptionsBuilder SetChargeStatus(QueryUserSubscriptionsChargeStatus _chargeStatus)
            {
                ChargeStatus = _chargeStatus;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetSku(string _sku)
            {
                Sku = _sku;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetStatus(QueryUserSubscriptionsStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryUserSubscriptionsBuilder SetSubscribedBy(QueryUserSubscriptionsSubscribedBy _subscribedBy)
            {
                SubscribedBy = _subscribedBy;
                return this;
            }





            public QueryUserSubscriptions Build(
                string namespace_,
                string userId
            )
            {
                QueryUserSubscriptions op = new QueryUserSubscriptions(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.SubscriptionPagingSlicedResult? Execute(
                string namespace_,
                string userId
            )
            {
                QueryUserSubscriptions op = Build(
                    namespace_,
                    userId
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

        private QueryUserSubscriptions(QueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ChargeStatus is not null) QueryParams["chargeStatus"] = builder.ChargeStatus.Value;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Sku is not null) QueryParams["sku"] = builder.Sku;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.SubscribedBy is not null) QueryParams["subscribedBy"] = builder.SubscribedBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserSubscriptions(
            string namespace_,
            string userId,
            QueryUserSubscriptionsChargeStatus? chargeStatus,
            string? itemId,
            int? limit,
            int? offset,
            string? sku,
            QueryUserSubscriptionsStatus? status,
            QueryUserSubscriptionsSubscribedBy? subscribedBy
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (chargeStatus is not null) QueryParams["chargeStatus"] = chargeStatus.Value;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sku is not null) QueryParams["sku"] = sku;
            if (status is not null) QueryParams["status"] = status.Value;
            if (subscribedBy is not null) QueryParams["subscribedBy"] = subscribedBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions";

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
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryUserSubscriptionsChargeStatus : StringEnum<QueryUserSubscriptionsChargeStatus>
    {
        public static readonly QueryUserSubscriptionsChargeStatus CHARGED
            = new QueryUserSubscriptionsChargeStatus("CHARGED");

        public static readonly QueryUserSubscriptionsChargeStatus CHARGEFAILED
            = new QueryUserSubscriptionsChargeStatus("CHARGE_FAILED");

        public static readonly QueryUserSubscriptionsChargeStatus NEVER
            = new QueryUserSubscriptionsChargeStatus("NEVER");

        public static readonly QueryUserSubscriptionsChargeStatus RECURRINGCHARGING
            = new QueryUserSubscriptionsChargeStatus("RECURRING_CHARGING");

        public static readonly QueryUserSubscriptionsChargeStatus SETUP
            = new QueryUserSubscriptionsChargeStatus("SETUP");


        public static implicit operator QueryUserSubscriptionsChargeStatus(string value)
        {
            return NewValue(value);
        }

        public QueryUserSubscriptionsChargeStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryUserSubscriptionsStatus : StringEnum<QueryUserSubscriptionsStatus>
    {
        public static readonly QueryUserSubscriptionsStatus ACTIVE
            = new QueryUserSubscriptionsStatus("ACTIVE");

        public static readonly QueryUserSubscriptionsStatus CANCELLED
            = new QueryUserSubscriptionsStatus("CANCELLED");

        public static readonly QueryUserSubscriptionsStatus EXPIRED
            = new QueryUserSubscriptionsStatus("EXPIRED");

        public static readonly QueryUserSubscriptionsStatus INIT
            = new QueryUserSubscriptionsStatus("INIT");


        public static implicit operator QueryUserSubscriptionsStatus(string value)
        {
            return NewValue(value);
        }

        public QueryUserSubscriptionsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryUserSubscriptionsSubscribedBy : StringEnum<QueryUserSubscriptionsSubscribedBy>
    {
        public static readonly QueryUserSubscriptionsSubscribedBy PLATFORM
            = new QueryUserSubscriptionsSubscribedBy("PLATFORM");

        public static readonly QueryUserSubscriptionsSubscribedBy USER
            = new QueryUserSubscriptionsSubscribedBy("USER");


        public static implicit operator QueryUserSubscriptionsSubscribedBy(string value)
        {
            return NewValue(value);
        }

        public QueryUserSubscriptionsSubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}