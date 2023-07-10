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
    public class CampaignUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("items")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RedeemableItem>? Items { get; set; }

        [JsonPropertyName("maxRedeemCountPerCampaignPerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRedeemCountPerCampaignPerUser { get; set; }

        [JsonPropertyName("maxRedeemCountPerCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRedeemCountPerCode { get; set; }

        [JsonPropertyName("maxRedeemCountPerCodePerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxRedeemCountPerCodePerUser { get; set; }

        [JsonPropertyName("maxSaleCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxSaleCount { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("redeemEnd")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RedeemEnd { get; set; }

        [JsonPropertyName("redeemStart")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RedeemStart { get; set; }

        [JsonPropertyName("redeemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CampaignUpdateRedeemType? RedeemType { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CampaignUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }



    public class CampaignUpdateRedeemType : StringEnum<CampaignUpdateRedeemType>
    {
        public static readonly CampaignUpdateRedeemType ITEM
            = new CampaignUpdateRedeemType("ITEM");


        public static implicit operator CampaignUpdateRedeemType(string value)
        {
            return NewValue(value);
        }

        public CampaignUpdateRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class CampaignUpdateStatus : StringEnum<CampaignUpdateStatus>
    {
        public static readonly CampaignUpdateStatus ACTIVE
            = new CampaignUpdateStatus("ACTIVE");

        public static readonly CampaignUpdateStatus INACTIVE
            = new CampaignUpdateStatus("INACTIVE");


        public static implicit operator CampaignUpdateStatus(string value)
        {
            return NewValue(value);
        }

        public CampaignUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}