// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Dslogmanager.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ArmadaIntegration")]
    [Explicit]
    public class DSLogManagerTests : BaseServiceTests
    {
        public DSLogManagerTests() : base(true) { }

        [Test]
        public void DSLogManagerServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            _ = _Sdk.GetDslogmanagerApi().TerminatedServers.ListTerminatedServersOp
                .SetLimit(10)
                .Execute(_Sdk.Namespace)
                .Ok();
        }
    }
}
