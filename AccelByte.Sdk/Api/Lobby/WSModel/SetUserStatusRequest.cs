// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Text.Json.Serialization;

using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Api.Lobby.WSModel
{
    [AwesomeModel("setUserStatusRequest")]
    public class SetUserStatusRequest : AccelByte.Sdk.Core.WSModel
    {
        [AwesomeProperty("activity")]
        [JsonPropertyName("activity")]
        public string? Activity { get; set; }
        
        [AwesomeProperty("availability")]
        [JsonPropertyName("availability")]
        public long? Availability { get; set; }
        
        [AwesomeProperty("id")]
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
    }
}