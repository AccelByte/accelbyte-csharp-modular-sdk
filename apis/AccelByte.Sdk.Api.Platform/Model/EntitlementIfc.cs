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
    public class EntitlementIfc : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementIfcAppType? AppType { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementIfcClazz? Clazz { get; set; }

        [JsonPropertyName("collectionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CollectionId { get; set; }

        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("grantedCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemNamespace { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("noOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? NoOrigin { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementIfcOrigin? Origin { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementIfcStatus? Status { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementIfcType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

    }



    public class EntitlementIfcAppType : StringEnum<EntitlementIfcAppType>
    {
        public static readonly EntitlementIfcAppType DEMO
            = new EntitlementIfcAppType("DEMO");

        public static readonly EntitlementIfcAppType DLC
            = new EntitlementIfcAppType("DLC");

        public static readonly EntitlementIfcAppType GAME
            = new EntitlementIfcAppType("GAME");

        public static readonly EntitlementIfcAppType SOFTWARE
            = new EntitlementIfcAppType("SOFTWARE");


        public static implicit operator EntitlementIfcAppType(string value)
        {
            return NewValue(value);
        }

        public EntitlementIfcAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementIfcClazz : StringEnum<EntitlementIfcClazz>
    {
        public static readonly EntitlementIfcClazz APP
            = new EntitlementIfcClazz("APP");

        public static readonly EntitlementIfcClazz CODE
            = new EntitlementIfcClazz("CODE");

        public static readonly EntitlementIfcClazz ENTITLEMENT
            = new EntitlementIfcClazz("ENTITLEMENT");

        public static readonly EntitlementIfcClazz LOOTBOX
            = new EntitlementIfcClazz("LOOTBOX");

        public static readonly EntitlementIfcClazz MEDIA
            = new EntitlementIfcClazz("MEDIA");

        public static readonly EntitlementIfcClazz OPTIONBOX
            = new EntitlementIfcClazz("OPTIONBOX");

        public static readonly EntitlementIfcClazz SUBSCRIPTION
            = new EntitlementIfcClazz("SUBSCRIPTION");


        public static implicit operator EntitlementIfcClazz(string value)
        {
            return NewValue(value);
        }

        public EntitlementIfcClazz(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementIfcOrigin : StringEnum<EntitlementIfcOrigin>
    {
        public static readonly EntitlementIfcOrigin Epic
            = new EntitlementIfcOrigin("Epic");

        public static readonly EntitlementIfcOrigin GooglePlay
            = new EntitlementIfcOrigin("GooglePlay");

        public static readonly EntitlementIfcOrigin IOS
            = new EntitlementIfcOrigin("IOS");

        public static readonly EntitlementIfcOrigin Nintendo
            = new EntitlementIfcOrigin("Nintendo");

        public static readonly EntitlementIfcOrigin Oculus
            = new EntitlementIfcOrigin("Oculus");

        public static readonly EntitlementIfcOrigin Other
            = new EntitlementIfcOrigin("Other");

        public static readonly EntitlementIfcOrigin Playstation
            = new EntitlementIfcOrigin("Playstation");

        public static readonly EntitlementIfcOrigin Steam
            = new EntitlementIfcOrigin("Steam");

        public static readonly EntitlementIfcOrigin System
            = new EntitlementIfcOrigin("System");

        public static readonly EntitlementIfcOrigin Twitch
            = new EntitlementIfcOrigin("Twitch");

        public static readonly EntitlementIfcOrigin Xbox
            = new EntitlementIfcOrigin("Xbox");


        public static implicit operator EntitlementIfcOrigin(string value)
        {
            return NewValue(value);
        }

        public EntitlementIfcOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementIfcStatus : StringEnum<EntitlementIfcStatus>
    {
        public static readonly EntitlementIfcStatus ACTIVE
            = new EntitlementIfcStatus("ACTIVE");

        public static readonly EntitlementIfcStatus CONSUMED
            = new EntitlementIfcStatus("CONSUMED");

        public static readonly EntitlementIfcStatus INACTIVE
            = new EntitlementIfcStatus("INACTIVE");

        public static readonly EntitlementIfcStatus REVOKED
            = new EntitlementIfcStatus("REVOKED");

        public static readonly EntitlementIfcStatus SOLD
            = new EntitlementIfcStatus("SOLD");


        public static implicit operator EntitlementIfcStatus(string value)
        {
            return NewValue(value);
        }

        public EntitlementIfcStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementIfcType : StringEnum<EntitlementIfcType>
    {
        public static readonly EntitlementIfcType CONSUMABLE
            = new EntitlementIfcType("CONSUMABLE");

        public static readonly EntitlementIfcType DURABLE
            = new EntitlementIfcType("DURABLE");


        public static implicit operator EntitlementIfcType(string value)
        {
            return NewValue(value);
        }

        public EntitlementIfcType(string enumValue)
            : base(enumValue)
        {

        }
    }
}