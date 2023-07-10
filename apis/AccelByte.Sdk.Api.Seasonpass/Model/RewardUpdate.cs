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

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class RewardUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RewardCurrency? Currency { get; set; }

        [JsonPropertyName("image")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Image? Image { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("nullFields")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? NullFields { get; set; }

        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Quantity { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RewardUpdateType? Type { get; set; }

    }



    public class RewardUpdateType : StringEnum<RewardUpdateType>
    {
        public static readonly RewardUpdateType CURRENCY
            = new RewardUpdateType("CURRENCY");

        public static readonly RewardUpdateType ITEM
            = new RewardUpdateType("ITEM");


        public static implicit operator RewardUpdateType(string value)
        {
            return NewValue(value);
        }

        public RewardUpdateType(string enumValue)
            : base(enumValue)
        {

        }
    }
}