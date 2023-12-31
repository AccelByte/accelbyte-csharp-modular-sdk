// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Inventory.Model
{
    public class ApimodelsTradeItemResp : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("qty")]
        public int? Qty { get; set; }

        [JsonPropertyName("slotId")]
        public string? SlotId { get; set; }

        [JsonPropertyName("sourceItemId")]
        public string? SourceItemId { get; set; }

    }


}