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
    public class SeasonSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("end")]
        public DateTime? End { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("passCodes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PassCodes { get; set; }

        [JsonPropertyName("previous")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public SeasonSummary? Previous { get; set; }

        [JsonPropertyName("publishedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("start")]
        public DateTime? Start { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public SeasonSummaryStatus? Status { get; set; }

    }



    public class SeasonSummaryStatus : StringEnum<SeasonSummaryStatus>
    {
        public static readonly SeasonSummaryStatus DRAFT
            = new SeasonSummaryStatus("DRAFT");

        public static readonly SeasonSummaryStatus PUBLISHED
            = new SeasonSummaryStatus("PUBLISHED");

        public static readonly SeasonSummaryStatus RETIRED
            = new SeasonSummaryStatus("RETIRED");


        public static implicit operator SeasonSummaryStatus(string value)
        {
            return NewValue(value);
        }

        public SeasonSummaryStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}