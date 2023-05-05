// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Code { get; set; }

        [JsonPropertyName("httpStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? HttpStatus { get; set; }

        [JsonPropertyName("message")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Message { get; set; }

    }


}