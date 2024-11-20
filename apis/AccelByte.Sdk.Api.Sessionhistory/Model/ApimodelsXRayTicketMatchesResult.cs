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
    public class ApimodelsXRayTicketMatchesResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ActualTimeToMatch")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ActualTimeToMatch { get; set; }

        [JsonPropertyName("CreatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("IsPivot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPivot { get; set; }

        [JsonPropertyName("Latencies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, long>? Latencies { get; set; }

        [JsonPropertyName("MatchPool")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MatchPool { get; set; }

        [JsonPropertyName("MatchedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? MatchedAt { get; set; }

        [JsonPropertyName("Namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("PartySessionID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartySessionID { get; set; }

        [JsonPropertyName("Players")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPlayerData>? Players { get; set; }

        [JsonPropertyName("ProposedProposal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsProposedProposal? ProposedProposal { get; set; }

        [JsonPropertyName("RegionPreference")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RegionPreference { get; set; }

        [JsonPropertyName("TicketAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? TicketAttributes { get; set; }

        [JsonPropertyName("TicketID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TicketID { get; set; }

        [JsonPropertyName("TimeToMatch")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? TimeToMatch { get; set; }

    }

    public class ApimodelsXRayTicketMatchesResult<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ActualTimeToMatch")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ActualTimeToMatch { get; set; }

        [JsonPropertyName("CreatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("IsPivot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPivot { get; set; }

        [JsonPropertyName("Latencies")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, long>? Latencies { get; set; }

        [JsonPropertyName("MatchPool")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MatchPool { get; set; }

        [JsonPropertyName("MatchedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? MatchedAt { get; set; }

        [JsonPropertyName("Namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("PartySessionID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PartySessionID { get; set; }

        [JsonPropertyName("Players")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<ModelsPlayerData>? Players { get; set; }

        [JsonPropertyName("ProposedProposal")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsProposedProposal? ProposedProposal { get; set; }

        [JsonPropertyName("RegionPreference")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RegionPreference { get; set; }

        [JsonPropertyName("TicketAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? TicketAttributes { get; set; }

        [JsonPropertyName("TicketID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TicketID { get; set; }

        [JsonPropertyName("TimeToMatch")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double? TimeToMatch { get; set; }

    }

}