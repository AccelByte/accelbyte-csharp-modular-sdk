// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ClaimableRewards : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claimingRewards")]
        public Dictionary<string, object>? ClaimingRewards { get; set; }

        [JsonPropertyName("toClaimRewards")]
        public Dictionary<string, object>? ToClaimRewards { get; set; }

    }

    public class ClaimableRewards<T1, T2> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("claimingRewards")]
        public T1? ClaimingRewards { get; set; }

        [JsonPropertyName("toClaimRewards")]
        public T2? ToClaimRewards { get; set; }

    }

}