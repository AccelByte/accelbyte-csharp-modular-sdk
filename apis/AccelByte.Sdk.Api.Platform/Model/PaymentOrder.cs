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
    public class PaymentOrder : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderChannel? Channel { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("charging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Charging { get; set; }

        [JsonPropertyName("checkoutUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CheckoutUrl { get; set; }

        [JsonPropertyName("checkoutUrlExpiredAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CheckoutUrlExpiredAt { get; set; }

        [JsonPropertyName("checkoutUrlValid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CheckoutUrlValid { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("neonPayConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentOrderNeonPayConfig? NeonPayConfig { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("paymentData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentData? PaymentData { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Platform { get; set; }

        [JsonPropertyName("price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("rvn")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rvn { get; set; }

        [JsonPropertyName("salesTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? State { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("tax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Tax { get; set; }

        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("transactions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Transaction>? Transactions { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

        [JsonPropertyName("zipCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ZipCode { get; set; }

    }

    public class PaymentOrder<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? AuthorisedTime { get; set; }

        [JsonPropertyName("channel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderChannel? Channel { get; set; }

        [JsonPropertyName("chargebackReversedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackReversedTime { get; set; }

        [JsonPropertyName("chargebackTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargebackTime { get; set; }

        [JsonPropertyName("chargedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ChargedTime { get; set; }

        [JsonPropertyName("charging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Charging { get; set; }

        [JsonPropertyName("checkoutUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CheckoutUrl { get; set; }

        [JsonPropertyName("checkoutUrlExpiredAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CheckoutUrlExpiredAt { get; set; }

        [JsonPropertyName("checkoutUrlValid")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CheckoutUrlValid { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("createdTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("neonPayConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentOrderNeonPayConfig? NeonPayConfig { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("paymentData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PaymentData? PaymentData { get; set; }

        [JsonPropertyName("paymentMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentMethod { get; set; }

        [JsonPropertyName("paymentMethodFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentMethodFee { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentProvider")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderPaymentProvider? PaymentProvider { get; set; }

        [JsonPropertyName("paymentProviderFee")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? PaymentProviderFee { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Platform { get; set; }

        [JsonPropertyName("price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("rvn")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rvn { get; set; }

        [JsonPropertyName("salesTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SalesTax { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("state")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? State { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("tax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Tax { get; set; }

        [JsonPropertyName("title")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("transactions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Transaction>? Transactions { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

        [JsonPropertyName("vat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Vat { get; set; }

        [JsonPropertyName("zipCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ZipCode { get; set; }

    }


    public class PaymentOrderChannel : StringEnum<PaymentOrderChannel>
    {
        public static readonly PaymentOrderChannel EXTERNAL
            = new PaymentOrderChannel("EXTERNAL");

        public static readonly PaymentOrderChannel INTERNAL
            = new PaymentOrderChannel("INTERNAL");


        public static implicit operator PaymentOrderChannel(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderChannel(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderItemType : StringEnum<PaymentOrderItemType>
    {
        public static readonly PaymentOrderItemType APP
            = new PaymentOrderItemType("APP");

        public static readonly PaymentOrderItemType BUNDLE
            = new PaymentOrderItemType("BUNDLE");

        public static readonly PaymentOrderItemType CODE
            = new PaymentOrderItemType("CODE");

        public static readonly PaymentOrderItemType COINS
            = new PaymentOrderItemType("COINS");

        public static readonly PaymentOrderItemType EXTENSION
            = new PaymentOrderItemType("EXTENSION");

        public static readonly PaymentOrderItemType INGAMEITEM
            = new PaymentOrderItemType("INGAMEITEM");

        public static readonly PaymentOrderItemType LOOTBOX
            = new PaymentOrderItemType("LOOTBOX");

        public static readonly PaymentOrderItemType MEDIA
            = new PaymentOrderItemType("MEDIA");

        public static readonly PaymentOrderItemType OPTIONBOX
            = new PaymentOrderItemType("OPTIONBOX");

        public static readonly PaymentOrderItemType SEASON
            = new PaymentOrderItemType("SEASON");

        public static readonly PaymentOrderItemType SUBSCRIPTION
            = new PaymentOrderItemType("SUBSCRIPTION");


        public static implicit operator PaymentOrderItemType(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderPaymentProvider : StringEnum<PaymentOrderPaymentProvider>
    {
        public static readonly PaymentOrderPaymentProvider ADYEN
            = new PaymentOrderPaymentProvider("ADYEN");

        public static readonly PaymentOrderPaymentProvider ALIPAY
            = new PaymentOrderPaymentProvider("ALIPAY");

        public static readonly PaymentOrderPaymentProvider CHECKOUT
            = new PaymentOrderPaymentProvider("CHECKOUT");

        public static readonly PaymentOrderPaymentProvider NEONPAY
            = new PaymentOrderPaymentProvider("NEONPAY");

        public static readonly PaymentOrderPaymentProvider PAYPAL
            = new PaymentOrderPaymentProvider("PAYPAL");

        public static readonly PaymentOrderPaymentProvider STRIPE
            = new PaymentOrderPaymentProvider("STRIPE");

        public static readonly PaymentOrderPaymentProvider WALLET
            = new PaymentOrderPaymentProvider("WALLET");

        public static readonly PaymentOrderPaymentProvider WXPAY
            = new PaymentOrderPaymentProvider("WXPAY");

        public static readonly PaymentOrderPaymentProvider XSOLLA
            = new PaymentOrderPaymentProvider("XSOLLA");


        public static implicit operator PaymentOrderPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentOrderStatus : StringEnum<PaymentOrderStatus>
    {
        public static readonly PaymentOrderStatus AUTHORISED
            = new PaymentOrderStatus("AUTHORISED");

        public static readonly PaymentOrderStatus AUTHORISEFAILED
            = new PaymentOrderStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderStatus CHARGEBACK
            = new PaymentOrderStatus("CHARGEBACK");

        public static readonly PaymentOrderStatus CHARGEBACKREVERSED
            = new PaymentOrderStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderStatus CHARGED
            = new PaymentOrderStatus("CHARGED");

        public static readonly PaymentOrderStatus CHARGEFAILED
            = new PaymentOrderStatus("CHARGE_FAILED");

        public static readonly PaymentOrderStatus DELETED
            = new PaymentOrderStatus("DELETED");

        public static readonly PaymentOrderStatus INIT
            = new PaymentOrderStatus("INIT");

        public static readonly PaymentOrderStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderStatus REFUNDED
            = new PaymentOrderStatus("REFUNDED");

        public static readonly PaymentOrderStatus REFUNDING
            = new PaymentOrderStatus("REFUNDING");

        public static readonly PaymentOrderStatus REFUNDFAILED
            = new PaymentOrderStatus("REFUND_FAILED");

        public static readonly PaymentOrderStatus REQUESTFORINFORMATION
            = new PaymentOrderStatus("REQUEST_FOR_INFORMATION");


        public static implicit operator PaymentOrderStatus(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}