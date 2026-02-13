// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod
{
    public abstract class BaseIntegrationTest
    {
        protected IAccelByteSdk? _Sdk = null;

        protected bool IsUsingAGSStarter(IConfigRepository configRepo)
        {
            return configRepo.BaseUrl.Contains("gamingservices.accelbyte.io");
        }

        protected bool IsUsingAGSStarter()
        {
            if (_Sdk != null)
                return IsUsingAGSStarter(_Sdk.Configuration.ConfigRepository);
            return false;
        }
    }
}
