// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

namespace AccelByte.Sdk.Core.Net.Http
{
    public interface IRetryLogicHandler
    {
        bool ExecuteRetryLogic(IHttpClientPolicy policy, int retryCount, Exception exception);
    }
}
