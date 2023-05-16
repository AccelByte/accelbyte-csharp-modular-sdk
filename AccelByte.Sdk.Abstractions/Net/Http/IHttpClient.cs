// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Core.Net.Http
{
    public interface IHttpClient
    {
        IHttpResponse SendRequest(IOperation operation, String baseUrl);

        IHttpClient SetLogger(IHttpLogger logger);
    }
}