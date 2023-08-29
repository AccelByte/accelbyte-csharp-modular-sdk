// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Payment
    {
        private readonly IAccelByteSdk _sdk;

        public Payment(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryPaymentNotifications.QueryPaymentNotificationsBuilder QueryPaymentNotificationsOp
        {
            get { return new Operation.QueryPaymentNotifications.QueryPaymentNotificationsBuilder(_sdk); }
        }
        public QueryPaymentOrders.QueryPaymentOrdersBuilder QueryPaymentOrdersOp
        {
            get { return new Operation.QueryPaymentOrders.QueryPaymentOrdersBuilder(_sdk); }
        }
        public ListExtOrderNoByExtTxId.ListExtOrderNoByExtTxIdBuilder ListExtOrderNoByExtTxIdOp
        {
            get { return new Operation.ListExtOrderNoByExtTxId.ListExtOrderNoByExtTxIdBuilder(_sdk); }
        }
        public GetPaymentOrder.GetPaymentOrderBuilder GetPaymentOrderOp
        {
            get { return new Operation.GetPaymentOrder.GetPaymentOrderBuilder(_sdk); }
        }
        public ChargePaymentOrder.ChargePaymentOrderBuilder ChargePaymentOrderOp
        {
            get { return new Operation.ChargePaymentOrder.ChargePaymentOrderBuilder(_sdk); }
        }
        public SimulatePaymentOrderNotification.SimulatePaymentOrderNotificationBuilder SimulatePaymentOrderNotificationOp
        {
            get { return new Operation.SimulatePaymentOrderNotification.SimulatePaymentOrderNotificationBuilder(_sdk); }
        }
        public GetPaymentOrderChargeStatus.GetPaymentOrderChargeStatusBuilder GetPaymentOrderChargeStatusOp
        {
            get { return new Operation.GetPaymentOrderChargeStatus.GetPaymentOrderChargeStatusBuilder(_sdk); }
        }
        public CreateUserPaymentOrder.CreateUserPaymentOrderBuilder CreateUserPaymentOrderOp
        {
            get { return new Operation.CreateUserPaymentOrder.CreateUserPaymentOrderBuilder(_sdk); }
        }
        public RefundUserPaymentOrder.RefundUserPaymentOrderBuilder RefundUserPaymentOrderOp
        {
            get { return new Operation.RefundUserPaymentOrder.RefundUserPaymentOrderBuilder(_sdk); }
        }
        #endregion

        public Model.PaymentNotificationPagingSlicedResult? QueryPaymentNotifications(QueryPaymentNotifications input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderPagingSlicedResult? QueryPaymentOrders(QueryPaymentOrders input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? ListExtOrderNoByExtTxId(ListExtOrderNoByExtTxId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? GetPaymentOrder(GetPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PaymentOrderInfo<T1>? GetPaymentOrder<T1>(GetPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? ChargePaymentOrder(ChargePaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PaymentOrderInfo<T1>? ChargePaymentOrder<T1>(ChargePaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NotificationProcessResult? SimulatePaymentOrderNotification(SimulatePaymentOrderNotification input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.NotificationProcessResult<T1>? SimulatePaymentOrderNotification<T1>(SimulatePaymentOrderNotification input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderChargeStatus? GetPaymentOrderChargeStatus(GetPaymentOrderChargeStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? CreateUserPaymentOrder(CreateUserPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PaymentOrderInfo<T1>? CreateUserPaymentOrder<T1>(CreateUserPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderInfo? RefundUserPaymentOrder(RefundUserPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.PaymentOrderInfo<T1>? RefundUserPaymentOrder<T1>(RefundUserPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}