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
    public class UserDLC : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("dlcs")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<DLCRecord>? Dlcs { get; set; }

        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public UserDLCPlatform? Platform { get; set; }

        [JsonPropertyName("rvn")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Rvn { get; set; }

        [JsonPropertyName("updatedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

    }



    public class UserDLCPlatform : StringEnum<UserDLCPlatform>
    {
        public static readonly UserDLCPlatform EPICGAMES
            = new UserDLCPlatform("EPICGAMES");

        public static readonly UserDLCPlatform PSN
            = new UserDLCPlatform("PSN");

        public static readonly UserDLCPlatform STEAM
            = new UserDLCPlatform("STEAM");

        public static readonly UserDLCPlatform XBOX
            = new UserDLCPlatform("XBOX");


        public static implicit operator UserDLCPlatform(string value)
        {
            return NewValue(value);
        }

        public UserDLCPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }    
}