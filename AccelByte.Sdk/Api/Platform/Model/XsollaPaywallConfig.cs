// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XsollaPaywallConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("device")]
        [JsonStringEnum]
        public XsollaPaywallConfigDevice? Device { get; set; }

        [JsonPropertyName("showCloseButton")]
        public bool? ShowCloseButton { get; set; }

        [JsonPropertyName("size")]
        [JsonStringEnum]
        public XsollaPaywallConfigSize? Size { get; set; }

        [JsonPropertyName("theme")]
        [JsonStringEnum]
        public XsollaPaywallConfigTheme? Theme { get; set; }

    }



    public class XsollaPaywallConfigDevice : StringEnum<XsollaPaywallConfigDevice>
    {
        public static readonly XsollaPaywallConfigDevice DESKTOP
            = new XsollaPaywallConfigDevice("DESKTOP");

        public static readonly XsollaPaywallConfigDevice MOBILE
            = new XsollaPaywallConfigDevice("MOBILE");


        public static implicit operator XsollaPaywallConfigDevice(string value)
        {
            return NewValue(value);
        }

        public XsollaPaywallConfigDevice(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class XsollaPaywallConfigSize : StringEnum<XsollaPaywallConfigSize>
    {
        public static readonly XsollaPaywallConfigSize LARGE
            = new XsollaPaywallConfigSize("LARGE");

        public static readonly XsollaPaywallConfigSize MEDIUM
            = new XsollaPaywallConfigSize("MEDIUM");

        public static readonly XsollaPaywallConfigSize SMALL
            = new XsollaPaywallConfigSize("SMALL");


        public static implicit operator XsollaPaywallConfigSize(string value)
        {
            return NewValue(value);
        }

        public XsollaPaywallConfigSize(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class XsollaPaywallConfigTheme : StringEnum<XsollaPaywallConfigTheme>
    {
        public static readonly XsollaPaywallConfigTheme DARK
            = new XsollaPaywallConfigTheme("DARK");

        public static readonly XsollaPaywallConfigTheme DEFAULT
            = new XsollaPaywallConfigTheme("DEFAULT");

        public static readonly XsollaPaywallConfigTheme DEFAULTDARK
            = new XsollaPaywallConfigTheme("DEFAULT_DARK");


        public static implicit operator XsollaPaywallConfigTheme(string value)
        {
            return NewValue(value);
        }

        public XsollaPaywallConfigTheme(string enumValue)
            : base(enumValue)
        {

        }
    }    
}