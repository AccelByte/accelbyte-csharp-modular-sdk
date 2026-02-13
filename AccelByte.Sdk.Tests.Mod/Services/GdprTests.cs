// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Tests.Mod.Scenario;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class GdprTests : BaseServiceTests
    {
        public GdprTests() : base(true, IntegrationTestConfigRepository.Admin) { }

        [Test]
        public void GdprServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string firstEmailToTest = "dummy@example.com";
            string anotherEmailToTest = "anotheremail@dummy.com";

            #region Save e-mail configuration
            _Sdk.GetGdprApi().Configuration.SaveAdminEmailConfigurationOp
                .Execute(new List<string>
                {
                    firstEmailToTest
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Get e-mail configuration
            List<string>? emails = _Sdk.GetGdprApi().Configuration.GetAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(emails);

            #region Update e-mail configuration
            _Sdk.GetGdprApi().Configuration.UpdateAdminEmailConfigurationOp
                .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Delete e-mail configuration
            _Sdk.GetGdprApi().Configuration.DeleteAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest })
                .EnsureSuccess();
            #endregion
        }

        [Test]
        public void PersonalDataTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            ITestPlayer player1 = new NewTestPlayer(_Sdk, true);
            try
            {
                string userId = player1.UserId;

                #region Get user personal data request
                var pdRequest = _Sdk.GetGdprApi().DataRetrieval.AdminGetUserPersonalDataRequestsOp
                    .SetOffset(0)
                    .SetLimit(10)
                    .Execute(_Sdk.Namespace, userId)
                    .EnsureSuccess();
                #endregion
                Assert.IsNotNull(pdRequest);
            }
            finally
            {
                player1.Logout();
            }
        }
    }
}
