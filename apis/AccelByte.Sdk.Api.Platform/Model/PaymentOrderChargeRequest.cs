// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderChargeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extTxId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentOrderChargeRequestPaymentProvider? PaymentProvider { get; set; }

    }



    public class PaymentOrderChargeRequestPaymentProvider : StringEnum<PaymentOrderChargeRequestPaymentProvider>
    {
        public static readonly PaymentOrderChargeRequestPaymentProvider ADYEN
            = new PaymentOrderChargeRequestPaymentProvider("ADYEN");

        public static readonly PaymentOrderChargeRequestPaymentProvider ALIPAY
            = new PaymentOrderChargeRequestPaymentProvider("ALIPAY");

        public static readonly PaymentOrderChargeRequestPaymentProvider CHECKOUT
            = new PaymentOrderChargeRequestPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderChargeRequestPaymentProvider NEONPAY
            = new PaymentOrderChargeRequestPaymentProvider("NEONPAY");

        public static readonly PaymentOrderChargeRequestPaymentProvider PAYPAL
            = new PaymentOrderChargeRequestPaymentProvider("PAYPAL");

        public static readonly PaymentOrderChargeRequestPaymentProvider STRIPE
            = new PaymentOrderChargeRequestPaymentProvider("STRIPE");

        public static readonly PaymentOrderChargeRequestPaymentProvider WALLET
            = new PaymentOrderChargeRequestPaymentProvider("WALLET");

        public static readonly PaymentOrderChargeRequestPaymentProvider WXPAY
            = new PaymentOrderChargeRequestPaymentProvider("WXPAY");

        public static readonly PaymentOrderChargeRequestPaymentProvider XSOLLA
            = new PaymentOrderChargeRequestPaymentProvider("XSOLLA");


        public static implicit operator PaymentOrderChargeRequestPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderChargeRequestPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }
}