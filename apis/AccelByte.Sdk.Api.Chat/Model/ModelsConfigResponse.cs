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
    public class ModelsConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("chatRateLimitBurst")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ChatRateLimitBurst { get; set; }

        [JsonPropertyName("chatRateLimitDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? ChatRateLimitDuration { get; set; }

        [JsonPropertyName("concurrentUsersLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ConcurrentUsersLimit { get; set; }

        [JsonPropertyName("enableClanChat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableClanChat { get; set; }

        [JsonPropertyName("enableManualTopicCreation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableManualTopicCreation { get; set; }

        [JsonPropertyName("enableProfanityFilter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableProfanityFilter { get; set; }

        [JsonPropertyName("filterAppName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FilterAppName { get; set; }

        [JsonPropertyName("filterParam")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FilterParam { get; set; }

        [JsonPropertyName("filterType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FilterType { get; set; }

        [JsonPropertyName("generalRateLimitBurst")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? GeneralRateLimitBurst { get; set; }

        [JsonPropertyName("generalRateLimitDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? GeneralRateLimitDuration { get; set; }

        [JsonPropertyName("shardCapacityLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ShardCapacityLimit { get; set; }

        [JsonPropertyName("shardDefaultLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ShardDefaultLimit { get; set; }

        [JsonPropertyName("shardHardLimit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? ShardHardLimit { get; set; }

        [JsonPropertyName("spamChatBurst")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SpamChatBurst { get; set; }

        [JsonPropertyName("spamChatDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? SpamChatDuration { get; set; }

        [JsonPropertyName("spamMuteDuration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? SpamMuteDuration { get; set; }

    }


}