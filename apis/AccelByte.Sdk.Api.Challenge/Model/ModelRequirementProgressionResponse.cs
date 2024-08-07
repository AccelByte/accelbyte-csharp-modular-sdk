// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Challenge.Model
{
    public class ModelRequirementProgressionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("completedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CompletedAt { get; set; }

        [JsonPropertyName("currentValue")]
        public double? CurrentValue { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("matcher")]
        public string? Matcher { get; set; }

        [JsonPropertyName("parameterName")]
        public string? ParameterName { get; set; }

        [JsonPropertyName("parameterType")]
        public string? ParameterType { get; set; }

        [JsonPropertyName("statCycleId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatCycleId { get; set; }

        [JsonPropertyName("targetValue")]
        public double? TargetValue { get; set; }

    }


}