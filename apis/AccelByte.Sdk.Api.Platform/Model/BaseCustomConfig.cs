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
    public class BaseCustomConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("connectionType")]
        [JsonStringEnum]
        public BaseCustomConfigConnectionType? ConnectionType { get; set; }

        [JsonPropertyName("grpcServerAddress")]
        public string? GrpcServerAddress { get; set; }

    }



    public class BaseCustomConfigConnectionType : StringEnum<BaseCustomConfigConnectionType>
    {
        public static readonly BaseCustomConfigConnectionType INSECURE
            = new BaseCustomConfigConnectionType("INSECURE");

        public static readonly BaseCustomConfigConnectionType TLS
            = new BaseCustomConfigConnectionType("TLS");


        public static implicit operator BaseCustomConfigConnectionType(string value)
        {
            return NewValue(value);
        }

        public BaseCustomConfigConnectionType(string enumValue)
            : base(enumValue)
        {

        }
    }
}