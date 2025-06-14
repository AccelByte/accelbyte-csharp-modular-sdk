// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Ams

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Api.Ams
{
    public static class AmsErrors
    {
    }

    public class ResponseErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("errorType")]
        public string? ErrorType { get; set; }

        [JsonPropertyName("traceId")]
        public string? TraceId { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode = 
                ErrorType != null ? ErrorType.ToString() :
                "";
            
            string errorMessage = 
                ErrorMessage != null ? ErrorMessage.ToString() :                
                "";
            
            return new ApiError(errorCode, errorMessage);
        }
    }

}