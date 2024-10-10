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
    public class ModelUserReward : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("challengeCode")]
        public string? ChallengeCode { get; set; }

        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("goalCode")]
        public string? GoalCode { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemName")]
        public string? ItemName { get; set; }

        [JsonPropertyName("qty")]
        public float? Qty { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public ModelUserRewardStatus? Status { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public ModelUserRewardType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class ModelUserRewardStatus : StringEnum<ModelUserRewardStatus>
    {
        public static readonly ModelUserRewardStatus CLAIMED
            = new ModelUserRewardStatus("CLAIMED");

        public static readonly ModelUserRewardStatus UNCLAIMED
            = new ModelUserRewardStatus("UNCLAIMED");


        public static implicit operator ModelUserRewardStatus(string value)
        {
            return NewValue(value);
        }

        public ModelUserRewardStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelUserRewardType : StringEnum<ModelUserRewardType>
    {
        public static readonly ModelUserRewardType ENTITLEMENT
            = new ModelUserRewardType("ENTITLEMENT");

        public static readonly ModelUserRewardType STATISTIC
            = new ModelUserRewardType("STATISTIC");


        public static implicit operator ModelUserRewardType(string value)
        {
            return NewValue(value);
        }

        public ModelUserRewardType(string enumValue)
            : base(enumValue)
        {

        }
    }
}