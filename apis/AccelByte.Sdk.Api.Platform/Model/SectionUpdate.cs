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
    public class SectionUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Active { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("fixedPeriodRotationConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FixedPeriodRotationConfig? FixedPeriodRotationConfig { get; set; }

        [JsonPropertyName("items")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SectionItem>? Items { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rotationType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SectionUpdateRotationType? RotationType { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("viewId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ViewId { get; set; }

    }

    public class SectionUpdate<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Active { get; set; }

        [JsonPropertyName("displayOrder")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("ext")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Ext { get; set; }

        [JsonPropertyName("fixedPeriodRotationConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public FixedPeriodRotationConfig? FixedPeriodRotationConfig { get; set; }

        [JsonPropertyName("items")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<SectionItem>? Items { get; set; }

        [JsonPropertyName("localizations")]
        public Dictionary<string, Localization>? Localizations { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("rotationType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public SectionUpdateRotationType? RotationType { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("viewId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ViewId { get; set; }

    }


    public class SectionUpdateRotationType : StringEnum<SectionUpdateRotationType>
    {
        public static readonly SectionUpdateRotationType CUSTOM
            = new SectionUpdateRotationType("CUSTOM");

        public static readonly SectionUpdateRotationType FIXEDPERIOD
            = new SectionUpdateRotationType("FIXED_PERIOD");

        public static readonly SectionUpdateRotationType NONE
            = new SectionUpdateRotationType("NONE");


        public static implicit operator SectionUpdateRotationType(string value)
        {
            return NewValue(value);
        }

        public SectionUpdateRotationType(string enumValue)
            : base(enumValue)
        {

        }
    }
}