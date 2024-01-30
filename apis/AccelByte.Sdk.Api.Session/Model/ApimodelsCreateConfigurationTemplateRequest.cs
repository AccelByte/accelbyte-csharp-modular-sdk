// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsCreateConfigurationTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("NativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("PSNBaseUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseUrl { get; set; }

        [JsonPropertyName("attributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("disableCodeGeneration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableCodeGeneration { get; set; }

        [JsonPropertyName("dsManualSetReady")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DsManualSetReady { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("enableSecret")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableSecret { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("immutableStorage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ImmutableStorage { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSessions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSessions { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }

    public class ApimodelsCreateConfigurationTemplateRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("NativeSessionSetting")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsNativeSessionSetting? NativeSessionSetting { get; set; }

        [JsonPropertyName("PSNBaseUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PSNBaseUrl { get; set; }

        [JsonPropertyName("attributes")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Attributes { get; set; }

        [JsonPropertyName("autoJoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoJoin { get; set; }

        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("disableCodeGeneration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableCodeGeneration { get; set; }

        [JsonPropertyName("dsManualSetReady")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DsManualSetReady { get; set; }

        [JsonPropertyName("dsSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DsSource { get; set; }

        [JsonPropertyName("enableSecret")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableSecret { get; set; }

        [JsonPropertyName("fallbackClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? FallbackClaimKeys { get; set; }

        [JsonPropertyName("immutableStorage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ImmutableStorage { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("leaderElectionGracePeriod")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? LeaderElectionGracePeriod { get; set; }

        [JsonPropertyName("manualRejoin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ManualRejoin { get; set; }

        [JsonPropertyName("maxActiveSessions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxActiveSessions { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("preferredClaimKeys")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? PreferredClaimKeys { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("tieTeamsSessionLifetime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TieTeamsSessionLifetime { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }

}