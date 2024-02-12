// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Cloudsave;

namespace AccelByte.Sdk.Api.Cloudsave
{
    public class CloudsaveApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.AdminRecord AdminRecord
        {
            get
            {
                if (_AdminRecord == null)
                    _AdminRecord = new Wrapper.AdminRecord(_Sdk);
                return _AdminRecord;
            }
        }
        private Wrapper.AdminRecord? _AdminRecord = null;

        public Wrapper.AdminGameBinaryRecord AdminGameBinaryRecord
        {
            get
            {
                if (_AdminGameBinaryRecord == null)
                    _AdminGameBinaryRecord = new Wrapper.AdminGameBinaryRecord(_Sdk);
                return _AdminGameBinaryRecord;
            }
        }
        private Wrapper.AdminGameBinaryRecord? _AdminGameBinaryRecord = null;

        public Wrapper.TTLConfig TTLConfig
        {
            get
            {
                if (_TTLConfig == null)
                    _TTLConfig = new Wrapper.TTLConfig(_Sdk);
                return _TTLConfig;
            }
        }
        private Wrapper.TTLConfig? _TTLConfig = null;

        public Wrapper.AdminConcurrentRecord AdminConcurrentRecord
        {
            get
            {
                if (_AdminConcurrentRecord == null)
                    _AdminConcurrentRecord = new Wrapper.AdminConcurrentRecord(_Sdk);
                return _AdminConcurrentRecord;
            }
        }
        private Wrapper.AdminConcurrentRecord? _AdminConcurrentRecord = null;

        public Wrapper.PluginConfig PluginConfig
        {
            get
            {
                if (_PluginConfig == null)
                    _PluginConfig = new Wrapper.PluginConfig(_Sdk);
                return _PluginConfig;
            }
        }
        private Wrapper.PluginConfig? _PluginConfig = null;

        public Wrapper.AdminGameRecord AdminGameRecord
        {
            get
            {
                if (_AdminGameRecord == null)
                    _AdminGameRecord = new Wrapper.AdminGameRecord(_Sdk);
                return _AdminGameRecord;
            }
        }
        private Wrapper.AdminGameRecord? _AdminGameRecord = null;

        public Wrapper.Tags Tags
        {
            get
            {
                if (_Tags == null)
                    _Tags = new Wrapper.Tags(_Sdk);
                return _Tags;
            }
        }
        private Wrapper.Tags? _Tags = null;

        public Wrapper.AdminPlayerRecord AdminPlayerRecord
        {
            get
            {
                if (_AdminPlayerRecord == null)
                    _AdminPlayerRecord = new Wrapper.AdminPlayerRecord(_Sdk);
                return _AdminPlayerRecord;
            }
        }
        private Wrapper.AdminPlayerRecord? _AdminPlayerRecord = null;

        public Wrapper.AdminPlayerBinaryRecord AdminPlayerBinaryRecord
        {
            get
            {
                if (_AdminPlayerBinaryRecord == null)
                    _AdminPlayerBinaryRecord = new Wrapper.AdminPlayerBinaryRecord(_Sdk);
                return _AdminPlayerBinaryRecord;
            }
        }
        private Wrapper.AdminPlayerBinaryRecord? _AdminPlayerBinaryRecord = null;

        public Wrapper.PublicGameBinaryRecord PublicGameBinaryRecord
        {
            get
            {
                if (_PublicGameBinaryRecord == null)
                    _PublicGameBinaryRecord = new Wrapper.PublicGameBinaryRecord(_Sdk);
                return _PublicGameBinaryRecord;
            }
        }
        private Wrapper.PublicGameBinaryRecord? _PublicGameBinaryRecord = null;

        public Wrapper.ConcurrentRecord ConcurrentRecord
        {
            get
            {
                if (_ConcurrentRecord == null)
                    _ConcurrentRecord = new Wrapper.ConcurrentRecord(_Sdk);
                return _ConcurrentRecord;
            }
        }
        private Wrapper.ConcurrentRecord? _ConcurrentRecord = null;

        public Wrapper.PublicGameRecord PublicGameRecord
        {
            get
            {
                if (_PublicGameRecord == null)
                    _PublicGameRecord = new Wrapper.PublicGameRecord(_Sdk);
                return _PublicGameRecord;
            }
        }
        private Wrapper.PublicGameRecord? _PublicGameRecord = null;

        public Wrapper.PublicPlayerBinaryRecord PublicPlayerBinaryRecord
        {
            get
            {
                if (_PublicPlayerBinaryRecord == null)
                    _PublicPlayerBinaryRecord = new Wrapper.PublicPlayerBinaryRecord(_Sdk);
                return _PublicPlayerBinaryRecord;
            }
        }
        private Wrapper.PublicPlayerBinaryRecord? _PublicPlayerBinaryRecord = null;

        public Wrapper.PublicPlayerRecord PublicPlayerRecord
        {
            get
            {
                if (_PublicPlayerRecord == null)
                    _PublicPlayerRecord = new Wrapper.PublicPlayerRecord(_Sdk);
                return _PublicPlayerRecord;
            }
        }
        private Wrapper.PublicPlayerRecord? _PublicPlayerRecord = null;

        internal CloudsaveApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class CloudsaveApi_SdkExts
    {
        public static CloudsaveApi GetCloudsaveApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<CloudsaveApi>("cloudsave", () =>
            {
                return new CloudsaveApi(sdk);
            });
        }
    }
}