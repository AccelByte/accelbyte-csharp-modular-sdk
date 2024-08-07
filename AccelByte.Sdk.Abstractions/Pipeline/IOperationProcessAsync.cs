﻿// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Pipeline
{
    public interface IOperationProcessAsync
    {
        Task<IOperation> HandleAsync(IOperation operation, IAccelByteSdk sdk);
    }
}
