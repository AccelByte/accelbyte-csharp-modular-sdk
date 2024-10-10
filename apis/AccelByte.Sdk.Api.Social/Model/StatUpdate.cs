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
    public class StatUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cycleIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? CycleIds { get; set; }

        [JsonPropertyName("defaultValue")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? DefaultValue { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("globalAggregationMethod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public StatUpdateGlobalAggregationMethod? GlobalAggregationMethod { get; set; }

        [JsonPropertyName("ignoreAdditionalDataOnValueRejected")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IgnoreAdditionalDataOnValueRejected { get; set; }

        [JsonPropertyName("isPublic")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPublic { get; set; }

        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("visibility")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public StatUpdateVisibility? Visibility { get; set; }

    }



    public class StatUpdateGlobalAggregationMethod : StringEnum<StatUpdateGlobalAggregationMethod>
    {
        public static readonly StatUpdateGlobalAggregationMethod LAST
            = new StatUpdateGlobalAggregationMethod("LAST");

        public static readonly StatUpdateGlobalAggregationMethod MAX
            = new StatUpdateGlobalAggregationMethod("MAX");

        public static readonly StatUpdateGlobalAggregationMethod MIN
            = new StatUpdateGlobalAggregationMethod("MIN");

        public static readonly StatUpdateGlobalAggregationMethod TOTAL
            = new StatUpdateGlobalAggregationMethod("TOTAL");


        public static implicit operator StatUpdateGlobalAggregationMethod(string value)
        {
            return NewValue(value);
        }

        public StatUpdateGlobalAggregationMethod(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class StatUpdateVisibility : StringEnum<StatUpdateVisibility>
    {
        public static readonly StatUpdateVisibility SERVERONLY
            = new StatUpdateVisibility("SERVERONLY");

        public static readonly StatUpdateVisibility SHOWALL
            = new StatUpdateVisibility("SHOWALL");


        public static implicit operator StatUpdateVisibility(string value)
        {
            return NewValue(value);
        }

        public StatUpdateVisibility(string enumValue)
            : base(enumValue)
        {

        }
    }
}