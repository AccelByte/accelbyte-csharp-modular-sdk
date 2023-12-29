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
    public class ApiArtifactUsageResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("quotaBytes")]
        public long? QuotaBytes { get; set; }

        [JsonPropertyName("remainingBytes")]
        public long? RemainingBytes { get; set; }

        [JsonPropertyName("usedBytes")]
        public long? UsedBytes { get; set; }

    }


}