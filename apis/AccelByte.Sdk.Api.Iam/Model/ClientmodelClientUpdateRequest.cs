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
    public class ClientmodelClientUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ClientName")]
        public string? ClientName { get; set; }

        [JsonPropertyName("RedirectUri")]
        public string? RedirectUri { get; set; }

        [JsonPropertyName("TwoFactorEnabled")]
        public bool? TwoFactorEnabled { get; set; }

    }


}