// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsPatchImageRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("artifactPath")]
        public string? ArtifactPath { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("dockerPath")]
        public string? DockerPath { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("imageSize")]
        public long? ImageSize { get; set; }

        [JsonPropertyName("modifiedBy")]
        public string? ModifiedBy { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("patchVersion")]
        public string? PatchVersion { get; set; }

        [JsonPropertyName("persistent")]
        public bool? Persistent { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("uploaderFlags")]
        public List<ModelsUploaderFlag>? UploaderFlags { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

    }


}