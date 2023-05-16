// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Feature.LocalTokenValidation
{
    public static class SdkBuilder_ExtensionMethods
    {
        public static IAccelByteSdkBuilder<T> UseLocalTokenValidator<T>(this IAccelByteSdkBuilder<T> builder)
        {
            builder.SetTokenValidator(new LocalTokenValidator());
            return builder;
        }

        public static IAccelByteSdkBuilder<T> UseAutoRefreshForTokenRevocationList<T>(this IAccelByteSdkBuilder<T> builder)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(60000);
            builder.RegisterService(refresher);
            return builder;
        }

        public static IAccelByteSdkBuilder<T> UseAutoRefreshForTokenRevocationList<T>(this IAccelByteSdkBuilder<T> builder, int refreshInterval)
        {
            TokenRevocationListRefresher refresher = new TokenRevocationListRefresher(refreshInterval);
            builder.RegisterService(refresher);
            return builder;
        }
    }
}