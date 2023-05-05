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
    public class ModelsAdminConcurrentRecordRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("set_by")]
        public string? SetBy { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public Dictionary<string, object>? Value { get; set; }

    }

    public class ModelsAdminConcurrentRecordRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("set_by")]
        public string? SetBy { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public T1? Value { get; set; }

    }

}