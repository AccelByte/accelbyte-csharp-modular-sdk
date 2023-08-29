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

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class NotificationProcessResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Code { get; set; }

        [JsonPropertyName("customParam")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomParam { get; set; }

        [JsonPropertyName("severity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Severity { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public NotificationProcessResultStatus? Status { get; set; }

    }

    public class NotificationProcessResult<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Code { get; set; }

        [JsonPropertyName("customParam")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomParam { get; set; }

        [JsonPropertyName("severity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Severity { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public NotificationProcessResultStatus? Status { get; set; }

    }


    public class NotificationProcessResultStatus : StringEnum<NotificationProcessResultStatus>
    {
        public static readonly NotificationProcessResultStatus ERROR
            = new NotificationProcessResultStatus("ERROR");

        public static readonly NotificationProcessResultStatus IGNORED
            = new NotificationProcessResultStatus("IGNORED");

        public static readonly NotificationProcessResultStatus PROCESSED
            = new NotificationProcessResultStatus("PROCESSED");

        public static readonly NotificationProcessResultStatus WARN
            = new NotificationProcessResultStatus("WARN");


        public static implicit operator NotificationProcessResultStatus(string value)
        {
            return NewValue(value);
        }

        public NotificationProcessResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}