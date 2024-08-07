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
    public class AvailablePredicate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableComparisons")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<AvailableComparison>? AvailableComparisons { get; set; }

        [JsonPropertyName("predicateType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AvailablePredicatePredicateType? PredicateType { get; set; }

        [JsonPropertyName("showAnyOf")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ShowAnyOf { get; set; }

        [JsonPropertyName("valueType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AvailablePredicateValueType? ValueType { get; set; }

    }



    public class AvailablePredicatePredicateType : StringEnum<AvailablePredicatePredicateType>
    {
        public static readonly AvailablePredicatePredicateType EntitlementPredicate
            = new AvailablePredicatePredicateType("EntitlementPredicate");

        public static readonly AvailablePredicatePredicateType SeasonPassPredicate
            = new AvailablePredicatePredicateType("SeasonPassPredicate");

        public static readonly AvailablePredicatePredicateType SeasonTierPredicate
            = new AvailablePredicatePredicateType("SeasonTierPredicate");

        public static readonly AvailablePredicatePredicateType StatisticCodePredicate
            = new AvailablePredicatePredicateType("StatisticCodePredicate");


        public static implicit operator AvailablePredicatePredicateType(string value)
        {
            return NewValue(value);
        }

        public AvailablePredicatePredicateType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AvailablePredicateValueType : StringEnum<AvailablePredicateValueType>
    {
        public static readonly AvailablePredicateValueType List
            = new AvailablePredicateValueType("List");

        public static readonly AvailablePredicateValueType Number
            = new AvailablePredicateValueType("Number");

        public static readonly AvailablePredicateValueType String
            = new AvailablePredicateValueType("String");


        public static implicit operator AvailablePredicateValueType(string value)
        {
            return NewValue(value);
        }

        public AvailablePredicateValueType(string enumValue)
            : base(enumValue)
        {

        }
    }
}