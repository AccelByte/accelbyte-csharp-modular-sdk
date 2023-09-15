// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Sample.TicTacToe.Provider
{
    public class DefaultAccelByteSdkProvider : IAccelByteSdkProvider
    {
        public IAccelByteSdk Sdk { get; private set; }

        public DefaultAccelByteSdkProvider(IServerCommandArguments cArgs)
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.MaxRetryCount = 1000;
            policy.RetryInterval = 1000;

            //retry logic for claim server if server is not ready
            policy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

            var builder = AccelByteSdk.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(policy)
                    .Build())
                .UseDefaultTokenRepository();
            if (cArgs.SdkConfigFile != String.Empty)
                builder.UseJsonConfigRepository(cArgs.SdkConfigFile);
            else
                builder.UseDefaultConfigRepository();
            if (cArgs.IsLogEnabled)
                builder.EnableLog();

            Sdk = builder.Build();
        }
    }
}