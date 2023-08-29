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
    [AwesomeModel("unblockPlayerResponse")]
    public class UnblockPlayerResponse : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("code")]
        [JsonPropertyName("code")]
        public long? Code { get; set; }

        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [AwesomeProperty("namespace")]
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [AwesomeProperty("unblockedUserId")]
        [JsonPropertyName("unblockedUserId")]
        public string? UnblockedUserId { get; set; }

    }
}