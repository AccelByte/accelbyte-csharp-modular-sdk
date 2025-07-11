// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Csm

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Api.Csm
{
    public static class CsmErrors
    {
    }

    public class ResponseErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("error")]
        public string? Error { get; set; }

        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("errors")]
        public string? Errors { get; set; }

        [JsonPropertyName("messageVariables")]
        public Dictionary<string, string>? MessageVariables { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode = 
                Error != null ? Error.ToString() :
                ErrorCode != null ? ErrorCode.Value.ToString() :
                "";
            
            string errorMessage = 
                ErrorMessage != null ? ErrorMessage.ToString() :                
                "";
            
            return new ApiError(errorCode, errorMessage);
        }
    }

}