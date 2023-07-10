// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Qosm;

namespace AccelByte.Sdk.Api.Qosm
{
    public class QosmApi : ISdkApi
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

        internal QosmApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class QosmApi_SdkExts
    {
        public static QosmApi GetQosmApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<QosmApi>("qosm", () =>
            {
                return new QosmApi(sdk);
            });
        }
    }
}