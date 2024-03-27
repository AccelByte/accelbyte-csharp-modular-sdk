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
    public class ModelsSessionConfiguration : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientVersion")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("Deployment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Deployment { get; set; }

        [JsonPropertyName("InactiveTimeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("InviteTimeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("Joinability")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Joinability { get; set; }

        [JsonPropertyName("MaxPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("MinPlayers")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("Persistent")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Persistent { get; set; }

        [JsonPropertyName("RequestedRegions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("TextChat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TextChat { get; set; }

        [JsonPropertyName("Type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }

    }


}