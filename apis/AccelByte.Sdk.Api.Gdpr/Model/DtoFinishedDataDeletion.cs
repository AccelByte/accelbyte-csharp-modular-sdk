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

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class DtoFinishedDataDeletion : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failedMessage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FailedMessage { get; set; }

        [JsonPropertyName("finishedDate")]
        public DateTime? FinishedDate { get; set; }

        [JsonPropertyName("requestDate")]
        public DateTime? RequestDate { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public DtoFinishedDataDeletionStatus? Status { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class DtoFinishedDataDeletionStatus : StringEnum<DtoFinishedDataDeletionStatus>
    {
        public static readonly DtoFinishedDataDeletionStatus Completed, Failed
            = new DtoFinishedDataDeletionStatus("Completed,Failed");


        public static implicit operator DtoFinishedDataDeletionStatus(string value)
        {
            return NewValue(value);
        }

        public DtoFinishedDataDeletionStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}