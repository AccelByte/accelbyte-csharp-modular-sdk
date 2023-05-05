// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RegionDataChange : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemIdentities")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ItemIdentities { get; set; }

        [JsonPropertyName("itemIdentityType")]
        [JsonStringEnum]
        public RegionDataChangeItemIdentityType? ItemIdentityType { get; set; }

        [JsonPropertyName("regionData")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, List<RegionDataItem>>? RegionData { get; set; }

    }



    public class RegionDataChangeItemIdentityType : StringEnum<RegionDataChangeItemIdentityType>
    {
        public static readonly RegionDataChangeItemIdentityType ITEMID
            = new RegionDataChangeItemIdentityType("ITEM_ID");

        public static readonly RegionDataChangeItemIdentityType ITEMSKU
            = new RegionDataChangeItemIdentityType("ITEM_SKU");


        public static implicit operator RegionDataChangeItemIdentityType(string value)
        {
            return NewValue(value);
        }

        public RegionDataChangeItemIdentityType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}