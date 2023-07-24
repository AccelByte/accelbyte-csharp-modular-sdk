// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class UserDLCRecord : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Namespace { get; set; }

        [JsonPropertyName("obtainedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ObtainedAt { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public UserDLCRecordPlatform? Platform { get; set; }

        [JsonPropertyName("revocationResult")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public RevocationResult? RevocationResult { get; set; }

        [JsonPropertyName("revokeResults")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RevokeResult>? RevokeResults { get; set; }

        [JsonPropertyName("revokedAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? RevokedAt { get; set; }

        [JsonPropertyName("rewards")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<PlatformReward>? Rewards { get; set; }

        [JsonPropertyName("sources")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Sources { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public UserDLCRecordStatus? Status { get; set; }

        [JsonPropertyName("transactionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TransactionId { get; set; }

        [JsonPropertyName("userId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserId { get; set; }

        [JsonPropertyName("version")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Version { get; set; }

    }



    public class UserDLCRecordPlatform : StringEnum<UserDLCRecordPlatform>
    {
        public static readonly UserDLCRecordPlatform EPICGAMES
            = new UserDLCRecordPlatform("EPICGAMES");

        public static readonly UserDLCRecordPlatform OCULUS
            = new UserDLCRecordPlatform("OCULUS");

        public static readonly UserDLCRecordPlatform PSN
            = new UserDLCRecordPlatform("PSN");

        public static readonly UserDLCRecordPlatform STEAM
            = new UserDLCRecordPlatform("STEAM");

        public static readonly UserDLCRecordPlatform XBOX
            = new UserDLCRecordPlatform("XBOX");


        public static implicit operator UserDLCRecordPlatform(string value)
        {
            return NewValue(value);
        }

        public UserDLCRecordPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class UserDLCRecordStatus : StringEnum<UserDLCRecordStatus>
    {
        public static readonly UserDLCRecordStatus FULFILLED
            = new UserDLCRecordStatus("FULFILLED");

        public static readonly UserDLCRecordStatus REVOKED
            = new UserDLCRecordStatus("REVOKED");

        public static readonly UserDLCRecordStatus REVOKEFAILED
            = new UserDLCRecordStatus("REVOKE_FAILED");


        public static implicit operator UserDLCRecordStatus(string value)
        {
            return NewValue(value);
        }

        public UserDLCRecordStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}