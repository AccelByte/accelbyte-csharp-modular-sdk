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
    public class ApiFleetRegionalServerCounts : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claimedServerCount")]
        public int? ClaimedServerCount { get; set; }

        [JsonPropertyName("readyServerCount")]
        public int? ReadyServerCount { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("runningVmCount")]
        public int? RunningVmCount { get; set; }

    }


}