// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ugc;

namespace AccelByte.Sdk.Api.Ugc
{
    public class UgcApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.AdminChannel AdminChannel
        {
            get
            {
                if (_AdminChannel == null)
                    _AdminChannel = new Wrapper.AdminChannel(_Sdk);
                return _AdminChannel;
            }
        }
        private Wrapper.AdminChannel? _AdminChannel = null;

        public Wrapper.AdminContent AdminContent
        {
            get
            {
                if (_AdminContent == null)
                    _AdminContent = new Wrapper.AdminContent(_Sdk);
                return _AdminContent;
            }
        }
        private Wrapper.AdminContent? _AdminContent = null;

        public Wrapper.AdminGroup AdminGroup
        {
            get
            {
                if (_AdminGroup == null)
                    _AdminGroup = new Wrapper.AdminGroup(_Sdk);
                return _AdminGroup;
            }
        }
        private Wrapper.AdminGroup? _AdminGroup = null;

        public Wrapper.AdminTag AdminTag
        {
            get
            {
                if (_AdminTag == null)
                    _AdminTag = new Wrapper.AdminTag(_Sdk);
                return _AdminTag;
            }
        }
        private Wrapper.AdminTag? _AdminTag = null;

        public Wrapper.AdminType AdminType
        {
            get
            {
                if (_AdminType == null)
                    _AdminType = new Wrapper.AdminType(_Sdk);
                return _AdminType;
            }
        }
        private Wrapper.AdminType? _AdminType = null;

        public Wrapper.Anonymization Anonymization
        {
            get
            {
                if (_Anonymization == null)
                    _Anonymization = new Wrapper.Anonymization(_Sdk);
                return _Anonymization;
            }
        }
        private Wrapper.Anonymization? _Anonymization = null;

        public Wrapper.PublicContent PublicContent
        {
            get
            {
                if (_PublicContent == null)
                    _PublicContent = new Wrapper.PublicContent(_Sdk);
                return _PublicContent;
            }
        }
        private Wrapper.PublicContent? _PublicContent = null;

        public Wrapper.PublicFollow PublicFollow
        {
            get
            {
                if (_PublicFollow == null)
                    _PublicFollow = new Wrapper.PublicFollow(_Sdk);
                return _PublicFollow;
            }
        }
        private Wrapper.PublicFollow? _PublicFollow = null;

        public Wrapper.PublicLike PublicLike
        {
            get
            {
                if (_PublicLike == null)
                    _PublicLike = new Wrapper.PublicLike(_Sdk);
                return _PublicLike;
            }
        }
        private Wrapper.PublicLike? _PublicLike = null;

        public Wrapper.PublicDownloadCount PublicDownloadCount
        {
            get
            {
                if (_PublicDownloadCount == null)
                    _PublicDownloadCount = new Wrapper.PublicDownloadCount(_Sdk);
                return _PublicDownloadCount;
            }
        }
        private Wrapper.PublicDownloadCount? _PublicDownloadCount = null;

        public Wrapper.PublicTag PublicTag
        {
            get
            {
                if (_PublicTag == null)
                    _PublicTag = new Wrapper.PublicTag(_Sdk);
                return _PublicTag;
            }
        }
        private Wrapper.PublicTag? _PublicTag = null;

        public Wrapper.PublicType PublicType
        {
            get
            {
                if (_PublicType == null)
                    _PublicType = new Wrapper.PublicType(_Sdk);
                return _PublicType;
            }
        }
        private Wrapper.PublicType? _PublicType = null;

        public Wrapper.PublicCreator PublicCreator
        {
            get
            {
                if (_PublicCreator == null)
                    _PublicCreator = new Wrapper.PublicCreator(_Sdk);
                return _PublicCreator;
            }
        }
        private Wrapper.PublicCreator? _PublicCreator = null;

        public Wrapper.PublicChannel PublicChannel
        {
            get
            {
                if (_PublicChannel == null)
                    _PublicChannel = new Wrapper.PublicChannel(_Sdk);
                return _PublicChannel;
            }
        }
        private Wrapper.PublicChannel? _PublicChannel = null;

        public Wrapper.PublicGroup PublicGroup
        {
            get
            {
                if (_PublicGroup == null)
                    _PublicGroup = new Wrapper.PublicGroup(_Sdk);
                return _PublicGroup;
            }
        }
        private Wrapper.PublicGroup? _PublicGroup = null;

        internal UgcApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class UgcApi_SdkExts
    {
        public static UgcApi GetUgcApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<UgcApi>("ugc", () =>
            {
                return new UgcApi(sdk);
            });
        }
    }
}