// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsGetMockMatchesResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("largest_mmr_distance")]
        public int? LargestMmrDistance { get; set; }

        [JsonPropertyName("longest_time_to_match_seconds")]
        public long? LongestTimeToMatchSeconds { get; set; }

        [JsonPropertyName("matches")]
        public List<ModelsMockMatch>? Matches { get; set; }

    }


}