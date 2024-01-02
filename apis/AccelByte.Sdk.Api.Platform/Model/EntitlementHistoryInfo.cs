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
    public class EntitlementHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        [JsonStringEnum]
        public EntitlementHistoryInfoAction? Action { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("entitlementId")]
        public string? EntitlementId { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public EntitlementHistoryInfoOrigin? Origin { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("useCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCount { get; set; }

        [JsonPropertyName("useCountChange")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? UseCountChange { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }



    public class EntitlementHistoryInfoAction : StringEnum<EntitlementHistoryInfoAction>
    {
        public static readonly EntitlementHistoryInfoAction DECREMENT
            = new EntitlementHistoryInfoAction("DECREMENT");

        public static readonly EntitlementHistoryInfoAction DISABLE
            = new EntitlementHistoryInfoAction("DISABLE");

        public static readonly EntitlementHistoryInfoAction ENABLE
            = new EntitlementHistoryInfoAction("ENABLE");

        public static readonly EntitlementHistoryInfoAction GRANT
            = new EntitlementHistoryInfoAction("GRANT");

        public static readonly EntitlementHistoryInfoAction REVOKE
            = new EntitlementHistoryInfoAction("REVOKE");

        public static readonly EntitlementHistoryInfoAction SELLBACK
            = new EntitlementHistoryInfoAction("SELL_BACK");

        public static readonly EntitlementHistoryInfoAction UPDATE
            = new EntitlementHistoryInfoAction("UPDATE");


        public static implicit operator EntitlementHistoryInfoAction(string value)
        {
            return NewValue(value);
        }

        public EntitlementHistoryInfoAction(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class EntitlementHistoryInfoOrigin : StringEnum<EntitlementHistoryInfoOrigin>
    {
        public static readonly EntitlementHistoryInfoOrigin Epic
            = new EntitlementHistoryInfoOrigin("Epic");

        public static readonly EntitlementHistoryInfoOrigin GooglePlay
            = new EntitlementHistoryInfoOrigin("GooglePlay");

        public static readonly EntitlementHistoryInfoOrigin IOS
            = new EntitlementHistoryInfoOrigin("IOS");

        public static readonly EntitlementHistoryInfoOrigin Nintendo
            = new EntitlementHistoryInfoOrigin("Nintendo");

        public static readonly EntitlementHistoryInfoOrigin Oculus
            = new EntitlementHistoryInfoOrigin("Oculus");

        public static readonly EntitlementHistoryInfoOrigin Other
            = new EntitlementHistoryInfoOrigin("Other");

        public static readonly EntitlementHistoryInfoOrigin Playstation
            = new EntitlementHistoryInfoOrigin("Playstation");

        public static readonly EntitlementHistoryInfoOrigin Steam
            = new EntitlementHistoryInfoOrigin("Steam");

        public static readonly EntitlementHistoryInfoOrigin System
            = new EntitlementHistoryInfoOrigin("System");

        public static readonly EntitlementHistoryInfoOrigin Twitch
            = new EntitlementHistoryInfoOrigin("Twitch");

        public static readonly EntitlementHistoryInfoOrigin Xbox
            = new EntitlementHistoryInfoOrigin("Xbox");


        public static implicit operator EntitlementHistoryInfoOrigin(string value)
        {
            return NewValue(value);
        }

        public EntitlementHistoryInfoOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }
}