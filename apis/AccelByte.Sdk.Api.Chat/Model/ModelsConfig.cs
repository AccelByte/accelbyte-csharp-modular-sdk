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
    public class ModelsConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ChatRateLimitBurst")]
        public int? ChatRateLimitBurst { get; set; }

        [JsonPropertyName("ChatRateLimitDuration")]
        public long? ChatRateLimitDuration { get; set; }

        [JsonPropertyName("ConcurrentUsersLimit")]
        public int? ConcurrentUsersLimit { get; set; }

        [JsonPropertyName("EnableManualTopicCreation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableManualTopicCreation { get; set; }

        [JsonPropertyName("EnableProfanityFilter")]
        public bool? EnableProfanityFilter { get; set; }

        [JsonPropertyName("FilterAppName")]
        public string? FilterAppName { get; set; }

        [JsonPropertyName("FilterParam")]
        public string? FilterParam { get; set; }

        [JsonPropertyName("FilterType")]
        public string? FilterType { get; set; }

        [JsonPropertyName("GeneralRateLimitBurst")]
        public int? GeneralRateLimitBurst { get; set; }

        [JsonPropertyName("GeneralRateLimitDuration")]
        public long? GeneralRateLimitDuration { get; set; }

        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("ShardCapacityLimit")]
        public int? ShardCapacityLimit { get; set; }

        [JsonPropertyName("ShardDefaultLimit")]
        public int? ShardDefaultLimit { get; set; }

        [JsonPropertyName("ShardHardLimit")]
        public int? ShardHardLimit { get; set; }

        [JsonPropertyName("SpamChatBurst")]
        public int? SpamChatBurst { get; set; }

        [JsonPropertyName("SpamChatDuration")]
        public long? SpamChatDuration { get; set; }

        [JsonPropertyName("SpamMuteDuration")]
        public long? SpamMuteDuration { get; set; }

        [JsonPropertyName("defaultDictionaryLoaded")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? DefaultDictionaryLoaded { get; set; }

        [JsonPropertyName("enableClanChat")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnableClanChat { get; set; }

        [JsonPropertyName("enablePmSendPlatformId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? EnablePmSendPlatformId { get; set; }

        [JsonPropertyName("maxChatMessageLength")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxChatMessageLength { get; set; }

        [JsonPropertyName("useDefaultDictionary")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? UseDefaultDictionary { get; set; }

    }


}