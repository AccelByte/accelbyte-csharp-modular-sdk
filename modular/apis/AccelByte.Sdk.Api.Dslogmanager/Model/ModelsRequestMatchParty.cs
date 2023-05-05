// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dslogmanager.Model
{
    public class ModelsRequestMatchParty : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("party_attributes")]
        public Dictionary<string, object>? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }

        [JsonPropertyName("party_members")]
        public List<ModelsRequestMatchMember>? PartyMembers { get; set; }

    }

    public class ModelsRequestMatchParty<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("party_attributes")]
        public T1? PartyAttributes { get; set; }

        [JsonPropertyName("party_id")]
        public string? PartyId { get; set; }

        [JsonPropertyName("party_members")]
        public List<ModelsRequestMatchMember>? PartyMembers { get; set; }

    }

}