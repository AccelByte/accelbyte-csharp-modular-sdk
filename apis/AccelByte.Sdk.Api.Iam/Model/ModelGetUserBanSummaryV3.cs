// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetUserBanSummaryV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("activeCount")]
        public int? ActiveCount { get; set; }

        [JsonPropertyName("data")]
        public List<ModelUserBanWithStatus>? Data { get; set; }

        [JsonPropertyName("inactiveCount")]
        public int? InactiveCount { get; set; }

        [JsonPropertyName("totalCount")]
        public int? TotalCount { get; set; }

    }


}