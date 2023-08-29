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
    [AwesomeModel("requestFriendsNotif")]
    public class RequestFriendsNotif : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("friendId")]
        [JsonPropertyName("friendId")]
        public string? FriendId { get; set; }

    }
}