// Copyright (c) 2025-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Loginqueue.Model;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LoginQueueTests : BaseServiceTests
    {
        public LoginQueueTests() : base(false, IntegrationTestConfigRepository.Admin) { }

        [Test]
        public void ConfigurationTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            int updateMaxLoginRate = 100;

            #region Get configuration
            var config = _Sdk.GetLoginqueueApi().AdminV1.AdminGetConfigurationOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(config);

            #region Update configuration
            var configUpdate = _Sdk.GetLoginqueueApi().AdminV1.AdminUpdateConfigurationOp
                .Execute(new ApimodelsConfigurationRequest()
                {
                    MaxLoginRate = updateMaxLoginRate
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(configUpdate);
            if (configUpdate != null)
                Assert.AreEqual(updateMaxLoginRate, configUpdate.MaxLoginRate);
        }
    }
}
