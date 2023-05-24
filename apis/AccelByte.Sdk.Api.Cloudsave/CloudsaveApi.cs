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