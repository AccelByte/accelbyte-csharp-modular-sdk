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
    public class ThirdPartySubscriptionTransactionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("expiredAt")]
        public DateTime? ExpiredAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("lastTransactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LastTransactionId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("originalTransactionId")]
        public string? OriginalTransactionId { get; set; }

        [JsonPropertyName("platform")]
        [JsonStringEnum]
        public ThirdPartySubscriptionTransactionInfoPlatform? Platform { get; set; }

        [JsonPropertyName("purchaseToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PurchaseToken { get; set; }

        [JsonPropertyName("startAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartAt { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ThirdPartySubscriptionTransactionInfoStatus? Status { get; set; }

        [JsonPropertyName("subscriptionGroupId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionGroupId { get; set; }

        [JsonPropertyName("subscriptionProductId")]
        public string? SubscriptionProductId { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class ThirdPartySubscriptionTransactionInfoPlatform : StringEnum<ThirdPartySubscriptionTransactionInfoPlatform>
    {
        public static readonly ThirdPartySubscriptionTransactionInfoPlatform APPLE
            = new ThirdPartySubscriptionTransactionInfoPlatform("APPLE");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform EPICGAMES
            = new ThirdPartySubscriptionTransactionInfoPlatform("EPICGAMES");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform GOOGLE
            = new ThirdPartySubscriptionTransactionInfoPlatform("GOOGLE");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform OCULUS
            = new ThirdPartySubscriptionTransactionInfoPlatform("OCULUS");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform PLAYSTATION
            = new ThirdPartySubscriptionTransactionInfoPlatform("PLAYSTATION");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform STADIA
            = new ThirdPartySubscriptionTransactionInfoPlatform("STADIA");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform STEAM
            = new ThirdPartySubscriptionTransactionInfoPlatform("STEAM");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform TWITCH
            = new ThirdPartySubscriptionTransactionInfoPlatform("TWITCH");

        public static readonly ThirdPartySubscriptionTransactionInfoPlatform XBOX
            = new ThirdPartySubscriptionTransactionInfoPlatform("XBOX");


        public static implicit operator ThirdPartySubscriptionTransactionInfoPlatform(string value)
        {
            return NewValue(value);
        }

        public ThirdPartySubscriptionTransactionInfoPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ThirdPartySubscriptionTransactionInfoStatus : StringEnum<ThirdPartySubscriptionTransactionInfoStatus>
    {
        public static readonly ThirdPartySubscriptionTransactionInfoStatus ACTIVE
            = new ThirdPartySubscriptionTransactionInfoStatus("ACTIVE");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus BILLINGRETRYPERIOD
            = new ThirdPartySubscriptionTransactionInfoStatus("BILLING_RETRY_PERIOD");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus CANCELED
            = new ThirdPartySubscriptionTransactionInfoStatus("CANCELED");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus EXPIRED
            = new ThirdPartySubscriptionTransactionInfoStatus("EXPIRED");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus INGRACEPERIOD
            = new ThirdPartySubscriptionTransactionInfoStatus("IN_GRACE_PERIOD");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus ONHOLD
            = new ThirdPartySubscriptionTransactionInfoStatus("ON_HOLD");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus PAUSED
            = new ThirdPartySubscriptionTransactionInfoStatus("PAUSED");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus PENDING
            = new ThirdPartySubscriptionTransactionInfoStatus("PENDING");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus REVOKED
            = new ThirdPartySubscriptionTransactionInfoStatus("REVOKED");

        public static readonly ThirdPartySubscriptionTransactionInfoStatus UNKNOWN
            = new ThirdPartySubscriptionTransactionInfoStatus("UNKNOWN");


        public static implicit operator ThirdPartySubscriptionTransactionInfoStatus(string value)
        {
            return NewValue(value);
        }

        public ThirdPartySubscriptionTransactionInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}