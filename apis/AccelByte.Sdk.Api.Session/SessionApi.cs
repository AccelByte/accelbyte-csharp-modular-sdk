// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Session;

namespace AccelByte.Sdk.Api.Session
{
    public class SessionApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Operations Operations
        {
            get
            {
                if (_Operations == null)
                    _Operations = new Wrapper.Operations(_Sdk);
                return _Operations;
            }
        }
        private Wrapper.Operations? _Operations = null;

        public Wrapper.DSMCDefaultConfiguration DSMCDefaultConfiguration
        {
            get
            {
                if (_DSMCDefaultConfiguration == null)
                    _DSMCDefaultConfiguration = new Wrapper.DSMCDefaultConfiguration(_Sdk);
                return _DSMCDefaultConfiguration;
            }
        }
        private Wrapper.DSMCDefaultConfiguration? _DSMCDefaultConfiguration = null;

        public Wrapper.ConfigurationTemplate ConfigurationTemplate
        {
            get
            {
                if (_ConfigurationTemplate == null)
                    _ConfigurationTemplate = new Wrapper.ConfigurationTemplate(_Sdk);
                return _ConfigurationTemplate;
            }
        }
        private Wrapper.ConfigurationTemplate? _ConfigurationTemplate = null;

        public Wrapper.GameSession GameSession
        {
            get
            {
                if (_GameSession == null)
                    _GameSession = new Wrapper.GameSession(_Sdk);
                return _GameSession;
            }
        }
        private Wrapper.GameSession? _GameSession = null;

        public Wrapper.Party Party
        {
            get
            {
                if (_Party == null)
                    _Party = new Wrapper.Party(_Sdk);
                return _Party;
            }
        }
        private Wrapper.Party? _Party = null;

        public Wrapper.Player Player
        {
            get
            {
                if (_Player == null)
                    _Player = new Wrapper.Player(_Sdk);
                return _Player;
            }
        }
        private Wrapper.Player? _Player = null;

        internal SessionApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class SessionApi_SdkExts
    {
        public static SessionApi GetSessionApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<SessionApi>("session", () =>
            {
                return new SessionApi(sdk);
            });
        }
    }
}