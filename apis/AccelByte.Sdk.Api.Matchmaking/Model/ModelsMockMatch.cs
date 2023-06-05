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
    public class ModelsMockMatch : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("is_mock")]
        public string? IsMock { get; set; }

        [JsonPropertyName("joinable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Joinable { get; set; }

        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }

        [JsonPropertyName("matching_allies")]
        public List<ModelsMatchingAlly>? MatchingAllies { get; set; }

        [JsonPropertyName("mmr_distance")]
        public int? MmrDistance { get; set; }

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

        [JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

        [JsonPropertyName("time_to_match_seconds")]
        public long? TimeToMatchSeconds { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class ModelsMockMatch<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }

        [JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("is_mock")]
        public string? IsMock { get; set; }

        [JsonPropertyName("joinable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Joinable { get; set; }

        [JsonPropertyName("match_id")]
        public string? MatchId { get; set; }

        [JsonPropertyName("matching_allies")]
        public List<ModelsMatchingAlly>? MatchingAllies { get; set; }

        [JsonPropertyName("mmr_distance")]
        public int? MmrDistance { get; set; }

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

        [JsonPropertyName("ticket_id")]
        public string? TicketId { get; set; }

        [JsonPropertyName("time_to_match_seconds")]
        public long? TimeToMatchSeconds { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

    }

}