// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsmc;

namespace AccelByte.Sdk.Api.Dsmc
{
    public class DsmcApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Config Config
        {
            get
            {
                if (_Config == null)
                    _Config = new Wrapper.Config(_Sdk);
                return _Config;
            }
        }
        private Wrapper.Config? _Config = null;

        public Wrapper.ImageConfig ImageConfig
        {
            get
            {
                if (_ImageConfig == null)
                    _ImageConfig = new Wrapper.ImageConfig(_Sdk);
                return _ImageConfig;
            }
        }
        private Wrapper.ImageConfig? _ImageConfig = null;

        public Wrapper.PodConfig PodConfig
        {
            get
            {
                if (_PodConfig == null)
                    _PodConfig = new Wrapper.PodConfig(_Sdk);
                return _PodConfig;
            }
        }
        private Wrapper.PodConfig? _PodConfig = null;

        public Wrapper.DeploymentConfig DeploymentConfig
        {
            get
            {
                if (_DeploymentConfig == null)
                    _DeploymentConfig = new Wrapper.DeploymentConfig(_Sdk);
                return _DeploymentConfig;
            }
        }
        private Wrapper.DeploymentConfig? _DeploymentConfig = null;

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

        public Wrapper.Server Server
        {
            get
            {
                if (_Server == null)
                    _Server = new Wrapper.Server(_Sdk);
                return _Server;
            }
        }
        private Wrapper.Server? _Server = null;

        public Wrapper.Session Session
        {
            get
            {
                if (_Session == null)
                    _Session = new Wrapper.Session(_Sdk);
                return _Session;
            }
        }
        private Wrapper.Session? _Session = null;

        public Wrapper.Public Public
        {
            get
            {
                if (_Public == null)
                    _Public = new Wrapper.Public(_Sdk);
                return _Public;
            }
        }
        private Wrapper.Public? _Public = null;

        public Wrapper.DsmcOperations DsmcOperations
        {
            get
            {
                if (_DsmcOperations == null)
                    _DsmcOperations = new Wrapper.DsmcOperations(_Sdk);
                return _DsmcOperations;
            }
        }
        private Wrapper.DsmcOperations? _DsmcOperations = null;

        internal DsmcApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class DsmcApi_SdkExts
    {
        public static DsmcApi GetDsmcApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<DsmcApi>("dsmc", () =>
            {
                return new DsmcApi(sdk);
            });            
        }
    }
}