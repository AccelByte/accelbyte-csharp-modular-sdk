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
    /// publicQueryUserSubscriptions
    ///
    /// Query user subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscription
    /// </summary>
    public class PublicQueryUserSubscriptions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserSubscriptionsBuilder Builder { get => new PublicQueryUserSubscriptionsBuilder(); }

        public class PublicQueryUserSubscriptionsBuilder
            : OperationBuilder<PublicQueryUserSubscriptionsBuilder>
        {

            public PublicQueryUserSubscriptionsChargeStatus? ChargeStatus { get; set; }

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Sku { get; set; }

            public PublicQueryUserSubscriptionsStatus? Status { get; set; }

            public PublicQueryUserSubscriptionsSubscribedBy? SubscribedBy { get; set; }





            internal PublicQueryUserSubscriptionsBuilder() { }

            internal PublicQueryUserSubscriptionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicQueryUserSubscriptionsBuilder SetChargeStatus(PublicQueryUserSubscriptionsChargeStatus _chargeStatus)
            {
                ChargeStatus = _chargeStatus;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetSku(string _sku)
            {
                Sku = _sku;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetStatus(PublicQueryUserSubscriptionsStatus _status)
            {
                Status = _status;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetSubscribedBy(PublicQueryUserSubscriptionsSubscribedBy _subscribedBy)
            {
                SubscribedBy = _subscribedBy;
                return this;
            }





            public PublicQueryUserSubscriptions Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserSubscriptions op = new PublicQueryUserSubscriptions(this,
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
                PublicQueryUserSubscriptions op = Build(
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

        private PublicQueryUserSubscriptions(PublicQueryUserSubscriptionsBuilder builder,
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

        public PublicQueryUserSubscriptions(
            string namespace_,
            string userId,
            PublicQueryUserSubscriptionsChargeStatus? chargeStatus,
            string? itemId,
            int? limit,
            int? offset,
            string? sku,
            PublicQueryUserSubscriptionsStatus? status,
            PublicQueryUserSubscriptionsSubscribedBy? subscribedBy
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

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions";

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

    public class PublicQueryUserSubscriptionsChargeStatus : StringEnum<PublicQueryUserSubscriptionsChargeStatus>
    {
        public static readonly PublicQueryUserSubscriptionsChargeStatus CHARGED
            = new PublicQueryUserSubscriptionsChargeStatus("CHARGED");

        public static readonly PublicQueryUserSubscriptionsChargeStatus CHARGEFAILED
            = new PublicQueryUserSubscriptionsChargeStatus("CHARGE_FAILED");

        public static readonly PublicQueryUserSubscriptionsChargeStatus NEVER
            = new PublicQueryUserSubscriptionsChargeStatus("NEVER");

        public static readonly PublicQueryUserSubscriptionsChargeStatus RECURRINGCHARGING
            = new PublicQueryUserSubscriptionsChargeStatus("RECURRING_CHARGING");

        public static readonly PublicQueryUserSubscriptionsChargeStatus SETUP
            = new PublicQueryUserSubscriptionsChargeStatus("SETUP");


        public static implicit operator PublicQueryUserSubscriptionsChargeStatus(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserSubscriptionsChargeStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicQueryUserSubscriptionsStatus : StringEnum<PublicQueryUserSubscriptionsStatus>
    {
        public static readonly PublicQueryUserSubscriptionsStatus ACTIVE
            = new PublicQueryUserSubscriptionsStatus("ACTIVE");

        public static readonly PublicQueryUserSubscriptionsStatus CANCELLED
            = new PublicQueryUserSubscriptionsStatus("CANCELLED");

        public static readonly PublicQueryUserSubscriptionsStatus EXPIRED
            = new PublicQueryUserSubscriptionsStatus("EXPIRED");

        public static readonly PublicQueryUserSubscriptionsStatus INIT
            = new PublicQueryUserSubscriptionsStatus("INIT");


        public static implicit operator PublicQueryUserSubscriptionsStatus(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserSubscriptionsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicQueryUserSubscriptionsSubscribedBy : StringEnum<PublicQueryUserSubscriptionsSubscribedBy>
    {
        public static readonly PublicQueryUserSubscriptionsSubscribedBy PLATFORM
            = new PublicQueryUserSubscriptionsSubscribedBy("PLATFORM");

        public static readonly PublicQueryUserSubscriptionsSubscribedBy USER
            = new PublicQueryUserSubscriptionsSubscribedBy("USER");


        public static implicit operator PublicQueryUserSubscriptionsSubscribedBy(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserSubscriptionsSubscribedBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}