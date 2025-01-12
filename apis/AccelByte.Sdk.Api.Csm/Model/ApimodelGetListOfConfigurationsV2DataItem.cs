// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class ApimodelGetListOfConfigurationsV2DataItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("applyMask")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? ApplyMask { get; set; }

        [JsonPropertyName("configId")]
        public string? ConfigId { get; set; }

        [JsonPropertyName("configName")]
        public string? ConfigName { get; set; }

        [JsonPropertyName("configType")]
        public string? ConfigType { get; set; }

        [JsonPropertyName("deploymentStatus")]
        public string? DeploymentStatus { get; set; }

        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("editable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Editable { get; set; }

        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Source { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

    }


}