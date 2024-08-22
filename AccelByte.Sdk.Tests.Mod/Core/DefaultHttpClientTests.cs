// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Tests.Mod.Core
{
    [TestFixture(Category = "DefaultHttpClient")]
    public class DefaultHttpClientTests : BaseHttpBinRequestTests
    {
        protected override IHttpClient GetHttpClientObject()
        {
            return new DefaultHttpClient();
        }
    }
}