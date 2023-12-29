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
    public class ModelsUpdateInboxCategoryRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("expiresIn")]
        public long? ExpiresIn { get; set; }

        [JsonPropertyName("hook")]
        public ModelsCategoryHook? Hook { get; set; }

        [JsonPropertyName("jsonSchema")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? JsonSchema { get; set; }

        [JsonPropertyName("saveInbox")]
        public bool? SaveInbox { get; set; }

        [JsonPropertyName("sendNotification")]
        public bool? SendNotification { get; set; }

    }

    public class ModelsUpdateInboxCategoryRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("expiresIn")]
        public long? ExpiresIn { get; set; }

        [JsonPropertyName("hook")]
        public ModelsCategoryHook? Hook { get; set; }

        [JsonPropertyName("jsonSchema")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? JsonSchema { get; set; }

        [JsonPropertyName("saveInbox")]
        public bool? SaveInbox { get; set; }

        [JsonPropertyName("sendNotification")]
        public bool? SendNotification { get; set; }

    }

}