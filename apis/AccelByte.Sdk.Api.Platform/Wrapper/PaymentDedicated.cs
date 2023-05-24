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
    public class PaymentDedicated
    {
        private readonly IAccelByteSdk _sdk;

        public PaymentDedicated(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreatePaymentOrderByDedicated.CreatePaymentOrderByDedicatedBuilder CreatePaymentOrderByDedicatedOp
        {
            get { return new Operation.CreatePaymentOrderByDedicated.CreatePaymentOrderByDedicatedBuilder(_sdk); }
        }
        public RefundPaymentOrderByDedicated.RefundPaymentOrderByDedicatedBuilder RefundPaymentOrderByDedicatedOp
        {
            get { return new Operation.RefundPaymentOrderByDedicated.RefundPaymentOrderByDedicatedBuilder(_sdk); }
        }
        public SyncPaymentOrders.SyncPaymentOrdersBuilder SyncPaymentOrdersOp
        {
            get { return new Operation.SyncPaymentOrders.SyncPaymentOrdersBuilder(_sdk); }
        }
        #endregion

        public Model.PaymentOrderCreateResult? CreatePaymentOrderByDedicated(CreatePaymentOrderByDedicated input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderRefundResult? RefundPaymentOrderByDedicated(RefundPaymentOrderByDedicated input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PaymentOrderSyncResult? SyncPaymentOrders(SyncPaymentOrders input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}