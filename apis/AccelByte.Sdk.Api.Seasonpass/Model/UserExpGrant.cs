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
    public class UserExpGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("exp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Exp { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public UserExpGrantSource? Source { get; set; }

        [JsonPropertyName("tags")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Tags { get; set; }

    }



    public class UserExpGrantSource : StringEnum<UserExpGrantSource>
    {
        public static readonly UserExpGrantSource PAIDFOR
            = new UserExpGrantSource("PAID_FOR");

        public static readonly UserExpGrantSource SWEAT
            = new UserExpGrantSource("SWEAT");


        public static implicit operator UserExpGrantSource(string value)
        {
            return NewValue(value);
        }

        public UserExpGrantSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}