// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsBulkUpdatePlayerRecordByKeyResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("detail")]
        public Dictionary<string, object>? Detail { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }

    public class ModelsBulkUpdatePlayerRecordByKeyResponse<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("detail")]
        public T1? Detail { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

    }

}