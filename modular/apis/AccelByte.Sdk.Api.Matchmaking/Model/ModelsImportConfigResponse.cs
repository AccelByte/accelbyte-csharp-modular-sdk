// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsImportConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failedConfigs")]
        public List<string>? FailedConfigs { get; set; }

        [JsonPropertyName("ignoredConfigs")]
        public List<string>? IgnoredConfigs { get; set; }

        [JsonPropertyName("newConfigs")]
        public List<string>? NewConfigs { get; set; }

        [JsonPropertyName("replacedConfigs")]
        public List<string>? ReplacedConfigs { get; set; }

    }


}