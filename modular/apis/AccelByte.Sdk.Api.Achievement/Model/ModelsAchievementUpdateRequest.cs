// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Achievement.Model
{
    public class ModelsAchievementUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("defaultLanguage")]
        public string? DefaultLanguage { get; set; }

        [JsonPropertyName("description")]
        public Dictionary<string, string>? Description { get; set; }

        [JsonPropertyName("global")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Global { get; set; }

        [JsonPropertyName("goalValue")]
        public double? GoalValue { get; set; }

        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        [JsonPropertyName("incremental")]
        public bool? Incremental { get; set; }

        [JsonPropertyName("lockedIcons")]
        public List<ModelsIcon>? LockedIcons { get; set; }

        [JsonPropertyName("name")]
        public Dictionary<string, string>? Name { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("unlockedIcons")]
        public List<ModelsIcon>? UnlockedIcons { get; set; }

    }


}