// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentUrl : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("paymentProvider")]
        [JsonStringEnum]
        public PaymentUrlPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentType")]
        [JsonStringEnum]
        public PaymentUrlPaymentType? PaymentType { get; set; }

        [JsonPropertyName("paymentUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentUrl_ { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sessionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SessionData { get; set; }

        [JsonPropertyName("sessionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SessionId { get; set; }

    }



    public class PaymentUrlPaymentProvider : StringEnum<PaymentUrlPaymentProvider>
    {
        public static readonly PaymentUrlPaymentProvider ADYEN
            = new PaymentUrlPaymentProvider("ADYEN");

        public static readonly PaymentUrlPaymentProvider ALIPAY
            = new PaymentUrlPaymentProvider("ALIPAY");

        public static readonly PaymentUrlPaymentProvider CHECKOUT
            = new PaymentUrlPaymentProvider("CHECKOUT");

        public static readonly PaymentUrlPaymentProvider PAYPAL
            = new PaymentUrlPaymentProvider("PAYPAL");

        public static readonly PaymentUrlPaymentProvider STRIPE
            = new PaymentUrlPaymentProvider("STRIPE");

        public static readonly PaymentUrlPaymentProvider WALLET
            = new PaymentUrlPaymentProvider("WALLET");

        public static readonly PaymentUrlPaymentProvider WXPAY
            = new PaymentUrlPaymentProvider("WXPAY");

        public static readonly PaymentUrlPaymentProvider XSOLLA
            = new PaymentUrlPaymentProvider("XSOLLA");


        public static implicit operator PaymentUrlPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PaymentUrlPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class PaymentUrlPaymentType : StringEnum<PaymentUrlPaymentType>
    {
        public static readonly PaymentUrlPaymentType LINK
            = new PaymentUrlPaymentType("LINK");

        public static readonly PaymentUrlPaymentType QRCODE
            = new PaymentUrlPaymentType("QR_CODE");


        public static implicit operator PaymentUrlPaymentType(string value)
        {
            return NewValue(value);
        }

        public PaymentUrlPaymentType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}