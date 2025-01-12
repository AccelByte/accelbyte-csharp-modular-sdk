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
    public class DtoFinishedDataRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("dataExpirationDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DataExpirationDate { get; set; }

        [JsonPropertyName("failedMessage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FailedMessage { get; set; }

        [JsonPropertyName("finishedDate")]
        public DateTime? FinishedDate { get; set; }

        [JsonPropertyName("requestDate")]
        public DateTime? RequestDate { get; set; }

        [JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public DtoFinishedDataRequestStatus? Status { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class DtoFinishedDataRequestStatus : StringEnum<DtoFinishedDataRequestStatus>
    {
        public static readonly DtoFinishedDataRequestStatus Completed
            = new DtoFinishedDataRequestStatus("Completed");

        public static readonly DtoFinishedDataRequestStatus Failed
            = new DtoFinishedDataRequestStatus("Failed");


        public static implicit operator DtoFinishedDataRequestStatus(string value)
        {
            return NewValue(value);
        }

        public DtoFinishedDataRequestStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}