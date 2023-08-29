// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dslogmanager;

namespace AccelByte.Sdk.Api.Dslogmanager
{
    public class DslogmanagerApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Admin Admin
        {
            get
            {
                if (_Admin == null)
                    _Admin = new Wrapper.Admin(_Sdk);
                return _Admin;
            }
        }
        private Wrapper.Admin? _Admin = null;

        public Wrapper.TerminatedServers TerminatedServers
        {
            get
            {
                if (_TerminatedServers == null)
                    _TerminatedServers = new Wrapper.TerminatedServers(_Sdk);
                return _TerminatedServers;
            }
        }
        private Wrapper.TerminatedServers? _TerminatedServers = null;

        public Wrapper.AllTerminatedServers AllTerminatedServers
        {
            get
            {
                if (_AllTerminatedServers == null)
                    _AllTerminatedServers = new Wrapper.AllTerminatedServers(_Sdk);
                return _AllTerminatedServers;
            }
        }
        private Wrapper.AllTerminatedServers? _AllTerminatedServers = null;

        public Wrapper.DslogmanagerOperations DslogmanagerOperations
        {
            get
            {
                if (_DslogmanagerOperations == null)
                    _DslogmanagerOperations = new Wrapper.DslogmanagerOperations(_Sdk);
                return _DslogmanagerOperations;
            }
        }
        private Wrapper.DslogmanagerOperations? _DslogmanagerOperations = null;

        internal DslogmanagerApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class DslogmanagerApi_SdkExts
    {
        public static DslogmanagerApi GetDslogmanagerApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<DslogmanagerApi>("dslogmanager", () =>
            {
                return new DslogmanagerApi(sdk);
            });
        }
    }
}