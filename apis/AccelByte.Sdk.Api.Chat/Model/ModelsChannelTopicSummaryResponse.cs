// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsChannelTopicSummaryResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("totalChannel")]
        public int? TotalChannel { get; set; }

        [JsonPropertyName("totalShard")]
        public int? TotalShard { get; set; }

    }


}