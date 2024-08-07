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
    public class ApimodelsXRayTicketResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("elapsedTime")]
        public double? ElapsedTime { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isBackfill")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsBackfill { get; set; }

        [JsonPropertyName("isPivot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPivot { get; set; }

        [JsonPropertyName("matchpool")]
        public string? Matchpool { get; set; }

        [JsonPropertyName("memberAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? MemberAttributes { get; set; }

        [JsonPropertyName("podName")]
        public string? PodName { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("tickId")]
        public string? TickId { get; set; }

        [JsonPropertyName("ticketId")]
        public string? TicketId { get; set; }

        [JsonPropertyName("ticketStatus")]
        public string? TicketStatus { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("totalPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPlayers { get; set; }

    }

    public class ApimodelsXRayTicketResult<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("elapsedTime")]
        public double? ElapsedTime { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("isBackfill")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsBackfill { get; set; }

        [JsonPropertyName("isPivot")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsPivot { get; set; }

        [JsonPropertyName("matchpool")]
        public string? Matchpool { get; set; }

        [JsonPropertyName("memberAttributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? MemberAttributes { get; set; }

        [JsonPropertyName("podName")]
        public string? PodName { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("tickId")]
        public string? TickId { get; set; }

        [JsonPropertyName("ticketId")]
        public string? TicketId { get; set; }

        [JsonPropertyName("ticketStatus")]
        public string? TicketStatus { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("totalPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalPlayers { get; set; }

    }

}