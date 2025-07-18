// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Csm;

namespace AccelByte.Sdk.Api.Csm
{
    public class CsmApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.App App
        {
            get
            {
                if (_App == null)
                    _App = new Wrapper.App(_Sdk, _CustomBasePath);
                return _App;
            }
        }
        private Wrapper.App? _App = null;

        public Wrapper.Deployment Deployment
        {
            get
            {
                if (_Deployment == null)
                    _Deployment = new Wrapper.Deployment(_Sdk, _CustomBasePath);
                return _Deployment;
            }
        }
        private Wrapper.Deployment? _Deployment = null;

        public Wrapper.Image Image
        {
            get
            {
                if (_Image == null)
                    _Image = new Wrapper.Image(_Sdk, _CustomBasePath);
                return _Image;
            }
        }
        private Wrapper.Image? _Image = null;

        public Wrapper.Configuration Configuration
        {
            get
            {
                if (_Configuration == null)
                    _Configuration = new Wrapper.Configuration(_Sdk, _CustomBasePath);
                return _Configuration;
            }
        }
        private Wrapper.Configuration? _Configuration = null;

        public Wrapper.Messages Messages
        {
            get
            {
                if (_Messages == null)
                    _Messages = new Wrapper.Messages(_Sdk, _CustomBasePath);
                return _Messages;
            }
        }
        private Wrapper.Messages? _Messages = null;

        public Wrapper.AppV2 AppV2
        {
            get
            {
                if (_AppV2 == null)
                    _AppV2 = new Wrapper.AppV2(_Sdk, _CustomBasePath);
                return _AppV2;
            }
        }
        private Wrapper.AppV2? _AppV2 = null;

        public Wrapper.DeploymentV2 DeploymentV2
        {
            get
            {
                if (_DeploymentV2 == null)
                    _DeploymentV2 = new Wrapper.DeploymentV2(_Sdk, _CustomBasePath);
                return _DeploymentV2;
            }
        }
        private Wrapper.DeploymentV2? _DeploymentV2 = null;

        public Wrapper.ImageV2 ImageV2
        {
            get
            {
                if (_ImageV2 == null)
                    _ImageV2 = new Wrapper.ImageV2(_Sdk, _CustomBasePath);
                return _ImageV2;
            }
        }
        private Wrapper.ImageV2? _ImageV2 = null;

        public Wrapper.ConfigurationV2 ConfigurationV2
        {
            get
            {
                if (_ConfigurationV2 == null)
                    _ConfigurationV2 = new Wrapper.ConfigurationV2(_Sdk, _CustomBasePath);
                return _ConfigurationV2;
            }
        }
        private Wrapper.ConfigurationV2? _ConfigurationV2 = null;

        public Wrapper.NotificationSubscription NotificationSubscription
        {
            get
            {
                if (_NotificationSubscription == null)
                    _NotificationSubscription = new Wrapper.NotificationSubscription(_Sdk, _CustomBasePath);
                return _NotificationSubscription;
            }
        }
        private Wrapper.NotificationSubscription? _NotificationSubscription = null;

        public Wrapper.ResourcesLimits ResourcesLimits
        {
            get
            {
                if (_ResourcesLimits == null)
                    _ResourcesLimits = new Wrapper.ResourcesLimits(_Sdk, _CustomBasePath);
                return _ResourcesLimits;
            }
        }
        private Wrapper.ResourcesLimits? _ResourcesLimits = null;

        public Wrapper.NotificationSubscriptionV3 NotificationSubscriptionV3
        {
            get
            {
                if (_NotificationSubscriptionV3 == null)
                    _NotificationSubscriptionV3 = new Wrapper.NotificationSubscriptionV3(_Sdk, _CustomBasePath);
                return _NotificationSubscriptionV3;
            }
        }
        private Wrapper.NotificationSubscriptionV3? _NotificationSubscriptionV3 = null;

        internal CsmApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public CsmApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class CsmApi_SdkExts
    {
        public static CsmApi GetCsmApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<CsmApi>("csm", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("csm");
                if (customPath != "")
                    return (new CsmApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new CsmApi(sdk);
            });
        }
    }
}