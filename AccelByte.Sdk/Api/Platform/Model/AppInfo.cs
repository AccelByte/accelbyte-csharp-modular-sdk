// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("announcement")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Announcement { get; set; }

        [JsonPropertyName("carousel")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Slide>? Carousel { get; set; }

        [JsonPropertyName("developer")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Developer { get; set; }

        [JsonPropertyName("forumUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ForumUrl { get; set; }

        [JsonPropertyName("genres")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public List<AppInfoGenres>? Genres { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("platformRequirements")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, List<Requirement>>? PlatformRequirements { get; set; }

        [JsonPropertyName("platforms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public List<AppInfoPlatforms>? Platforms { get; set; }

        [JsonPropertyName("players")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public List<AppInfoPlayers>? Players { get; set; }

        [JsonPropertyName("primaryGenre")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public AppInfoPrimaryGenre? PrimaryGenre { get; set; }

        [JsonPropertyName("publisher")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Publisher { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("releaseDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ReleaseDate { get; set; }

        [JsonPropertyName("slogan")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Slogan { get; set; }

        [JsonPropertyName("websiteUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? WebsiteUrl { get; set; }

    }



    public class AppInfoGenres : StringEnum<AppInfoGenres>
    {
        public static readonly AppInfoGenres Action
            = new AppInfoGenres("Action");

        public static readonly AppInfoGenres Adventure
            = new AppInfoGenres("Adventure");

        public static readonly AppInfoGenres Casual
            = new AppInfoGenres("Casual");

        public static readonly AppInfoGenres FreeToPlay
            = new AppInfoGenres("FreeToPlay");

        public static readonly AppInfoGenres Indie
            = new AppInfoGenres("Indie");

        public static readonly AppInfoGenres MassivelyMultiplayer
            = new AppInfoGenres("MassivelyMultiplayer");

        public static readonly AppInfoGenres RPG
            = new AppInfoGenres("RPG");

        public static readonly AppInfoGenres Racing
            = new AppInfoGenres("Racing");

        public static readonly AppInfoGenres Simulation
            = new AppInfoGenres("Simulation");

        public static readonly AppInfoGenres Sports
            = new AppInfoGenres("Sports");

        public static readonly AppInfoGenres Strategy
            = new AppInfoGenres("Strategy");


        public static implicit operator AppInfoGenres(string value)
        {
            return NewValue(value);
        }

        public AppInfoGenres(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPlatforms : StringEnum<AppInfoPlatforms>
    {
        public static readonly AppInfoPlatforms Android
            = new AppInfoPlatforms("Android");

        public static readonly AppInfoPlatforms IOS
            = new AppInfoPlatforms("IOS");

        public static readonly AppInfoPlatforms Linux
            = new AppInfoPlatforms("Linux");

        public static readonly AppInfoPlatforms MacOS
            = new AppInfoPlatforms("MacOS");

        public static readonly AppInfoPlatforms Windows
            = new AppInfoPlatforms("Windows");


        public static implicit operator AppInfoPlatforms(string value)
        {
            return NewValue(value);
        }

        public AppInfoPlatforms(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPlayers : StringEnum<AppInfoPlayers>
    {
        public static readonly AppInfoPlayers Coop
            = new AppInfoPlayers("Coop");

        public static readonly AppInfoPlayers CrossPlatformMulti
            = new AppInfoPlayers("CrossPlatformMulti");

        public static readonly AppInfoPlayers LocalCoop
            = new AppInfoPlayers("LocalCoop");

        public static readonly AppInfoPlayers MMO
            = new AppInfoPlayers("MMO");

        public static readonly AppInfoPlayers Multi
            = new AppInfoPlayers("Multi");

        public static readonly AppInfoPlayers Single
            = new AppInfoPlayers("Single");


        public static implicit operator AppInfoPlayers(string value)
        {
            return NewValue(value);
        }

        public AppInfoPlayers(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class AppInfoPrimaryGenre : StringEnum<AppInfoPrimaryGenre>
    {
        public static readonly AppInfoPrimaryGenre Action
            = new AppInfoPrimaryGenre("Action");

        public static readonly AppInfoPrimaryGenre Adventure
            = new AppInfoPrimaryGenre("Adventure");

        public static readonly AppInfoPrimaryGenre Casual
            = new AppInfoPrimaryGenre("Casual");

        public static readonly AppInfoPrimaryGenre FreeToPlay
            = new AppInfoPrimaryGenre("FreeToPlay");

        public static readonly AppInfoPrimaryGenre Indie
            = new AppInfoPrimaryGenre("Indie");

        public static readonly AppInfoPrimaryGenre MassivelyMultiplayer
            = new AppInfoPrimaryGenre("MassivelyMultiplayer");

        public static readonly AppInfoPrimaryGenre RPG
            = new AppInfoPrimaryGenre("RPG");

        public static readonly AppInfoPrimaryGenre Racing
            = new AppInfoPrimaryGenre("Racing");

        public static readonly AppInfoPrimaryGenre Simulation
            = new AppInfoPrimaryGenre("Simulation");

        public static readonly AppInfoPrimaryGenre Sports
            = new AppInfoPrimaryGenre("Sports");

        public static readonly AppInfoPrimaryGenre Strategy
            = new AppInfoPrimaryGenre("Strategy");


        public static implicit operator AppInfoPrimaryGenre(string value)
        {
            return NewValue(value);
        }

        public AppInfoPrimaryGenre(string enumValue)
            : base(enumValue)
        {

        }
    }    
}