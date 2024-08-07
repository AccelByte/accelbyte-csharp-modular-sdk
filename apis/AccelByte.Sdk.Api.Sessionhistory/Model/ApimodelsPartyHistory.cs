// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionhistory.Model
{
    public class ApimodelsPartyHistory : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("eventName")]
        public string? EventName { get; set; }

        [JsonPropertyName("payload")]
        public ModelsParty? Payload { get; set; }

        [JsonPropertyName("requesterClientID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequesterClientID { get; set; }

        [JsonPropertyName("requesterUserID")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RequesterUserID { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

    }


}