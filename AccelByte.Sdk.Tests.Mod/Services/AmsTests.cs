// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class AmsTests : BaseServiceTests
    {
        public AmsTests() : base(false) { }

        [Test]
        public void InfoTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            _Sdk.GetAmsApi().Operations.PortalHealthCheckOp.Execute();

            ApiRegionsResponse? regions = _Sdk.GetAmsApi().AMSInfo.InfoRegionsOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(regions);
            Assert.GreaterOrEqual(regions!.Regions!.Count, 1);

            ApiAvailableInstanceTypesResponse? instances = _Sdk.GetAmsApi().AMSInfo.InfoSupportedInstancesOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(instances);
            Assert.GreaterOrEqual(instances!.AvailableInstanceTypes!.Count, 1);

            ResetPolicy();
        }
    }
}
