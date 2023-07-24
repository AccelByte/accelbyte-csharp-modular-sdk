// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowInviteNonConnectedUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AllowInviteNonConnectedUser { get; set; }

        [JsonPropertyName("allowJoinPartyDuringMatchmaking")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AllowJoinPartyDuringMatchmaking { get; set; }

        [JsonPropertyName("autoKickOnDisconnect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AutoKickOnDisconnect { get; set; }

        [JsonPropertyName("autoKickOnDisconnectDelay")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? AutoKickOnDisconnectDelay { get; set; }

        [JsonPropertyName("cancelTicketOnDisconnect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? CancelTicketOnDisconnect { get; set; }

        [JsonPropertyName("chatRateLimitBurst")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ChatRateLimitBurst { get; set; }

        [JsonPropertyName("chatRateLimitDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? ChatRateLimitDuration { get; set; }

        [JsonPropertyName("concurrentUsersLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ConcurrentUsersLimit { get; set; }

        [JsonPropertyName("disableInvitationOnJoinParty")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DisableInvitationOnJoinParty { get; set; }

        [JsonPropertyName("enableChat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableChat { get; set; }

        [JsonPropertyName("entitlementCheck")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EntitlementCheck { get; set; }

        [JsonPropertyName("entitlementItemID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EntitlementItemID { get; set; }

        [JsonPropertyName("generalRateLimitBurst")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? GeneralRateLimitBurst { get; set; }

        [JsonPropertyName("generalRateLimitDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? GeneralRateLimitDuration { get; set; }

        [JsonPropertyName("keepPresenceActivityOnDisconnect")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? KeepPresenceActivityOnDisconnect { get; set; }

        [JsonPropertyName("maxDSWaitTime")]
        public long? MaxDSWaitTime { get; set; }

        [JsonPropertyName("maxFriendsLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxFriendsLimit { get; set; }

        [JsonPropertyName("maxPartyMember")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxPartyMember { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("profanityFilter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ProfanityFilter { get; set; }

        [JsonPropertyName("readyConsentTimeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? ReadyConsentTimeout { get; set; }

        [JsonPropertyName("unregisterDelay")]
        public long? UnregisterDelay { get; set; }

    }


}