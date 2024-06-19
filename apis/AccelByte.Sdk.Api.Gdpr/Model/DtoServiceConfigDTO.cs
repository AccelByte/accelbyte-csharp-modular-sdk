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

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class DtoServiceConfigDTO : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("protocol")]
        [JsonStringEnum]
        public DtoServiceConfigDTOProtocol? Protocol { get; set; }

        [JsonPropertyName("skipAck")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? SkipAck { get; set; }

        [JsonPropertyName("url")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Url { get; set; }

    }



    public class DtoServiceConfigDTOProtocol : StringEnum<DtoServiceConfigDTOProtocol>
    {
        public static readonly DtoServiceConfigDTOProtocol EVENT
            = new DtoServiceConfigDTOProtocol("EVENT");

        public static readonly DtoServiceConfigDTOProtocol GRPC
            = new DtoServiceConfigDTOProtocol("GRPC");


        public static implicit operator DtoServiceConfigDTOProtocol(string value)
        {
            return NewValue(value);
        }

        public DtoServiceConfigDTOProtocol(string enumValue)
            : base(enumValue)
        {

        }
    }
}