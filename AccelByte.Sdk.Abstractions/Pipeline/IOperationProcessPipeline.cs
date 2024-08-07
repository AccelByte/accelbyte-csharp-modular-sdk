﻿// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Pipeline
{
    public interface IOperationProcessPipeline
    {
        void AppendToChain(IOperationProcess handler);

        void PrependToChain(IOperationProcess handler);

        IOperation RunProcessPipeline(IOperation op, IAccelByteSdk sdk);

        Task<IOperation> RunProcessPipelineAsync(IOperation op, IAccelByteSdk sdk);
    }
}
