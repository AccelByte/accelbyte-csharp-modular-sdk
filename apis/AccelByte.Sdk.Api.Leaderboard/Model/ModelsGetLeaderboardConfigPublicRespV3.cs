// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsGetLeaderboardConfigPublicRespV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allTime")]
        public bool? AllTime { get; set; }

        [JsonPropertyName("cycleIds")]
        public List<string>? CycleIds { get; set; }

        [JsonPropertyName("iconURL")]
        public string? IconURL { get; set; }

        [JsonPropertyName("leaderboardCode")]
        public string? LeaderboardCode { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }

    }


}