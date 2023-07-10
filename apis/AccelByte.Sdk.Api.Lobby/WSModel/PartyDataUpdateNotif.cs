// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("partyDataUpdateNotif")]
    public class PartyDataUpdateNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("customAttributes")]
        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }

        [AwesomeProperty("invitees")]
        [JsonPropertyName("invitees")]
        public List<string>? Invitees { get; set; }

        [AwesomeProperty("leader")]
        [JsonPropertyName("leader")]
        public string? Leader { get; set; }

        [AwesomeProperty("members")]
        [JsonPropertyName("members")]
        public List<string>? Members { get; set; }

        [AwesomeProperty("namespace")]
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [AwesomeProperty("partyId")]
        [JsonPropertyName("partyId")]
        public string? PartyId { get; set; }

        [AwesomeProperty("updatedAt")]
        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }

    }
}