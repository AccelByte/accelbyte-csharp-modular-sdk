// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsMatchMaking : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("event")]
        public string? Event { get; set; }

        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("joinable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Joinable { get; set; }

        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }

        [JsonPropertyName("matching_allies")]
        public List<ModelsMatchingAlly>? MatchingAllies { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("party_attributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartyId { get; set; }

        [JsonPropertyName("queued_at")]
        public long? QueuedAt { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("sub_game_mode")]
        public List<string>? SubGameMode { get; set; }

    }

    public class ModelsMatchMaking<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("event")]
        public string? Event { get; set; }

        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("joinable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Joinable { get; set; }

        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }

        [JsonPropertyName("matching_allies")]
        public List<ModelsMatchingAlly>? MatchingAllies { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("party_attributes")]
        public T1? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartyId { get; set; }

        [JsonPropertyName("queued_at")]
        public long? QueuedAt { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("sub_game_mode")]
        public List<string>? SubGameMode { get; set; }

    }

}