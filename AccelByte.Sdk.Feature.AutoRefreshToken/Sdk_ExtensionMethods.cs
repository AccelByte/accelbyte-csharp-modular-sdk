// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public static class SdkBuilder_ExtensionMethods
    {
        public static IAccelByteSdkBuilder<T> UseOnDemandTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder, OnDemandTokenRefreshOptions options)
            => builder.AddOperationProcess(new AutoTokenRefreshOperationProcess(options));

        public static IAccelByteSdkBuilder<T> UseOnDemandTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder)
            => builder.UseOnDemandTokenRefresh(OnDemandTokenRefreshOptions.Default);

        public static IAccelByteSdkBuilder<T> UseBackgroundTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder, BackgroundTokenRefreshOptions options)
            => builder.RegisterService(new BackgroundAccessTokenRefresher(options));

        public static IAccelByteSdkBuilder<T> UseBackgroundTokenRefresh<T>(this IAccelByteSdkBuilder<T> builder)
            => builder.UseBackgroundTokenRefresh(BackgroundTokenRefreshOptions.Default);
    }
}