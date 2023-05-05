// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ServiceGetSessionHistorySearchResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ServiceGetSessionHistorySearchResponseItemV2>? Data { get; set; }

        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }

    }


}