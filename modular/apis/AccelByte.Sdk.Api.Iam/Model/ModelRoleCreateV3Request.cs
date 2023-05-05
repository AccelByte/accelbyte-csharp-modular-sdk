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
    public class ModelRoleCreateV3Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adminRole")]
        public bool? AdminRole { get; set; }

        [JsonPropertyName("deletable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deletable { get; set; }

        [JsonPropertyName("isWildcard")]
        public bool? IsWildcard { get; set; }

        [JsonPropertyName("managers")]
        public List<AccountcommonRoleManagerV3>? Managers { get; set; }

        [JsonPropertyName("members")]
        public List<AccountcommonRoleMemberV3>? Members { get; set; }

        [JsonPropertyName("permissions")]
        public List<AccountcommonPermissionV3>? Permissions { get; set; }

        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }

    }


}