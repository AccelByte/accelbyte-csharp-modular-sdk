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
    public class PaymentOrderNotifySimulation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Amount { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("notifyType")]
        [JsonStringEnum]
        public PaymentOrderNotifySimulationNotifyType? NotifyType { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentOrderNotifySimulationPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("salesTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SalesTax { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

    }



    public class PaymentOrderNotifySimulationNotifyType : StringEnum<PaymentOrderNotifySimulationNotifyType>
    {
        public static readonly PaymentOrderNotifySimulationNotifyType CHARGE
            = new PaymentOrderNotifySimulationNotifyType("CHARGE");

        public static readonly PaymentOrderNotifySimulationNotifyType REFUND
            = new PaymentOrderNotifySimulationNotifyType("REFUND");


        public static implicit operator PaymentOrderNotifySimulationNotifyType(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderNotifySimulationNotifyType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentOrderNotifySimulationPaymentProvider : StringEnum<PaymentOrderNotifySimulationPaymentProvider>
    {
        public static readonly PaymentOrderNotifySimulationPaymentProvider ADYEN
            = new PaymentOrderNotifySimulationPaymentProvider("ADYEN");

        public static readonly PaymentOrderNotifySimulationPaymentProvider ALIPAY
            = new PaymentOrderNotifySimulationPaymentProvider("ALIPAY");

        public static readonly PaymentOrderNotifySimulationPaymentProvider CHECKOUT
            = new PaymentOrderNotifySimulationPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderNotifySimulationPaymentProvider PAYPAL
            = new PaymentOrderNotifySimulationPaymentProvider("PAYPAL");

        public static readonly PaymentOrderNotifySimulationPaymentProvider STRIPE
            = new PaymentOrderNotifySimulationPaymentProvider("STRIPE");

        public static readonly PaymentOrderNotifySimulationPaymentProvider WALLET
            = new PaymentOrderNotifySimulationPaymentProvider("WALLET");

        public static readonly PaymentOrderNotifySimulationPaymentProvider WXPAY
            = new PaymentOrderNotifySimulationPaymentProvider("WXPAY");

        public static readonly PaymentOrderNotifySimulationPaymentProvider XSOLLA
            = new PaymentOrderNotifySimulationPaymentProvider("XSOLLA");


        public static implicit operator PaymentOrderNotifySimulationPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderNotifySimulationPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    
}