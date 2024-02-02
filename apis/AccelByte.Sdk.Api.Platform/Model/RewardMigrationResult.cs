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
    public class RewardMigrationResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("quantity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Quantity { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RewardMigrationResultStatus? Status { get; set; }

        [JsonPropertyName("syncedCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? SyncedCount { get; set; }

        [JsonPropertyName("syncedEntitlementIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? SyncedEntitlementIds { get; set; }

    }



    public class RewardMigrationResultStatus : StringEnum<RewardMigrationResultStatus>
    {
        public static readonly RewardMigrationResultStatus FAIL
            = new RewardMigrationResultStatus("FAIL");

        public static readonly RewardMigrationResultStatus SUCCESS
            = new RewardMigrationResultStatus("SUCCESS");


        public static implicit operator RewardMigrationResultStatus(string value)
        {
            return NewValue(value);
        }

        public RewardMigrationResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}