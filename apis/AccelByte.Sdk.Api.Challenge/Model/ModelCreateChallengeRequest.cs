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
    public class ModelCreateChallengeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("activeGoalsPerRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ActiveGoalsPerRotation { get; set; }

        [JsonPropertyName("assignmentRule")]
        [JsonStringEnum]
        public ModelCreateChallengeRequestAssignmentRule? AssignmentRule { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("endAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? EndAfter { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("goalsVisibility")]
        [JsonStringEnum]
        public ModelCreateChallengeRequestGoalsVisibility? GoalsVisibility { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("randomizedPerRotation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? RandomizedPerRotation { get; set; }

        [JsonPropertyName("repeatAfter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RepeatAfter { get; set; }

        [JsonPropertyName("resetConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelResetConfig? ResetConfig { get; set; }

        [JsonPropertyName("rotation")]
        [JsonStringEnum]
        public ModelCreateChallengeRequestRotation? Rotation { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

    }



    public class ModelCreateChallengeRequestAssignmentRule : StringEnum<ModelCreateChallengeRequestAssignmentRule>
    {
        public static readonly ModelCreateChallengeRequestAssignmentRule FIXED
            = new ModelCreateChallengeRequestAssignmentRule("FIXED");

        public static readonly ModelCreateChallengeRequestAssignmentRule RANDOMIZED
            = new ModelCreateChallengeRequestAssignmentRule("RANDOMIZED");

        public static readonly ModelCreateChallengeRequestAssignmentRule UNSCHEDULED
            = new ModelCreateChallengeRequestAssignmentRule("UNSCHEDULED");


        public static implicit operator ModelCreateChallengeRequestAssignmentRule(string value)
        {
            return NewValue(value);
        }

        public ModelCreateChallengeRequestAssignmentRule(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelCreateChallengeRequestGoalsVisibility : StringEnum<ModelCreateChallengeRequestGoalsVisibility>
    {
        public static readonly ModelCreateChallengeRequestGoalsVisibility PERIODONLY
            = new ModelCreateChallengeRequestGoalsVisibility("PERIODONLY");

        public static readonly ModelCreateChallengeRequestGoalsVisibility SHOWALL
            = new ModelCreateChallengeRequestGoalsVisibility("SHOWALL");


        public static implicit operator ModelCreateChallengeRequestGoalsVisibility(string value)
        {
            return NewValue(value);
        }

        public ModelCreateChallengeRequestGoalsVisibility(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelCreateChallengeRequestRotation : StringEnum<ModelCreateChallengeRequestRotation>
    {
        public static readonly ModelCreateChallengeRequestRotation DAILY
            = new ModelCreateChallengeRequestRotation("DAILY");

        public static readonly ModelCreateChallengeRequestRotation MONTHLY
            = new ModelCreateChallengeRequestRotation("MONTHLY");

        public static readonly ModelCreateChallengeRequestRotation NONE
            = new ModelCreateChallengeRequestRotation("NONE");

        public static readonly ModelCreateChallengeRequestRotation WEEKLY
            = new ModelCreateChallengeRequestRotation("WEEKLY");


        public static implicit operator ModelCreateChallengeRequestRotation(string value)
        {
            return NewValue(value);
        }

        public ModelCreateChallengeRequestRotation(string enumValue)
            : base(enumValue)
        {

        }
    }
}