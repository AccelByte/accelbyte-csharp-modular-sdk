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
    public class ModelsAllianceRuleV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("combination")]
        public ModelsCombination? Combination { get; set; }

        [JsonPropertyName("maxNumber")]
        public int? MaxNumber { get; set; }

        [JsonPropertyName("minNumber")]
        public int? MinNumber { get; set; }

        [JsonPropertyName("playerMaxNumber")]
        public int? PlayerMaxNumber { get; set; }

        [JsonPropertyName("playerMinNumber")]
        public int? PlayerMinNumber { get; set; }

    }


}