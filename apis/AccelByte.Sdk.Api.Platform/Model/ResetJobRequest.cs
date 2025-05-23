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
    public class ResetJobRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("env")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ResetJobRequestEnv? Env { get; set; }

        [JsonPropertyName("lastTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? LastTime { get; set; }

    }



    public class ResetJobRequestEnv : StringEnum<ResetJobRequestEnv>
    {
        public static readonly ResetJobRequestEnv LIVE
            = new ResetJobRequestEnv("LIVE");

        public static readonly ResetJobRequestEnv SANDBOX
            = new ResetJobRequestEnv("SANDBOX");


        public static implicit operator ResetJobRequestEnv(string value)
        {
            return NewValue(value);
        }

        public ResetJobRequestEnv(string enumValue)
            : base(enumValue)
        {

        }
    }
}