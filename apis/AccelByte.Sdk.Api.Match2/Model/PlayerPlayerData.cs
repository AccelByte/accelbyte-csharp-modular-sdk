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
    public class PlayerPlayerData : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Attributes")]
        public Dictionary<string, object>? Attributes { get; set; }

        [JsonPropertyName("PartyID")]
        public string? PartyID { get; set; }

        [JsonPropertyName("PlatformID")]
        public string? PlatformID { get; set; }

        [JsonPropertyName("PlayerID")]
        public string? PlayerID { get; set; }

    }

    public class PlayerPlayerData<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Attributes")]
        public T1? Attributes { get; set; }

        [JsonPropertyName("PartyID")]
        public string? PartyID { get; set; }

        [JsonPropertyName("PlatformID")]
        public string? PlatformID { get; set; }

        [JsonPropertyName("PlayerID")]
        public string? PlayerID { get; set; }

    }

}