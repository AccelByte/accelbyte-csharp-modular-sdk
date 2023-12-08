// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Chat.Model
{
    public class ModelsUpdateInboxMessageRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("expiredAt")]
        public long? ExpiredAt { get; set; }

        [JsonPropertyName("message")]
        public Dictionary<string, object>? Message { get; set; }

        [JsonPropertyName("scope")]
        [JsonStringEnum]
        public ModelsUpdateInboxMessageRequestScope? Scope { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }

    public class ModelsUpdateInboxMessageRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("expiredAt")]
        public long? ExpiredAt { get; set; }

        [JsonPropertyName("message")]
        public T1? Message { get; set; }

        [JsonPropertyName("scope")]
        [JsonStringEnum]
        public ModelsUpdateInboxMessageRequestScope? Scope { get; set; }

        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }

    }


    public class ModelsUpdateInboxMessageRequestScope : StringEnum<ModelsUpdateInboxMessageRequestScope>
    {
        public static readonly ModelsUpdateInboxMessageRequestScope NAMESPACE
            = new ModelsUpdateInboxMessageRequestScope("NAMESPACE");

        public static readonly ModelsUpdateInboxMessageRequestScope USER
            = new ModelsUpdateInboxMessageRequestScope("USER");


        public static implicit operator ModelsUpdateInboxMessageRequestScope(string value)
        {
            return NewValue(value);
        }

        public ModelsUpdateInboxMessageRequestScope(string enumValue)
            : base(enumValue)
        {

        }
    }
}