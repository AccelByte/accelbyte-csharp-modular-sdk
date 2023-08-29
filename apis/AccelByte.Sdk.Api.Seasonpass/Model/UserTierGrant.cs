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

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserTierGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Count { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public UserTierGrantSource? Source { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }



    public class UserTierGrantSource : StringEnum<UserTierGrantSource>
    {
        public static readonly UserTierGrantSource PAIDFOR
            = new UserTierGrantSource("PAID_FOR");

        public static readonly UserTierGrantSource SWEAT
            = new UserTierGrantSource("SWEAT");


        public static implicit operator UserTierGrantSource(string value)
        {
            return NewValue(value);
        }

        public UserTierGrantSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}