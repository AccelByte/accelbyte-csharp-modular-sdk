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
    public class ModelPlatformDomainUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affectedClientIDs")]
        public List<string>? AffectedClientIDs { get; set; }

        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }

        [JsonPropertyName("domain")]
        public string? Domain { get; set; }

        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }

        [JsonPropertyName("ssoCfg")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AccountcommonSsoConfig? SsoCfg { get; set; }

    }


}