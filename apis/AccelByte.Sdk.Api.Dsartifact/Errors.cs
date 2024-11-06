// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Dsartifact

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Api.Dsartifact
{
    public static class DsartifactErrors
    {
    }

    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }


        public ApiError TranslateToApiError()
        {
            return new ApiError(
                ErrorCode != null ? ErrorCode.Value.ToString() : "",
                ErrorMessage != null ? ErrorMessage.ToString() : ""
            );
        }
    }

}