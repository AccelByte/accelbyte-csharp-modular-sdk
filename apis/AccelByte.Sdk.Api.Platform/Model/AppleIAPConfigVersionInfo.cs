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
    public class AppleIAPConfigVersionInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("version")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AppleIAPConfigVersionInfoVersion? Version { get; set; }

    }



    public class AppleIAPConfigVersionInfoVersion : StringEnum<AppleIAPConfigVersionInfoVersion>
    {
        public static readonly AppleIAPConfigVersionInfoVersion V1
            = new AppleIAPConfigVersionInfoVersion("V1");

        public static readonly AppleIAPConfigVersionInfoVersion V2
            = new AppleIAPConfigVersionInfoVersion("V2");


        public static implicit operator AppleIAPConfigVersionInfoVersion(string value)
        {
            return NewValue(value);
        }

        public AppleIAPConfigVersionInfoVersion(string enumValue)
            : base(enumValue)
        {

        }
    }
}