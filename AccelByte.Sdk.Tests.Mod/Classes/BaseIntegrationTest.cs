// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Tests.Mod
{
    public abstract class BaseIntegrationTest
    {
        protected bool IsUsingAGSStarter(IAccelByteSdk sdk)
        {
            return sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io");
        }
    }
}
