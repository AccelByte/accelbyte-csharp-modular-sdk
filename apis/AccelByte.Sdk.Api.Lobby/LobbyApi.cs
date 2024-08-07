// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Lobby;

namespace AccelByte.Sdk.Api.Lobby
{
    public class LobbyApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.Friends Friends
        {
            get
            {
                if (_Friends == null)
                    _Friends = new Wrapper.Friends(_Sdk, _CustomBasePath);
                return _Friends;
            }
        }
        private Wrapper.Friends? _Friends = null;

        public Wrapper.Blocks Blocks
        {
            get
            {
                if (_Blocks == null)
                    _Blocks = new Wrapper.Blocks(_Sdk, _CustomBasePath);
                return _Blocks;
            }
        }
        private Wrapper.Blocks? _Blocks = null;

        public Wrapper.Config Config
        {
            get
            {
                if (_Config == null)
                    _Config = new Wrapper.Config(_Sdk, _CustomBasePath);
                return _Config;
            }
        }
        private Wrapper.Config? _Config = null;

        public Wrapper.Admin Admin
        {
            get
            {
                if (_Admin == null)
                    _Admin = new Wrapper.Admin(_Sdk, _CustomBasePath);
                return _Admin;
            }
        }
        private Wrapper.Admin? _Admin = null;

        public Wrapper.Notification Notification
        {
            get
            {
                if (_Notification == null)
                    _Notification = new Wrapper.Notification(_Sdk, _CustomBasePath);
                return _Notification;
            }
        }
        private Wrapper.Notification? _Notification = null;

        public Wrapper.Party Party
        {
            get
            {
                if (_Party == null)
                    _Party = new Wrapper.Party(_Sdk, _CustomBasePath);
                return _Party;
            }
        }
        private Wrapper.Party? _Party = null;

        public Wrapper.LobbyOperations LobbyOperations
        {
            get
            {
                if (_LobbyOperations == null)
                    _LobbyOperations = new Wrapper.LobbyOperations(_Sdk, _CustomBasePath);
                return _LobbyOperations;
            }
        }
        private Wrapper.LobbyOperations? _LobbyOperations = null;

        public Wrapper.Player Player
        {
            get
            {
                if (_Player == null)
                    _Player = new Wrapper.Player(_Sdk, _CustomBasePath);
                return _Player;
            }
        }
        private Wrapper.Player? _Player = null;

        public Wrapper.Profanity Profanity
        {
            get
            {
                if (_Profanity == null)
                    _Profanity = new Wrapper.Profanity(_Sdk, _CustomBasePath);
                return _Profanity;
            }
        }
        private Wrapper.Profanity? _Profanity = null;

        public Wrapper.ThirdParty ThirdParty
        {
            get
            {
                if (_ThirdParty == null)
                    _ThirdParty = new Wrapper.ThirdParty(_Sdk, _CustomBasePath);
                return _ThirdParty;
            }
        }
        private Wrapper.ThirdParty? _ThirdParty = null;

        public Wrapper.Presence Presence
        {
            get
            {
                if (_Presence == null)
                    _Presence = new Wrapper.Presence(_Sdk, _CustomBasePath);
                return _Presence;
            }
        }
        private Wrapper.Presence? _Presence = null;

        internal LobbyApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public LobbyApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class LobbyApi_SdkExts
    {
        public static LobbyApi GetLobbyApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<LobbyApi>("lobby", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("lobby");
                if (customPath != "")
                    return (new LobbyApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new LobbyApi(sdk);
            });
        }
    }
}