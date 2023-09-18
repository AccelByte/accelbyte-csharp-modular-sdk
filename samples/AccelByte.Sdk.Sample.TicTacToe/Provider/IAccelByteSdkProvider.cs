// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Sample.TicTacToe.Provider
{
    public interface IAccelByteSdkProvider
    {
        public IAccelByteSdk Sdk { get; }
    }
}