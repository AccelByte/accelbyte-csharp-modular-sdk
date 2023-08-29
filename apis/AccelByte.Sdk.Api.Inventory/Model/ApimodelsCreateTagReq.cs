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

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsCreateTagReq : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("owner")]
        [JsonStringEnum]
        public ApimodelsCreateTagReqOwner? Owner { get; set; }

    }



    public class ApimodelsCreateTagReqOwner : StringEnum<ApimodelsCreateTagReqOwner>
    {
        public static readonly ApimodelsCreateTagReqOwner CLIENT
            = new ApimodelsCreateTagReqOwner("CLIENT");

        public static readonly ApimodelsCreateTagReqOwner SERVER
            = new ApimodelsCreateTagReqOwner("SERVER");


        public static implicit operator ApimodelsCreateTagReqOwner(string value)
        {
            return NewValue(value);
        }

        public ApimodelsCreateTagReqOwner(string enumValue)
            : base(enumValue)
        {

        }
    }    
}