// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests.Mod.Scenario
{
    public interface ITestPlayer
    {
        string AccessToken { get; }

        string UserId { get; }

        void Login();

        void Logout();

        void Run(Action<IAccelByteSdk, ITestPlayer> action);
    }
}