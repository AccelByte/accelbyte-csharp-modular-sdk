// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CustomOperation;

namespace AccelByte.Sdk.Sample.CustomOperation
{
    public class MyCustomApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private MyCustomWrapper? _MyCustomWrapper = null;

        public MyCustomWrapper MyCustomWrapper
        {
            get
            {
                if (_MyCustomWrapper == null)
                    _MyCustomWrapper = new MyCustomWrapper(_Sdk);
                return _MyCustomWrapper;
            }
        }

        internal MyCustomApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

//You can use "AccelByte.Sdk.Api" to put your sdk object extension, or use your own namespace.
namespace AccelByte.Sdk.Api
{
    public static class MyCustomApi_SdkExts
    {
        public static MyCustomApi GetMyCustomApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<MyCustomApi>("my_custom_api", () =>
            {
                return new MyCustomApi(sdk);
            });
        }
    }
}
