// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ItemDynamicDataInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableCount")]
        public int? AvailableCount { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("userAvailableCount")]
        public long? UserAvailableCount { get; set; }

        [JsonPropertyName("userPurchaseLimit")]
        public long? UserPurchaseLimit { get; set; }

    }


}