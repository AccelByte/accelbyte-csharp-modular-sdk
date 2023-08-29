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
    [AwesomeModel("setReadyConsentNotif")]
    public class SetReadyConsentNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("matchId")]
        [JsonPropertyName("matchId")]
        public string? MatchId { get; set; }
        
        [AwesomeProperty("userId")]
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}