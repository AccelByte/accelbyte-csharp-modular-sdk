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
    public class IAPItemEntry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemIdentity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemIdentity { get; set; }

        [JsonPropertyName("itemIdentityType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public IAPItemEntryItemIdentityType? ItemIdentityType { get; set; }

        [JsonPropertyName("platformProductIdMap")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? PlatformProductIdMap { get; set; }

    }



    public class IAPItemEntryItemIdentityType : StringEnum<IAPItemEntryItemIdentityType>
    {
        public static readonly IAPItemEntryItemIdentityType ITEMID
            = new IAPItemEntryItemIdentityType("ITEM_ID");

        public static readonly IAPItemEntryItemIdentityType ITEMSKU
            = new IAPItemEntryItemIdentityType("ITEM_SKU");


        public static implicit operator IAPItemEntryItemIdentityType(string value)
        {
            return NewValue(value);
        }

        public IAPItemEntryItemIdentityType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}