// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

/*
serviceName: Lobby

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby
{
    public static class LobbyErrors
    {
    }

    public class ModelBulkFriendsResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("rowsAffected")]
        public int? RowsAffected { get; set; }


        public ApiError TranslateToApiError()
        {
            return new ApiError(
                "",
                ""
            );
        }
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

    public class RestapiErrorResponseBody : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ErrorCode")]
        public int? ErrorCode { get; set; }

        [JsonPropertyName("ErrorMessage")]
        public string? ErrorMessage { get; set; }


        public ApiError TranslateToApiError()
        {
            return new ApiError(
                ErrorCode != null ? ErrorCode.Value.ToString() : "",
                ErrorMessage != null ? ErrorMessage.ToString() : ""
            );
        }
    }

    public class RestapiErrorResponseV1 : AccelByte.Sdk.Core.Model
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