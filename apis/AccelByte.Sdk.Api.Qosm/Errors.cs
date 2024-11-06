// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Qosm

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Api.Qosm
{
    public static class QosmErrors
    {
    }

    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }


        public ApiError TranslateToApiError()
        {
            return new ApiError(
                Code != null ? Code.Value.ToString() : "",
                Message != null ? Message.ToString() : ""
            );
        }
    }

}