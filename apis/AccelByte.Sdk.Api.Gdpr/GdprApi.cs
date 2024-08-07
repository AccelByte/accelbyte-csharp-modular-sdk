// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Gdpr;

namespace AccelByte.Sdk.Api.Gdpr
{
    public class GdprApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.DataDeletion DataDeletion
        {
            get
            {
                if (_DataDeletion == null)
                    _DataDeletion = new Wrapper.DataDeletion(_Sdk, _CustomBasePath);
                return _DataDeletion;
            }
        }
        private Wrapper.DataDeletion? _DataDeletion = null;

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

        public Wrapper.PlatformAccountClosureClient PlatformAccountClosureClient
        {
            get
            {
                if (_PlatformAccountClosureClient == null)
                    _PlatformAccountClosureClient = new Wrapper.PlatformAccountClosureClient(_Sdk, _CustomBasePath);
                return _PlatformAccountClosureClient;
            }
        }
        private Wrapper.PlatformAccountClosureClient? _PlatformAccountClosureClient = null;

        public Wrapper.DataRetrieval DataRetrieval
        {
            get
            {
                if (_DataRetrieval == null)
                    _DataRetrieval = new Wrapper.DataRetrieval(_Sdk, _CustomBasePath);
                return _DataRetrieval;
            }
        }
        private Wrapper.DataRetrieval? _DataRetrieval = null;

        public Wrapper.PlatformAccountClosureHistory PlatformAccountClosureHistory
        {
            get
            {
                if (_PlatformAccountClosureHistory == null)
                    _PlatformAccountClosureHistory = new Wrapper.PlatformAccountClosureHistory(_Sdk, _CustomBasePath);
                return _PlatformAccountClosureHistory;
            }
        }
        private Wrapper.PlatformAccountClosureHistory? _PlatformAccountClosureHistory = null;

        public Wrapper.DataDeletionS2S DataDeletionS2S
        {
            get
            {
                if (_DataDeletionS2S == null)
                    _DataDeletionS2S = new Wrapper.DataDeletionS2S(_Sdk, _CustomBasePath);
                return _DataDeletionS2S;
            }
        }
        private Wrapper.DataDeletionS2S? _DataDeletionS2S = null;

        public Wrapper.DataRetrievalS2S DataRetrievalS2S
        {
            get
            {
                if (_DataRetrievalS2S == null)
                    _DataRetrievalS2S = new Wrapper.DataRetrievalS2S(_Sdk, _CustomBasePath);
                return _DataRetrievalS2S;
            }
        }
        private Wrapper.DataRetrievalS2S? _DataRetrievalS2S = null;

        internal GdprApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public GdprApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class GdprApi_SdkExts
    {
        public static GdprApi GetGdprApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<GdprApi>("gdpr", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("gdpr");
                if (customPath != "")
                    return (new GdprApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new GdprApi(sdk);
            });
        }
    }
}