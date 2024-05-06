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
    /// queryPaymentOrders
    ///
    ///  [Not Supported Yet In Starter] Query payment orders.
    /// Other detail info:
    /// 
    ///   * Returns : query payment orders
    /// </summary>
    public class QueryPaymentOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryPaymentOrdersBuilder Builder { get => new QueryPaymentOrdersBuilder(); }

        public class QueryPaymentOrdersBuilder
            : OperationBuilder<QueryPaymentOrdersBuilder>
        {

            public QueryPaymentOrdersChannel? Channel { get; set; }

            public string? ExtTxId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryPaymentOrdersStatus? Status { get; set; }





            internal QueryPaymentOrdersBuilder() { }

            internal QueryPaymentOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryPaymentOrdersBuilder SetChannel(QueryPaymentOrdersChannel _channel)
            {
                Channel = _channel;
                return this;
            }

            public QueryPaymentOrdersBuilder SetExtTxId(string _extTxId)
            {
                ExtTxId = _extTxId;
                return this;
            }

            public QueryPaymentOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryPaymentOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryPaymentOrdersBuilder SetStatus(QueryPaymentOrdersStatus _status)
            {
                Status = _status;
                return this;
            }





            public QueryPaymentOrders Build(
                string namespace_
            )
            {
                QueryPaymentOrders op = new QueryPaymentOrders(this,
                    namespace_
                );

                op.SetBaseFields<QueryPaymentOrdersBuilder>(this);
                return op;
            }

            public Model.PaymentOrderPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QueryPaymentOrders op = Build(
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
            public async Task<Model.PaymentOrderPagingSlicedResult?> ExecuteAsync(
                string namespace_
            )
            {
                QueryPaymentOrders op = Build(
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

        private QueryPaymentOrders(QueryPaymentOrdersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Channel is not null) QueryParams["channel"] = builder.Channel.Value;
            if (builder.ExtTxId is not null) QueryParams["extTxId"] = builder.ExtTxId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryPaymentOrders(
            string namespace_,
            QueryPaymentOrdersChannel? channel,
            string? extTxId,
            int? limit,
            int? offset,
            QueryPaymentOrdersStatus? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (channel is not null) QueryParams["channel"] = channel.Value;
            if (extTxId is not null) QueryParams["extTxId"] = extTxId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentOrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryPaymentOrdersChannel : StringEnum<QueryPaymentOrdersChannel>
    {
        public static readonly QueryPaymentOrdersChannel EXTERNAL
            = new QueryPaymentOrdersChannel("EXTERNAL");

        public static readonly QueryPaymentOrdersChannel INTERNAL
            = new QueryPaymentOrdersChannel("INTERNAL");


        public static implicit operator QueryPaymentOrdersChannel(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentOrdersChannel(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryPaymentOrdersStatus : StringEnum<QueryPaymentOrdersStatus>
    {
        public static readonly QueryPaymentOrdersStatus AUTHORISED
            = new QueryPaymentOrdersStatus("AUTHORISED");

        public static readonly QueryPaymentOrdersStatus AUTHORISEFAILED
            = new QueryPaymentOrdersStatus("AUTHORISE_FAILED");

        public static readonly QueryPaymentOrdersStatus CHARGEBACK
            = new QueryPaymentOrdersStatus("CHARGEBACK");

        public static readonly QueryPaymentOrdersStatus CHARGEBACKREVERSED
            = new QueryPaymentOrdersStatus("CHARGEBACK_REVERSED");

        public static readonly QueryPaymentOrdersStatus CHARGED
            = new QueryPaymentOrdersStatus("CHARGED");

        public static readonly QueryPaymentOrdersStatus CHARGEFAILED
            = new QueryPaymentOrdersStatus("CHARGE_FAILED");

        public static readonly QueryPaymentOrdersStatus DELETED
            = new QueryPaymentOrdersStatus("DELETED");

        public static readonly QueryPaymentOrdersStatus INIT
            = new QueryPaymentOrdersStatus("INIT");

        public static readonly QueryPaymentOrdersStatus NOTIFICATIONOFCHARGEBACK
            = new QueryPaymentOrdersStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly QueryPaymentOrdersStatus REFUNDED
            = new QueryPaymentOrdersStatus("REFUNDED");

        public static readonly QueryPaymentOrdersStatus REFUNDING
            = new QueryPaymentOrdersStatus("REFUNDING");

        public static readonly QueryPaymentOrdersStatus REFUNDFAILED
            = new QueryPaymentOrdersStatus("REFUND_FAILED");

        public static readonly QueryPaymentOrdersStatus REQUESTFORINFORMATION
            = new QueryPaymentOrdersStatus("REQUEST_FOR_INFORMATION");


        public static implicit operator QueryPaymentOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}