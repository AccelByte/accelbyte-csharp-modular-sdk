// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPublicThirdPartyPlatformInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AppId")]
        public string? AppId { get; set; }

        [JsonPropertyName("ClientId")]
        public string? ClientId { get; set; }

        [JsonPropertyName("Environment")]
        public string? Environment { get; set; }

        [JsonPropertyName("IsActive")]
        public bool? IsActive { get; set; }

        [JsonPropertyName("PlatformId")]
        public string? PlatformId { get; set; }

        [JsonPropertyName("PlatformName")]
        public string? PlatformName { get; set; }

    }


}