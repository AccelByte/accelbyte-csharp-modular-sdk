// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class SocialTests : BaseServiceTests
    {
        public SocialTests() : base(true) { }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string stat_code = "csharpserversdkteststat";

            #region Create a stat
            StatCreate createStat = new StatCreate()
            {
                Name = "CSharp Server SDK Test Stat",
                Description = "CSharp server sdk integration test.",
                StatCode = stat_code,
                SetBy = "SERVER",
                Minimum = 0.0,
                Maximum = 100.0,
                DefaultValue = 50.0,
                IncrementOnly = true,
                SetAsGlobal = false,
                Tags = new List<string>() { "csharp", "server_sdk", "test" }
            };

            StatInfo? cStat = _Sdk.GetSocialApi().StatConfiguration.CreateStatOp
                .SetBody(createStat)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", cStat.Name);

            #region Get a stat
            StatInfo? gStat = _Sdk.GetSocialApi().StatConfiguration.GetStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
            Assert.IsNotNull(gStat);
            if (gStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", gStat.Name);

            #region Update a stat
            StatUpdate updateStat = new StatUpdate()
            {
                Description = "Updated description."
            };

            StatInfo? uStat = _Sdk.GetSocialApi().StatConfiguration.UpdateStatOp
                .SetBody(updateStat)
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
            Assert.IsNotNull(uStat);
            if (uStat != null)
                Assert.AreEqual("Updated description.", uStat.Description);

            #region Delete a stat
            _Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
        }
    }
}
