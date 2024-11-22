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
    public class GeneratedGetDeploymentListV1Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<GeneratedGetDeploymentListV1DataItem>? Data { get; set; }

        [JsonPropertyName("paging")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public GeneratedPagination? Paging { get; set; }

    }


}