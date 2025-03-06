// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionhistory.Model
{
    public class ApimodelsGameSessionDetail : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        [JsonPropertyName("ended")]
        public bool? Ended { get; set; }

        [JsonPropertyName("histories")]
        public List<ApimodelsHistory>? Histories { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("last_data")]
        public ModelsGameSession? LastData { get; set; }

        [JsonPropertyName("match_pool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }

        [JsonPropertyName("sessionID")]
        public string? SessionID { get; set; }

        [JsonPropertyName("session_template")]
        public string? SessionTemplate { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }


}