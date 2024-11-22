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
    public class ApimodelSubscribeNotificationResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("notificationType")]
        public string? NotificationType { get; set; }

        [JsonPropertyName("subscriptions")]
        public List<ApimodelSubscriberItemResponse>? Subscriptions { get; set; }

    }


}