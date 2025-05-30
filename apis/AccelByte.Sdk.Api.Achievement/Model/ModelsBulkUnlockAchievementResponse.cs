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
    public class ModelsBulkUnlockAchievementResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("achievementCode")]
        public string? AchievementCode { get; set; }

        [JsonPropertyName("errorDetail")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsErrorDetails? ErrorDetail { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

    }


}