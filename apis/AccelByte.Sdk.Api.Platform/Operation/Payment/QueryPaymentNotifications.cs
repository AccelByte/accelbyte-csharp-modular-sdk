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
    /// queryPaymentNotifications
    ///
    ///  [Not Supported Yet In Starter] Query payment notifications.
    /// Other detail info:
    /// 
    ///   * Returns : Payment notifications
    /// </summary>
    public class QueryPaymentNotifications : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryPaymentNotificationsBuilder Builder { get => new QueryPaymentNotificationsBuilder(); }

        public class QueryPaymentNotificationsBuilder
            : OperationBuilder<QueryPaymentNotificationsBuilder>
        {

            public string? EndDate { get; set; }

            public string? ExternalId { get; set; }

            public int? Limit { get; set; }

            public QueryPaymentNotificationsNotificationSource? NotificationSource { get; set; }

            public string? NotificationType { get; set; }

            public int? Offset { get; set; }

            public string? PaymentOrderNo { get; set; }

            public string? StartDate { get; set; }

            public QueryPaymentNotificationsStatus? Status { get; set; }





            internal QueryPaymentNotificationsBuilder() { }

            internal QueryPaymentNotificationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryPaymentNotificationsBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetExternalId(string _externalId)
            {
                ExternalId = _externalId;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetNotificationSource(QueryPaymentNotificationsNotificationSource _notificationSource)
            {
                NotificationSource = _notificationSource;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetNotificationType(string _notificationType)
            {
                NotificationType = _notificationType;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetPaymentOrderNo(string _paymentOrderNo)
            {
                PaymentOrderNo = _paymentOrderNo;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public QueryPaymentNotificationsBuilder SetStatus(QueryPaymentNotificationsStatus _status)
            {
                Status = _status;
                return this;
            }





            public QueryPaymentNotifications Build(
                string namespace_
            )
            {
                QueryPaymentNotifications op = new QueryPaymentNotifications(this,
                    namespace_
                );

                op.SetBaseFields<QueryPaymentNotificationsBuilder>(this);
                return op;
            }

            public Model.PaymentNotificationPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QueryPaymentNotifications op = Build(
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
            public async Task<Model.PaymentNotificationPagingSlicedResult?> ExecuteAsync(
                string namespace_
            )
            {
                QueryPaymentNotifications op = Build(
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

        private QueryPaymentNotifications(QueryPaymentNotificationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.ExternalId is not null) QueryParams["externalId"] = builder.ExternalId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.NotificationSource is not null) QueryParams["notificationSource"] = builder.NotificationSource.Value;
            if (builder.NotificationType is not null) QueryParams["notificationType"] = builder.NotificationType;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PaymentOrderNo is not null) QueryParams["paymentOrderNo"] = builder.PaymentOrderNo;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryPaymentNotifications(
            string namespace_,
            string? endDate,
            string? externalId,
            int? limit,
            QueryPaymentNotificationsNotificationSource? notificationSource,
            string? notificationType,
            int? offset,
            string? paymentOrderNo,
            string? startDate,
            QueryPaymentNotificationsStatus? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (externalId is not null) QueryParams["externalId"] = externalId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (notificationSource is not null) QueryParams["notificationSource"] = notificationSource.Value;
            if (notificationType is not null) QueryParams["notificationType"] = notificationType;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/notifications";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentNotificationPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentNotificationPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentNotificationPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryPaymentNotificationsNotificationSource : StringEnum<QueryPaymentNotificationsNotificationSource>
    {
        public static readonly QueryPaymentNotificationsNotificationSource ADYEN
            = new QueryPaymentNotificationsNotificationSource("ADYEN");

        public static readonly QueryPaymentNotificationsNotificationSource ALIPAY
            = new QueryPaymentNotificationsNotificationSource("ALIPAY");

        public static readonly QueryPaymentNotificationsNotificationSource CHECKOUT
            = new QueryPaymentNotificationsNotificationSource("CHECKOUT");

        public static readonly QueryPaymentNotificationsNotificationSource PAYPAL
            = new QueryPaymentNotificationsNotificationSource("PAYPAL");

        public static readonly QueryPaymentNotificationsNotificationSource STRIPE
            = new QueryPaymentNotificationsNotificationSource("STRIPE");

        public static readonly QueryPaymentNotificationsNotificationSource WALLET
            = new QueryPaymentNotificationsNotificationSource("WALLET");

        public static readonly QueryPaymentNotificationsNotificationSource WXPAY
            = new QueryPaymentNotificationsNotificationSource("WXPAY");

        public static readonly QueryPaymentNotificationsNotificationSource XSOLLA
            = new QueryPaymentNotificationsNotificationSource("XSOLLA");


        public static implicit operator QueryPaymentNotificationsNotificationSource(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentNotificationsNotificationSource(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryPaymentNotificationsStatus : StringEnum<QueryPaymentNotificationsStatus>
    {
        public static readonly QueryPaymentNotificationsStatus ERROR
            = new QueryPaymentNotificationsStatus("ERROR");

        public static readonly QueryPaymentNotificationsStatus IGNORED
            = new QueryPaymentNotificationsStatus("IGNORED");

        public static readonly QueryPaymentNotificationsStatus PROCESSED
            = new QueryPaymentNotificationsStatus("PROCESSED");

        public static readonly QueryPaymentNotificationsStatus WARN
            = new QueryPaymentNotificationsStatus("WARN");


        public static implicit operator QueryPaymentNotificationsStatus(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentNotificationsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}