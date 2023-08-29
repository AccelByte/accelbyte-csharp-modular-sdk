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
    public class BillingHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        [JsonPropertyName("billingAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BillingAccount? BillingAccount { get; set; }

        [JsonPropertyName("changeBillingAccount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ChangeBillingAccount { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("extTxId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtTxId { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("recurringOrderNo")]
        public string? RecurringOrderNo { get; set; }

        [JsonPropertyName("retryAttempted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RetryAttempted { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public BillingHistoryInfoStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("subtotalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SubtotalPrice { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("totalPrice")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPrice { get; set; }

        [JsonPropertyName("totalTax")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTax { get; set; }

        [JsonPropertyName("txEndTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? TxEndTime { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class BillingHistoryInfoStatus : StringEnum<BillingHistoryInfoStatus>
    {
        public static readonly BillingHistoryInfoStatus CHARGED
            = new BillingHistoryInfoStatus("CHARGED");

        public static readonly BillingHistoryInfoStatus CHARGEFAILED
            = new BillingHistoryInfoStatus("CHARGE_FAILED");

        public static readonly BillingHistoryInfoStatus INIT
            = new BillingHistoryInfoStatus("INIT");

        public static readonly BillingHistoryInfoStatus REFUNDED
            = new BillingHistoryInfoStatus("REFUNDED");

        public static readonly BillingHistoryInfoStatus REFUNDFAILED
            = new BillingHistoryInfoStatus("REFUND_FAILED");


        public static implicit operator BillingHistoryInfoStatus(string value)
        {
            return NewValue(value);
        }

        public BillingHistoryInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}