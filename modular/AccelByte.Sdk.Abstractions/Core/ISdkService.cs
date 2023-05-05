// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core
{
    public interface ISdkService
    {
        void Start(IAccelByteSdk sdk);

        void Stop();
    }
}
