// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ams;

namespace AccelByte.Sdk.Api.Ams
{
    public class AmsApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Account Account
        {
            get
            {
                if (_Account == null)
                    _Account = new Wrapper.Account(_Sdk);
                return _Account;
            }
        }
        private Wrapper.Account? _Account = null;

        public Wrapper.Fleets Fleets
        {
            get
            {
                if (_Fleets == null)
                    _Fleets = new Wrapper.Fleets(_Sdk);
                return _Fleets;
            }
        }
        private Wrapper.Fleets? _Fleets = null;

        public Wrapper.Servers Servers
        {
            get
            {
                if (_Servers == null)
                    _Servers = new Wrapper.Servers(_Sdk);
                return _Servers;
            }
        }
        private Wrapper.Servers? _Servers = null;

        public Wrapper.Images Images
        {
            get
            {
                if (_Images == null)
                    _Images = new Wrapper.Images(_Sdk);
                return _Images;
            }
        }
        private Wrapper.Images? _Images = null;

        public Wrapper.AMSInfo AMSInfo
        {
            get
            {
                if (_AMSInfo == null)
                    _AMSInfo = new Wrapper.AMSInfo(_Sdk);
                return _AMSInfo;
            }
        }
        private Wrapper.AMSInfo? _AMSInfo = null;

        public Wrapper.Watchdogs Watchdogs
        {
            get
            {
                if (_Watchdogs == null)
                    _Watchdogs = new Wrapper.Watchdogs(_Sdk);
                return _Watchdogs;
            }
        }
        private Wrapper.Watchdogs? _Watchdogs = null;

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

        internal AmsApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class AmsApi_SdkExts
    {
        public static AmsApi GetAmsApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<AmsApi>("ams", () =>
            {
                return new AmsApi(sdk);
            });            
        }
    }
}