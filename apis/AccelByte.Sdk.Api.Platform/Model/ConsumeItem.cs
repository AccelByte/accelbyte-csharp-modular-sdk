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
    public class ConsumeItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extItemDefId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtItemDefId { get; set; }

        [JsonPropertyName("extItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtItemId { get; set; }

        [JsonPropertyName("itemIdentity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemIdentity { get; set; }

        [JsonPropertyName("itemIdentityType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ConsumeItemItemIdentityType? ItemIdentityType { get; set; }

    }



    public class ConsumeItemItemIdentityType : StringEnum<ConsumeItemItemIdentityType>
    {
        public static readonly ConsumeItemItemIdentityType ITEMID
            = new ConsumeItemItemIdentityType("ITEM_ID");

        public static readonly ConsumeItemItemIdentityType ITEMSKU
            = new ConsumeItemItemIdentityType("ITEM_SKU");


        public static implicit operator ConsumeItemItemIdentityType(string value)
        {
            return NewValue(value);
        }

        public ConsumeItemItemIdentityType(string enumValue)
            : base(enumValue)
        {

        }
    }
}