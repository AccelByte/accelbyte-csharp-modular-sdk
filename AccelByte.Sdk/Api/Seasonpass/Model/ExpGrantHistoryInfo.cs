// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ExpGrantHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("grantExp")]
        public long? GrantExp { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("seasonId")]
        public string? SeasonId { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ExpGrantHistoryInfoSource? Source { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class ExpGrantHistoryInfoSource : StringEnum<ExpGrantHistoryInfoSource>
    {
        public static readonly ExpGrantHistoryInfoSource PAIDFOR
            = new ExpGrantHistoryInfoSource("PAID_FOR");

        public static readonly ExpGrantHistoryInfoSource SWEAT
            = new ExpGrantHistoryInfoSource("SWEAT");


        public static implicit operator ExpGrantHistoryInfoSource(string value)
        {
            return NewValue(value);
        }

        public ExpGrantHistoryInfoSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}