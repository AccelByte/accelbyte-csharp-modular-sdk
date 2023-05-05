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
    public class CampaignCreate : AccelByte.Sdk.Core.Model
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
        public CampaignCreateRedeemType? RedeemType { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CampaignCreateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CampaignCreateType? Type { get; set; }

    }



    public class CampaignCreateRedeemType : StringEnum<CampaignCreateRedeemType>
    {
        public static readonly CampaignCreateRedeemType ITEM
            = new CampaignCreateRedeemType("ITEM");


        public static implicit operator CampaignCreateRedeemType(string value)
        {
            return NewValue(value);
        }

        public CampaignCreateRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignCreateStatus : StringEnum<CampaignCreateStatus>
    {
        public static readonly CampaignCreateStatus ACTIVE
            = new CampaignCreateStatus("ACTIVE");

        public static readonly CampaignCreateStatus INACTIVE
            = new CampaignCreateStatus("INACTIVE");


        public static implicit operator CampaignCreateStatus(string value)
        {
            return NewValue(value);
        }

        public CampaignCreateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignCreateType : StringEnum<CampaignCreateType>
    {
        public static readonly CampaignCreateType REDEMPTION
            = new CampaignCreateType("REDEMPTION");


        public static implicit operator CampaignCreateType(string value)
        {
            return NewValue(value);
        }

        public CampaignCreateType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}