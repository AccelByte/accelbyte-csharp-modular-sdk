// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Reporting.Model
{
    public class RestapiUpdateReasonGroupRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("reasonIds")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? ReasonIds { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

    }


}