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
    public class RevokeItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemIdentity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemIdentity { get; set; }

        [JsonPropertyName("itemIdentityType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RevokeItemItemIdentityType? ItemIdentityType { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RevokeItemOrigin? Origin { get; set; }

    }



    public class RevokeItemItemIdentityType : StringEnum<RevokeItemItemIdentityType>
    {
        public static readonly RevokeItemItemIdentityType ITEMID
            = new RevokeItemItemIdentityType("ITEM_ID");

        public static readonly RevokeItemItemIdentityType ITEMSKU
            = new RevokeItemItemIdentityType("ITEM_SKU");


        public static implicit operator RevokeItemItemIdentityType(string value)
        {
            return NewValue(value);
        }

        public RevokeItemItemIdentityType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class RevokeItemOrigin : StringEnum<RevokeItemOrigin>
    {
        public static readonly RevokeItemOrigin Epic
            = new RevokeItemOrigin("Epic");

        public static readonly RevokeItemOrigin GooglePlay
            = new RevokeItemOrigin("GooglePlay");

        public static readonly RevokeItemOrigin IOS
            = new RevokeItemOrigin("IOS");

        public static readonly RevokeItemOrigin Nintendo
            = new RevokeItemOrigin("Nintendo");

        public static readonly RevokeItemOrigin Other
            = new RevokeItemOrigin("Other");

        public static readonly RevokeItemOrigin Playstation
            = new RevokeItemOrigin("Playstation");

        public static readonly RevokeItemOrigin Steam
            = new RevokeItemOrigin("Steam");

        public static readonly RevokeItemOrigin System
            = new RevokeItemOrigin("System");

        public static readonly RevokeItemOrigin Twitch
            = new RevokeItemOrigin("Twitch");

        public static readonly RevokeItemOrigin Xbox
            = new RevokeItemOrigin("Xbox");


        public static implicit operator RevokeItemOrigin(string value)
        {
            return NewValue(value);
        }

        public RevokeItemOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }    
}