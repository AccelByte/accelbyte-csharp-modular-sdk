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
    public class BundledItemInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public BundledItemInfoAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("boundItemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? BoundItemIds { get; set; }

        [JsonPropertyName("bundledQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BundledQty { get; set; }

        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public BundledItemInfoEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("fresh")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Fresh { get; set; }

        [JsonPropertyName("images")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public BundledItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localExt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? LocalExt { get; set; }

        [JsonPropertyName("longDescription")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LongDescription { get; set; }

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
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("optionBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OptionBoxConfig? OptionBoxConfig { get; set; }

        [JsonPropertyName("purchasable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("purchaseCondition")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PurchaseCondition? PurchaseCondition { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RegionDataItem>? RegionData { get; set; }

        [JsonPropertyName("saleConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SaleConfig? SaleConfig { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public BundledItemInfoSeasonType? SeasonType { get; set; }

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
        [JsonStringEnum]
        public BundledItemInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetItemId { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }

    public class BundledItemInfo<T1, T2> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppId { get; set; }

        [JsonPropertyName("appType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public BundledItemInfoAppType? AppType { get; set; }

        [JsonPropertyName("baseAppId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BaseAppId { get; set; }

        [JsonPropertyName("boothName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BoothName { get; set; }

        [JsonPropertyName("boundItemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? BoundItemIds { get; set; }

        [JsonPropertyName("bundledQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? BundledQty { get; set; }

        [JsonPropertyName("categoryPath")]
        public string? CategoryPath { get; set; }

        [JsonPropertyName("clazz")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Clazz { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("entitlementType")]
        [JsonStringEnum]
        public BundledItemInfoEntitlementType? EntitlementType { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Ext { get; set; }

        [JsonPropertyName("features")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Features { get; set; }

        [JsonPropertyName("fresh")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Fresh { get; set; }

        [JsonPropertyName("images")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIds { get; set; }

        [JsonPropertyName("itemQty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, int>? ItemQty { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public BundledItemInfoItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("listable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Listable { get; set; }

        [JsonPropertyName("localExt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T2? LocalExt { get; set; }

        [JsonPropertyName("longDescription")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LongDescription { get; set; }

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
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("optionBoxConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OptionBoxConfig? OptionBoxConfig { get; set; }

        [JsonPropertyName("purchasable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Purchasable { get; set; }

        [JsonPropertyName("purchaseCondition")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PurchaseCondition? PurchaseCondition { get; set; }

        [JsonPropertyName("recurring")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Recurring? Recurring { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RegionDataItem>? RegionData { get; set; }

        [JsonPropertyName("saleConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SaleConfig? SaleConfig { get; set; }

        [JsonPropertyName("seasonType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public BundledItemInfoSeasonType? SeasonType { get; set; }

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
        [JsonStringEnum]
        public BundledItemInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("targetCurrencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetCurrencyCode { get; set; }

        [JsonPropertyName("targetItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetItemId { get; set; }

        [JsonPropertyName("targetNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ThumbnailUrl { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

    }


    public class BundledItemInfoAppType : StringEnum<BundledItemInfoAppType>
    {
        public static readonly BundledItemInfoAppType DEMO
            = new BundledItemInfoAppType("DEMO");

        public static readonly BundledItemInfoAppType DLC
            = new BundledItemInfoAppType("DLC");

        public static readonly BundledItemInfoAppType GAME
            = new BundledItemInfoAppType("GAME");

        public static readonly BundledItemInfoAppType SOFTWARE
            = new BundledItemInfoAppType("SOFTWARE");


        public static implicit operator BundledItemInfoAppType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoAppType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoEntitlementType : StringEnum<BundledItemInfoEntitlementType>
    {
        public static readonly BundledItemInfoEntitlementType CONSUMABLE
            = new BundledItemInfoEntitlementType("CONSUMABLE");

        public static readonly BundledItemInfoEntitlementType DURABLE
            = new BundledItemInfoEntitlementType("DURABLE");


        public static implicit operator BundledItemInfoEntitlementType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoEntitlementType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoItemType : StringEnum<BundledItemInfoItemType>
    {
        public static readonly BundledItemInfoItemType APP
            = new BundledItemInfoItemType("APP");

        public static readonly BundledItemInfoItemType BUNDLE
            = new BundledItemInfoItemType("BUNDLE");

        public static readonly BundledItemInfoItemType CODE
            = new BundledItemInfoItemType("CODE");

        public static readonly BundledItemInfoItemType COINS
            = new BundledItemInfoItemType("COINS");

        public static readonly BundledItemInfoItemType EXTENSION
            = new BundledItemInfoItemType("EXTENSION");

        public static readonly BundledItemInfoItemType INGAMEITEM
            = new BundledItemInfoItemType("INGAMEITEM");

        public static readonly BundledItemInfoItemType LOOTBOX
            = new BundledItemInfoItemType("LOOTBOX");

        public static readonly BundledItemInfoItemType MEDIA
            = new BundledItemInfoItemType("MEDIA");

        public static readonly BundledItemInfoItemType OPTIONBOX
            = new BundledItemInfoItemType("OPTIONBOX");

        public static readonly BundledItemInfoItemType SEASON
            = new BundledItemInfoItemType("SEASON");

        public static readonly BundledItemInfoItemType SUBSCRIPTION
            = new BundledItemInfoItemType("SUBSCRIPTION");


        public static implicit operator BundledItemInfoItemType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoSeasonType : StringEnum<BundledItemInfoSeasonType>
    {
        public static readonly BundledItemInfoSeasonType PASS
            = new BundledItemInfoSeasonType("PASS");

        public static readonly BundledItemInfoSeasonType TIER
            = new BundledItemInfoSeasonType("TIER");


        public static implicit operator BundledItemInfoSeasonType(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoSeasonType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class BundledItemInfoStatus : StringEnum<BundledItemInfoStatus>
    {
        public static readonly BundledItemInfoStatus ACTIVE
            = new BundledItemInfoStatus("ACTIVE");

        public static readonly BundledItemInfoStatus INACTIVE
            = new BundledItemInfoStatus("INACTIVE");


        public static implicit operator BundledItemInfoStatus(string value)
        {
            return NewValue(value);
        }

        public BundledItemInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}