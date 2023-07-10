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
    public class PlayStationReconcileResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("psnItemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PsnItemId { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PlayStationReconcileResultStatus? Status { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TransactionId { get; set; }

    }



    public class PlayStationReconcileResultStatus : StringEnum<PlayStationReconcileResultStatus>
    {
        public static readonly PlayStationReconcileResultStatus FAILED
            = new PlayStationReconcileResultStatus("FAILED");

        public static readonly PlayStationReconcileResultStatus FULFILLED
            = new PlayStationReconcileResultStatus("FULFILLED");

        public static readonly PlayStationReconcileResultStatus VERIFIED
            = new PlayStationReconcileResultStatus("VERIFIED");


        public static implicit operator PlayStationReconcileResultStatus(string value)
        {
            return NewValue(value);
        }

        public PlayStationReconcileResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}