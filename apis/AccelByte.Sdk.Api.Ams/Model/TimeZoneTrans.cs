// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class TimeZoneTrans : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("index")]
        public long? Index { get; set; }

        [JsonPropertyName("isstd")]
        public bool? Isstd { get; set; }

        [JsonPropertyName("isutc")]
        public bool? Isutc { get; set; }

        [JsonPropertyName("when")]
        public long? When { get; set; }

    }


}