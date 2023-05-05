// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class HandlersGetUsersPresenceResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("away")]
        public int? Away { get; set; }

        [JsonPropertyName("busy")]
        public int? Busy { get; set; }

        [JsonPropertyName("data")]
        public List<HandlersUserPresence>? Data { get; set; }

        [JsonPropertyName("invisible")]
        public int? Invisible { get; set; }

        [JsonPropertyName("offline")]
        public int? Offline { get; set; }

        [JsonPropertyName("online")]
        public int? Online { get; set; }

    }


}