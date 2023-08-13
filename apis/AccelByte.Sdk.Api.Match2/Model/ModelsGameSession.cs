// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Match2.Model
{
    public class ModelsGameSession : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DSInformation")]
        public ModelsDSInformation? DSInformation { get; set; }

        [JsonPropertyName("GameMode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("JoinType")]
        public string? JoinType { get; set; }

        [JsonPropertyName("Members")]
        public List<ModelsUser>? Members { get; set; }

        [JsonPropertyName("attributes")]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("configuration")]
        public ModelsConfiguration? Configuration { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("leaderID")]
        public string? LeaderID { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("teams")]
        public List<MatchmakerTeam>? Teams { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

    }

    public class ModelsGameSession<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DSInformation")]
        public ModelsDSInformation? DSInformation { get; set; }

        [JsonPropertyName("GameMode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("JoinType")]
        public string? JoinType { get; set; }

        [JsonPropertyName("Members")]
        public List<ModelsUser>? Members { get; set; }

        [JsonPropertyName("attributes")]
        public T1? Attributes { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("configuration")]
        public ModelsConfiguration? Configuration { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("leaderID")]
        public string? LeaderID { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("teams")]
        public List<MatchmakerTeam>? Teams { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("version")]
        public int? Version { get; set; }

    }

}