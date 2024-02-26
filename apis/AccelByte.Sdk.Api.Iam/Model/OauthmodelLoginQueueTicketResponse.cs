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
    public class OauthmodelLoginQueueTicketResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cancel")]
        public OauthmodelTicketEndpointAction? Cancel { get; set; }

        [JsonPropertyName("estimatedWaitingTimeInSeconds")]
        public int? EstimatedWaitingTimeInSeconds { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("reconnectExpiredAt")]
        public long? ReconnectExpiredAt { get; set; }

        [JsonPropertyName("refresh")]
        public OauthmodelTicketEndpointAction? Refresh { get; set; }

        [JsonPropertyName("ticket")]
        public string? Ticket { get; set; }

    }


}