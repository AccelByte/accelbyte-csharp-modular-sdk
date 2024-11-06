// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class GdprTests : BaseServiceTests
    {
        public GdprTests() : base(true) { }

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
                .Ok();
            #endregion

            #region Get e-mail configuration
            List<string>? emails = _Sdk.GetGdprApi().Configuration.GetAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace)
                .Ok();
            #endregion
            Assert.IsNotNull(emails);

            #region Update e-mail configuration
            _Sdk.GetGdprApi().Configuration.UpdateAdminEmailConfigurationOp
                .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace)
                .Ok();
            #endregion

            #region Delete e-mail configuration
            _Sdk.GetGdprApi().Configuration.DeleteAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest })
                .Ok();
            #endregion
        }
    }
}
