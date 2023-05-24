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
    public class ItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("categoryPath")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public ItemUpdateEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("images")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("itemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemUpdateItemType? ItemType { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localizations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("lootBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LootBoxConfig? LootBoxConfig { get; set; }

        [JsonPropertyName("maxCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCount { get; set; }

        [JsonPropertyName("maxCountPerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCountPerUser { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("optionBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OptionBoxConfig? OptionBoxConfig { get; set; }

        [JsonPropertyName("purchasable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, List<RegionDataItemDTO>>? RegionData { get; set; }

        [JsonPropertyName("saleConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SaleConfig? SaleConfig { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sectionExclusive")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SectionExclusive { get; set; }

        [JsonPropertyName("sellable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sellable { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }

    public class ItemUpdate<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("categoryPath")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public ItemUpdateEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("images")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("itemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public ItemUpdateItemType? ItemType { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localizations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("lootBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public LootBoxConfig? LootBoxConfig { get; set; }

        [JsonPropertyName("maxCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCount { get; set; }

        [JsonPropertyName("maxCountPerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxCountPerUser { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("optionBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OptionBoxConfig? OptionBoxConfig { get; set; }

        [JsonPropertyName("purchasable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, List<RegionDataItemDTO>>? RegionData { get; set; }

        [JsonPropertyName("saleConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SaleConfig? SaleConfig { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateSeasonType? SeasonType { get; set; }

        [JsonPropertyName("sectionExclusive")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SectionExclusive { get; set; }

        [JsonPropertyName("sellable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sellable { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("stackable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Stackable { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ItemUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }


    public class ItemUpdateAppType : StringEnum<ItemUpdateAppType>
    {
        public static readonly ItemUpdateAppType DEMO
            = new ItemUpdateAppType("DEMO");

        public static readonly ItemUpdateAppType DLC
            = new ItemUpdateAppType("DLC");

        public static readonly ItemUpdateAppType GAME
            = new ItemUpdateAppType("GAME");

        public static readonly ItemUpdateAppType SOFTWARE
            = new ItemUpdateAppType("SOFTWARE");


        public static implicit operator ItemUpdateAppType(string value)
        {
            return NewValue(value);
        }

        public ItemUpdateAppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemUpdateEntitlementType : StringEnum<ItemUpdateEntitlementType>
    {
        public static readonly ItemUpdateEntitlementType CONSUMABLE
            = new ItemUpdateEntitlementType("CONSUMABLE");

        public static readonly ItemUpdateEntitlementType DURABLE
            = new ItemUpdateEntitlementType("DURABLE");


        public static implicit operator ItemUpdateEntitlementType(string value)
        {
            return NewValue(value);
        }

        public ItemUpdateEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemUpdateItemType : StringEnum<ItemUpdateItemType>
    {
        public static readonly ItemUpdateItemType APP
            = new ItemUpdateItemType("APP");

        public static readonly ItemUpdateItemType BUNDLE
            = new ItemUpdateItemType("BUNDLE");

        public static readonly ItemUpdateItemType CODE
            = new ItemUpdateItemType("CODE");

        public static readonly ItemUpdateItemType COINS
            = new ItemUpdateItemType("COINS");

        public static readonly ItemUpdateItemType EXTENSION
            = new ItemUpdateItemType("EXTENSION");

        public static readonly ItemUpdateItemType INGAMEITEM
            = new ItemUpdateItemType("INGAMEITEM");

        public static readonly ItemUpdateItemType LOOTBOX
            = new ItemUpdateItemType("LOOTBOX");

        public static readonly ItemUpdateItemType MEDIA
            = new ItemUpdateItemType("MEDIA");

        public static readonly ItemUpdateItemType OPTIONBOX
            = new ItemUpdateItemType("OPTIONBOX");

        public static readonly ItemUpdateItemType SEASON
            = new ItemUpdateItemType("SEASON");

        public static readonly ItemUpdateItemType SUBSCRIPTION
            = new ItemUpdateItemType("SUBSCRIPTION");


        public static implicit operator ItemUpdateItemType(string value)
        {
            return NewValue(value);
        }

        public ItemUpdateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemUpdateSeasonType : StringEnum<ItemUpdateSeasonType>
    {
        public static readonly ItemUpdateSeasonType PASS
            = new ItemUpdateSeasonType("PASS");

        public static readonly ItemUpdateSeasonType TIER
            = new ItemUpdateSeasonType("TIER");


        public static implicit operator ItemUpdateSeasonType(string value)
        {
            return NewValue(value);
        }

        public ItemUpdateSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ItemUpdateStatus : StringEnum<ItemUpdateStatus>
    {
        public static readonly ItemUpdateStatus ACTIVE
            = new ItemUpdateStatus("ACTIVE");

        public static readonly ItemUpdateStatus INACTIVE
            = new ItemUpdateStatus("INACTIVE");


        public static implicit operator ItemUpdateStatus(string value)
        {
            return NewValue(value);
        }

        public ItemUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}