// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Pipeline;

namespace AccelByte.Sdk.Feature.AutoTokenRefresh
{
    public class AutoTokenRefreshOperationProcess : BaseTokenRefresher, IOperationProcess, IOperationProcessAsync
    {
        public IOperationProcess? Next { get; set; }

        public AutoTokenRefreshOperationProcess(OnDemandTokenRefreshOptions options)
            : base(options) { }

        public IOperation Handle(IOperation operation, IAccelByteSdk sdk)
        {
            DoRefreshToken(sdk, null, null, true);
            return operation;
        }

        public async Task<IOperation> HandleAsync(IOperation operation, IAccelByteSdk sdk)
        {
            await DoRefreshTokenAsync(sdk, null, null, true);
            return operation;
        }
    }
}