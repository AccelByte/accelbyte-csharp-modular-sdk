// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Net.Logging;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Core.Pipeline;

namespace AccelByte.Sdk.Core
{
    public interface IAccelByteSdkBuilder<T>
    {
        IAccelByteSdkBuilder<T> SetHttpClient(IHttpClient client);

        IAccelByteSdkBuilder<T> SetTokenRepository(ITokenRepository repository);

        IAccelByteSdkBuilder<T> SetConfigRepository(IConfigRepository repository);

        IAccelByteSdkBuilder<T> SetCredentialRepository(ICredentialRepository credential);

        IAccelByteSdkBuilder<T> SetLogger(IHttpLogger logger);

        IAccelByteSdkBuilder<T> SetTokenValidator(ITokenValidator tokenValidator);

        IAccelByteSdkBuilder<T> AddOperationProcess(IOperationProcess opProcess);

        IAccelByteSdkBuilder<T> RegisterService(ISdkService service);

        IAccelByteSdkBuilder<T> EnableLog();

        IAccelByteSdkBuilder<T> SetFlag(string key, bool value);

        IAccelByteSdkBuilder<T> UnsetFlag(string key);

        IAccelByteSdkBuilder<T> RegisterEvent(string key, object eventAction);

        T Build();
    }
}
