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
    /// publicQueryUserOrders
    ///
    /// Query user orders.
    /// Other detail info:
    /// 
    ///   * Returns : get order
    /// </summary>
    public class PublicQueryUserOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserOrdersBuilder Builder { get => new PublicQueryUserOrdersBuilder(); }

        public class PublicQueryUserOrdersBuilder
            : OperationBuilder<PublicQueryUserOrdersBuilder>
        {

            public bool? Discounted { get; set; }

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public PublicQueryUserOrdersStatus? Status { get; set; }





            internal PublicQueryUserOrdersBuilder() { }

            internal PublicQueryUserOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicQueryUserOrdersBuilder SetDiscounted(bool _discounted)
            {
                Discounted = _discounted;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetStatus(PublicQueryUserOrdersStatus _status)
            {
                Status = _status;
                return this;
            }





            public PublicQueryUserOrders Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserOrders op = new PublicQueryUserOrders(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicQueryUserOrdersBuilder>(this);
                return op;
            }

            public Model.OrderPagingSlicedResult? Execute(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserOrders op = Build(
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
            public async Task<Model.OrderPagingSlicedResult?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserOrders op = Build(
                    namespace_,
                    userId
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

        private PublicQueryUserOrders(PublicQueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Discounted != null) QueryParams["discounted"] = Convert.ToString(builder.Discounted)!;
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserOrders(
            string namespace_,
            string userId,
            bool? discounted,
            string? itemId,
            int? limit,
            int? offset,
            PublicQueryUserOrdersStatus? status
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (discounted != null) QueryParams["discounted"] = Convert.ToString(discounted)!;
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicQueryUserOrdersStatus : StringEnum<PublicQueryUserOrdersStatus>
    {
        public static readonly PublicQueryUserOrdersStatus CHARGEBACK
            = new PublicQueryUserOrdersStatus("CHARGEBACK");

        public static readonly PublicQueryUserOrdersStatus CHARGEBACKREVERSED
            = new PublicQueryUserOrdersStatus("CHARGEBACK_REVERSED");

        public static readonly PublicQueryUserOrdersStatus CHARGED
            = new PublicQueryUserOrdersStatus("CHARGED");

        public static readonly PublicQueryUserOrdersStatus CLOSED
            = new PublicQueryUserOrdersStatus("CLOSED");

        public static readonly PublicQueryUserOrdersStatus DELETED
            = new PublicQueryUserOrdersStatus("DELETED");

        public static readonly PublicQueryUserOrdersStatus FULFILLED
            = new PublicQueryUserOrdersStatus("FULFILLED");

        public static readonly PublicQueryUserOrdersStatus FULFILLFAILED
            = new PublicQueryUserOrdersStatus("FULFILL_FAILED");

        public static readonly PublicQueryUserOrdersStatus INIT
            = new PublicQueryUserOrdersStatus("INIT");

        public static readonly PublicQueryUserOrdersStatus REFUNDED
            = new PublicQueryUserOrdersStatus("REFUNDED");

        public static readonly PublicQueryUserOrdersStatus REFUNDING
            = new PublicQueryUserOrdersStatus("REFUNDING");

        public static readonly PublicQueryUserOrdersStatus REFUNDFAILED
            = new PublicQueryUserOrdersStatus("REFUND_FAILED");


        public static implicit operator PublicQueryUserOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}