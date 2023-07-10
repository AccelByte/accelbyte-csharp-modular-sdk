// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelDeviceBanRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("deviceId")]
        public string? DeviceId { get; set; }

        [JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("endDate")]
        public string? EndDate { get; set; }

        [JsonPropertyName("ext")]
        public Dictionary<string, object>? Ext { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

    }

    public class ModelDeviceBanRequestV4<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        [JsonPropertyName("deviceId")]
        public string? DeviceId { get; set; }

        [JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        [JsonPropertyName("endDate")]
        public string? EndDate { get; set; }

        [JsonPropertyName("ext")]
        public T1? Ext { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

    }

}