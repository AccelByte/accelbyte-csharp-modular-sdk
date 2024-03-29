// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsartifact.Model
{
    public class ModelsArtifactFileStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("artifact_existence")]
        public bool? ArtifactExistence { get; set; }

        [JsonPropertyName("artifact_status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ArtifactStatus { get; set; }

    }


}