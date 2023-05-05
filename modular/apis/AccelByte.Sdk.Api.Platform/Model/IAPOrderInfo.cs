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
    public class IAPOrderInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("credits")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CreditSummary>? Credits { get; set; }

        [JsonPropertyName("currencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("entitlements")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<EntitlementSummary>? Entitlements { get; set; }

        [JsonPropertyName("fulfilledTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? FulfilledTime { get; set; }

        [JsonPropertyName("iapOrderNo")]
        public string? IapOrderNo { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("price")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Price { get; set; }

        [JsonPropertyName("productId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ProductId { get; set; }

        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Quantity { get; set; }

        [JsonPropertyName("receiptData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReceiptData { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("retryCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RetryCount { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public IAPOrderInfoStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TransactionId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public IAPOrderInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class IAPOrderInfoStatus : StringEnum<IAPOrderInfoStatus>
    {
        public static readonly IAPOrderInfoStatus FAILED
            = new IAPOrderInfoStatus("FAILED");

        public static readonly IAPOrderInfoStatus FULFILLED
            = new IAPOrderInfoStatus("FULFILLED");

        public static readonly IAPOrderInfoStatus VERIFIED
            = new IAPOrderInfoStatus("VERIFIED");


        public static implicit operator IAPOrderInfoStatus(string value)
        {
            return NewValue(value);
        }

        public IAPOrderInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class IAPOrderInfoType : StringEnum<IAPOrderInfoType>
    {
        public static readonly IAPOrderInfoType APPLE
            = new IAPOrderInfoType("APPLE");

        public static readonly IAPOrderInfoType EPICGAMES
            = new IAPOrderInfoType("EPICGAMES");

        public static readonly IAPOrderInfoType GOOGLE
            = new IAPOrderInfoType("GOOGLE");

        public static readonly IAPOrderInfoType PLAYSTATION
            = new IAPOrderInfoType("PLAYSTATION");

        public static readonly IAPOrderInfoType STADIA
            = new IAPOrderInfoType("STADIA");

        public static readonly IAPOrderInfoType STEAM
            = new IAPOrderInfoType("STEAM");

        public static readonly IAPOrderInfoType TWITCH
            = new IAPOrderInfoType("TWITCH");

        public static readonly IAPOrderInfoType XBOX
            = new IAPOrderInfoType("XBOX");


        public static implicit operator IAPOrderInfoType(string value)
        {
            return NewValue(value);
        }

        public IAPOrderInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}