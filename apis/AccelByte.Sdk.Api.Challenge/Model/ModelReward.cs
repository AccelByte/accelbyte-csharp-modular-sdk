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

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelReward : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }

        [JsonPropertyName("qty")]
        public float? Qty { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public ModelRewardType? Type { get; set; }

    }



    public class ModelRewardType : StringEnum<ModelRewardType>
    {
        public static readonly ModelRewardType ENTITLEMENT
            = new ModelRewardType("ENTITLEMENT");

        public static readonly ModelRewardType STATISTIC
            = new ModelRewardType("STATISTIC");


        public static implicit operator ModelRewardType(string value)
        {
            return NewValue(value);
        }

        public ModelRewardType(string enumValue)
            : base(enumValue)
        {

        }
    }
}