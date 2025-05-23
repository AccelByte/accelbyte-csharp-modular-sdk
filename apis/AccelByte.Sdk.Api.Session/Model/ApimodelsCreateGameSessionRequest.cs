// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsCreateGameSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppName { get; set; }

        [JsonPropertyName("attributes")]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("configurationName")]
        public string? ConfigurationName { get; set; }

        [JsonPropertyName("customURLGRPC")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CustomURLGRPC { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("serverName")]
        public string? ServerName { get; set; }

        [JsonPropertyName("storage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ApimodelsSessionStorageRequest? Storage { get; set; }

        [JsonPropertyName("teams")]
        public List<ModelsTeam>? Teams { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsCreateGameSessionRequestTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("ticketIDs")]
        public List<string>? TicketIDs { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }

    public class ApimodelsCreateGameSessionRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AppName { get; set; }

        [JsonPropertyName("attributes")]
        public T1? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("backfillTicketID")]
        public string? BackfillTicketID { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("configurationName")]
        public string? ConfigurationName { get; set; }

        [JsonPropertyName("customURLGRPC")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CustomURLGRPC { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("matchPool")]
        public string? MatchPool { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("serverName")]
        public string? ServerName { get; set; }

        [JsonPropertyName("storage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ApimodelsSessionStorageRequest? Storage { get; set; }

        [JsonPropertyName("teams")]
        public List<ModelsTeam>? Teams { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("textChatMode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ApimodelsCreateGameSessionRequestTextChatMode? TextChatMode { get; set; }

        [JsonPropertyName("ticketIDs")]
        public List<string>? TicketIDs { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }


    public class ApimodelsCreateGameSessionRequestTextChatMode : StringEnum<ApimodelsCreateGameSessionRequestTextChatMode>
    {
        public static readonly ApimodelsCreateGameSessionRequestTextChatMode GAME
            = new ApimodelsCreateGameSessionRequestTextChatMode("GAME");

        public static readonly ApimodelsCreateGameSessionRequestTextChatMode NONE
            = new ApimodelsCreateGameSessionRequestTextChatMode("NONE");

        public static readonly ApimodelsCreateGameSessionRequestTextChatMode TEAM
            = new ApimodelsCreateGameSessionRequestTextChatMode("TEAM");


        public static implicit operator ApimodelsCreateGameSessionRequestTextChatMode(string value)
        {
            return NewValue(value);
        }

        public ApimodelsCreateGameSessionRequestTextChatMode(string enumValue)
            : base(enumValue)
        {

        }
    }
}