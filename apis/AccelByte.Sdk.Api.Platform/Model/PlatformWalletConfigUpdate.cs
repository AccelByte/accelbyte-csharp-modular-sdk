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
    public class PlatformWalletConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedBalanceOrigins")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public List<PlatformWalletConfigUpdateAllowedBalanceOrigins>? AllowedBalanceOrigins { get; set; }

    }



    public class PlatformWalletConfigUpdateAllowedBalanceOrigins : StringEnum<PlatformWalletConfigUpdateAllowedBalanceOrigins>
    {
        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Epic
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Epic");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins GooglePlay
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("GooglePlay");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins IOS
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("IOS");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Nintendo
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Nintendo");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Other
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Other");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Playstation
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Playstation");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Steam
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Steam");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins System
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("System");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Twitch
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Twitch");

        public static readonly PlatformWalletConfigUpdateAllowedBalanceOrigins Xbox
            = new PlatformWalletConfigUpdateAllowedBalanceOrigins("Xbox");


        public static implicit operator PlatformWalletConfigUpdateAllowedBalanceOrigins(string value)
        {
            return NewValue(value);
        }

        public PlatformWalletConfigUpdateAllowedBalanceOrigins(string enumValue)
            : base(enumValue)
        {

        }
    }
}