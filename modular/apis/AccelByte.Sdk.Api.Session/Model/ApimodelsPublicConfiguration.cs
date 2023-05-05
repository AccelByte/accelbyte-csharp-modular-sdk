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
    public class ApimodelsPublicConfiguration : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("requestedRegions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("textChat")]
        public bool? TextChat { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }


}