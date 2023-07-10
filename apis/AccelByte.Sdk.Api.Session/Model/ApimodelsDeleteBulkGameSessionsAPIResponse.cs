// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsDeleteBulkGameSessionsAPIResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("failed")]
        public List<ApimodelsResponseDeleteBulkGameSessions>? Failed { get; set; }

        [JsonPropertyName("success")]
        public List<string>? Success { get; set; }

    }


}