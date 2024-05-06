// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiFleetServerInfoResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("fleetId")]
        public string? FleetId { get; set; }

        [JsonPropertyName("fleetName")]
        public string? FleetName { get; set; }

        [JsonPropertyName("imageCmd")]
        public string? ImageCmd { get; set; }

        [JsonPropertyName("imageId")]
        public string? ImageId { get; set; }

        [JsonPropertyName("instanceType")]
        public string? InstanceType { get; set; }

        [JsonPropertyName("ipAddress")]
        public string? IpAddress { get; set; }

        [JsonPropertyName("portConfiguration")]
        public List<ApiPortConfiguration>? PortConfiguration { get; set; }

        [JsonPropertyName("ports")]
        public Dictionary<string, long>? Ports { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("serverConfiguration")]
        public string? ServerConfiguration { get; set; }

        [JsonPropertyName("serverId")]
        public string? ServerId { get; set; }

        [JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

    }


}