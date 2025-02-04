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

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("capCycleOverride")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CapCycleOverride { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("cycleIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? CycleIds { get; set; }

        [JsonPropertyName("cycleOverrides")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<CycleOverride>? CycleOverrides { get; set; }

        [JsonPropertyName("defaultValue")]
        public double? DefaultValue { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("globalAggregationMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public StatInfoGlobalAggregationMethod? GlobalAggregationMethod { get; set; }

        [JsonPropertyName("ignoreAdditionalDataOnValueRejected")]
        public bool? IgnoreAdditionalDataOnValueRejected { get; set; }

        [JsonPropertyName("incrementOnly")]
        public bool? IncrementOnly { get; set; }

        [JsonPropertyName("isPublic")]
        public bool? IsPublic { get; set; }

        [JsonPropertyName("maximum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Maximum { get; set; }

        [JsonPropertyName("minimum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? Minimum { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("setAsGlobal")]
        public bool? SetAsGlobal { get; set; }

        [JsonPropertyName("setBy")]
        [JsonStringEnum]
        public StatInfoSetBy? SetBy { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public StatInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("visibility")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public StatInfoVisibility? Visibility { get; set; }

    }



    public class StatInfoGlobalAggregationMethod : StringEnum<StatInfoGlobalAggregationMethod>
    {
        public static readonly StatInfoGlobalAggregationMethod LAST
            = new StatInfoGlobalAggregationMethod("LAST");

        public static readonly StatInfoGlobalAggregationMethod MAX
            = new StatInfoGlobalAggregationMethod("MAX");

        public static readonly StatInfoGlobalAggregationMethod MIN
            = new StatInfoGlobalAggregationMethod("MIN");

        public static readonly StatInfoGlobalAggregationMethod TOTAL
            = new StatInfoGlobalAggregationMethod("TOTAL");


        public static implicit operator StatInfoGlobalAggregationMethod(string value)
        {
            return NewValue(value);
        }

        public StatInfoGlobalAggregationMethod(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class StatInfoSetBy : StringEnum<StatInfoSetBy>
    {
        public static readonly StatInfoSetBy CLIENT
            = new StatInfoSetBy("CLIENT");

        public static readonly StatInfoSetBy SERVER
            = new StatInfoSetBy("SERVER");


        public static implicit operator StatInfoSetBy(string value)
        {
            return NewValue(value);
        }

        public StatInfoSetBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class StatInfoStatus : StringEnum<StatInfoStatus>
    {
        public static readonly StatInfoStatus INIT
            = new StatInfoStatus("INIT");

        public static readonly StatInfoStatus TIED
            = new StatInfoStatus("TIED");


        public static implicit operator StatInfoStatus(string value)
        {
            return NewValue(value);
        }

        public StatInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class StatInfoVisibility : StringEnum<StatInfoVisibility>
    {
        public static readonly StatInfoVisibility SERVERONLY
            = new StatInfoVisibility("SERVERONLY");

        public static readonly StatInfoVisibility SHOWALL
            = new StatInfoVisibility("SHOWALL");


        public static implicit operator StatInfoVisibility(string value)
        {
            return NewValue(value);
        }

        public StatInfoVisibility(string enumValue)
            : base(enumValue)
        {

        }
    }
}