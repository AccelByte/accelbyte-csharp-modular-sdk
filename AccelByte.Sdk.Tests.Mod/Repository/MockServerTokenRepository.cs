// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Net.Logging;

namespace AccelByte.Sdk.Tests.Mod.Repository
{
    public class MockServerTokenRepository : DefaultTokenRepository
    {
        public MockServerTokenRepository()
        {
            Token = "foo";
        }
    }
}