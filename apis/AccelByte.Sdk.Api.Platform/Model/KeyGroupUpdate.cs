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
    public class KeyGroupUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public KeyGroupUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }



    public class KeyGroupUpdateStatus : StringEnum<KeyGroupUpdateStatus>
    {
        public static readonly KeyGroupUpdateStatus ACTIVE
            = new KeyGroupUpdateStatus("ACTIVE");

        public static readonly KeyGroupUpdateStatus INACTIVE
            = new KeyGroupUpdateStatus("INACTIVE");


        public static implicit operator KeyGroupUpdateStatus(string value)
        {
            return NewValue(value);
        }

        public KeyGroupUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}