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
    public class ModelsChannelTopicResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public long? CreatedAt { get; set; }

        [JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("isJoinable")]
        public bool? IsJoinable { get; set; }

        [JsonPropertyName("messagePerMinutes")]
        public double? MessagePerMinutes { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("shardLimit")]
        public int? ShardLimit { get; set; }

        [JsonPropertyName("shardNumber")]
        public int? ShardNumber { get; set; }

        [JsonPropertyName("topicId")]
        public string? TopicId { get; set; }

        [JsonPropertyName("totalMember")]
        public int? TotalMember { get; set; }

    }


}