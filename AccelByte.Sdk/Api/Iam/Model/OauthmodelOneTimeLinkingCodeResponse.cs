// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthmodelOneTimeLinkingCodeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("exp")]
        public long? Exp { get; set; }

        [JsonPropertyName("oneTimeLinkCode")]
        public string? OneTimeLinkCode { get; set; }

        [JsonPropertyName("oneTimeLinkUrl")]
        public string? OneTimeLinkUrl { get; set; }

    }


}