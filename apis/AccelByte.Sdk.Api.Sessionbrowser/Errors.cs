// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Sessionbrowser

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Api.Sessionbrowser
{
    public static class SessionbrowserErrors
    {
        public static readonly ApiError Error20000 = new ApiError("20000", "internal server error");
        public static readonly ApiError Error20001 = new ApiError("20001", "unauthorized access");
        public static readonly ApiError Error20002 = new ApiError("20002", "validation error");
        public static readonly ApiError Error20013 = new ApiError("20013", "insufficient permissions");
        public static readonly ApiError Error20014 = new ApiError("20014", "invalid audience");
        public static readonly ApiError Error20015 = new ApiError("20015", "insufficient scope");
        public static readonly ApiError Error20019 = new ApiError("20019", "unable to parse request body");
    }

    public class ResponseError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode =
                ErrorCode != null ? ErrorCode.Value.ToString() :
                "";

            string errorMessage =
                ErrorMessage != null ? ErrorMessage.ToString() :
                "";

            return new ApiError(errorCode, errorMessage);
        }
    }

    public class RestapiErrorResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("attributes")]
        public Dictionary<string, string>? Attributes { get; set; }

        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode =
                ErrorCode != null ? ErrorCode.Value.ToString() :
                "";

            string errorMessage =
                ErrorMessage != null ? ErrorMessage.ToString() :
                Message != null ? Message.ToString() :
                "";

            return new ApiError(errorCode, errorMessage);
        }
    }

    public class RestapiErrorV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("errorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }


        public ApiError TranslateToApiError()
        {
            string errorCode =
                ErrorCode != null ? ErrorCode.Value.ToString() :
                "";

            string errorMessage =
                ErrorMessage != null ? ErrorMessage.ToString() :
                "";

            return new ApiError(errorCode, errorMessage);
        }
    }

}