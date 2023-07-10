// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsCountActiveSessionResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_game")]
        public long? CustomGame { get; set; }

        [JsonPropertyName("matchmaking_game")]
        public long? MatchmakingGame { get; set; }

        [JsonPropertyName("total")]
        public long? Total { get; set; }

    }


}