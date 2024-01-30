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
    public class EntitlementInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementInfoAppType? AppType { get; set; }

        [JsonPropertyName("clazz")]
        [JsonStringEnum]
        public EntitlementInfoClazz? Clazz { get; set; }

        [JsonPropertyName("collectionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CollectionId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("grantedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? GrantedAt { get; set; }

        [JsonPropertyName("grantedCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }

        [JsonPropertyName("itemSnapshot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ItemSnapshot? ItemSnapshot { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("noOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? NoOrigin { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementInfoOrigin? Origin { get; set; }

        [JsonPropertyName("platformAvailable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? PlatformAvailable { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementInfoSource? Source { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public EntitlementInfoStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

    }



    public class EntitlementInfoAppType : StringEnum<EntitlementInfoAppType>
    {
        public static readonly EntitlementInfoAppType DEMO
            = new EntitlementInfoAppType("DEMO");

        public static readonly EntitlementInfoAppType DLC
            = new EntitlementInfoAppType("DLC");

        public static readonly EntitlementInfoAppType GAME
            = new EntitlementInfoAppType("GAME");

        public static readonly EntitlementInfoAppType SOFTWARE
            = new EntitlementInfoAppType("SOFTWARE");


        public static implicit operator EntitlementInfoAppType(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementInfoClazz : StringEnum<EntitlementInfoClazz>
    {
        public static readonly EntitlementInfoClazz APP
            = new EntitlementInfoClazz("APP");

        public static readonly EntitlementInfoClazz CODE
            = new EntitlementInfoClazz("CODE");

        public static readonly EntitlementInfoClazz ENTITLEMENT
            = new EntitlementInfoClazz("ENTITLEMENT");

        public static readonly EntitlementInfoClazz LOOTBOX
            = new EntitlementInfoClazz("LOOTBOX");

        public static readonly EntitlementInfoClazz MEDIA
            = new EntitlementInfoClazz("MEDIA");

        public static readonly EntitlementInfoClazz OPTIONBOX
            = new EntitlementInfoClazz("OPTIONBOX");

        public static readonly EntitlementInfoClazz SUBSCRIPTION
            = new EntitlementInfoClazz("SUBSCRIPTION");


        public static implicit operator EntitlementInfoClazz(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementInfoOrigin : StringEnum<EntitlementInfoOrigin>
    {
        public static readonly EntitlementInfoOrigin Epic
            = new EntitlementInfoOrigin("Epic");

        public static readonly EntitlementInfoOrigin GooglePlay
            = new EntitlementInfoOrigin("GooglePlay");

        public static readonly EntitlementInfoOrigin IOS
            = new EntitlementInfoOrigin("IOS");

        public static readonly EntitlementInfoOrigin Nintendo
            = new EntitlementInfoOrigin("Nintendo");

        public static readonly EntitlementInfoOrigin Oculus
            = new EntitlementInfoOrigin("Oculus");

        public static readonly EntitlementInfoOrigin Other
            = new EntitlementInfoOrigin("Other");

        public static readonly EntitlementInfoOrigin Playstation
            = new EntitlementInfoOrigin("Playstation");

        public static readonly EntitlementInfoOrigin Steam
            = new EntitlementInfoOrigin("Steam");

        public static readonly EntitlementInfoOrigin System
            = new EntitlementInfoOrigin("System");

        public static readonly EntitlementInfoOrigin Twitch
            = new EntitlementInfoOrigin("Twitch");

        public static readonly EntitlementInfoOrigin Xbox
            = new EntitlementInfoOrigin("Xbox");


        public static implicit operator EntitlementInfoOrigin(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementInfoSource : StringEnum<EntitlementInfoSource>
    {
        public static readonly EntitlementInfoSource ACHIEVEMENT
            = new EntitlementInfoSource("ACHIEVEMENT");

        public static readonly EntitlementInfoSource GIFT
            = new EntitlementInfoSource("GIFT");

        public static readonly EntitlementInfoSource IAP
            = new EntitlementInfoSource("IAP");

        public static readonly EntitlementInfoSource OTHER
            = new EntitlementInfoSource("OTHER");

        public static readonly EntitlementInfoSource PROMOTION
            = new EntitlementInfoSource("PROMOTION");

        public static readonly EntitlementInfoSource PURCHASE
            = new EntitlementInfoSource("PURCHASE");

        public static readonly EntitlementInfoSource REDEEMCODE
            = new EntitlementInfoSource("REDEEM_CODE");

        public static readonly EntitlementInfoSource REFERRALBONUS
            = new EntitlementInfoSource("REFERRAL_BONUS");

        public static readonly EntitlementInfoSource REWARD
            = new EntitlementInfoSource("REWARD");


        public static implicit operator EntitlementInfoSource(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoSource(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementInfoStatus : StringEnum<EntitlementInfoStatus>
    {
        public static readonly EntitlementInfoStatus ACTIVE
            = new EntitlementInfoStatus("ACTIVE");

        public static readonly EntitlementInfoStatus CONSUMED
            = new EntitlementInfoStatus("CONSUMED");

        public static readonly EntitlementInfoStatus INACTIVE
            = new EntitlementInfoStatus("INACTIVE");

        public static readonly EntitlementInfoStatus REVOKED
            = new EntitlementInfoStatus("REVOKED");

        public static readonly EntitlementInfoStatus SOLD
            = new EntitlementInfoStatus("SOLD");


        public static implicit operator EntitlementInfoStatus(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementInfoType : StringEnum<EntitlementInfoType>
    {
        public static readonly EntitlementInfoType CONSUMABLE
            = new EntitlementInfoType("CONSUMABLE");

        public static readonly EntitlementInfoType DURABLE
            = new EntitlementInfoType("DURABLE");


        public static implicit operator EntitlementInfoType(string value)
        {
            return NewValue(value);
        }

        public EntitlementInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }
}