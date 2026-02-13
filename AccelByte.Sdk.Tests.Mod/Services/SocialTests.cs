// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class SocialTests : BaseServiceTests
    {
        public SocialTests() : base(true, IntegrationTestConfigRepository.Statistics) { }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();
            string stat_code = $"csharpsdktest-{random.GenerateRandomAlphabet(4).ToLower()}";

            #region Create a stat
            StatCreate createStat = new StatCreate()
            {
                Name = "CSharp Extend SDK Test Stat",
                Description = "CSharp extend sdk integration test.",
                StatCode = stat_code,
                SetBy = "SERVER",
                Minimum = 0.0,
                Maximum = 100.0,
                DefaultValue = 50.0,
                IncrementOnly = true,
                SetAsGlobal = false,
                Tags = new List<string>() { "csharp", "extend_sdk", "test" }
            };

            StatInfo cStat = _Sdk.GetSocialApi().StatConfiguration.CreateStatOp
                .Execute(createStat, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("CSharp Extend SDK Test Stat", cStat.Name);

            #region Get a stat
            StatInfo gStat = _Sdk.GetSocialApi().StatConfiguration.GetStatOp
                .Execute(_Sdk.Namespace, stat_code)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("CSharp Extend SDK Test Stat", gStat.Name);

            #region Update a stat
            StatUpdate updateStat = new StatUpdate()
            {
                Description = "Updated description."
            };

            StatInfo uStat = _Sdk.GetSocialApi().StatConfiguration.UpdateStatOp
                .Execute(updateStat, _Sdk.Namespace, stat_code)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("Updated description.", uStat.Description);

            #region Delete a stat
            _Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code)
                .EnsureSuccess();
            #endregion
        }

        [Test]
        public void ExportImportStatTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();
            string stat_code = $"csharpsdktest-{random.GenerateRandomAlphabet(4).ToLower()}";

            #region Create stat config
            var newStat = _Sdk.GetSocialApi().StatConfiguration.CreateStatOp
                .Execute(new StatCreate()
                {
                    Name = "CSharp Extend SDK Test Stat",
                    Description = "CSharp Extend Sdk integration test.",
                    StatCode = stat_code,
                    SetBy = "SERVER",
                    Minimum = 0.0,
                    Maximum = 100.0,
                    DefaultValue = 50.0,
                    IncrementOnly = true,
                    SetAsGlobal = false,
                    IsPublic = false,
                    Tags = new List<string>() { "csharp", "extend_sdk", "test" }
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(newStat);

            #region Get Stats
            var statData = _Sdk.GetSocialApi().StatConfiguration.GetStatsOp
                .SetOffset(0)
                .SetLimit(50)
                .SetIsGlobal(false)
                .SetIsPublic(false)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            bool isFound = false;
            if (statData.Data != null && statData.Data.Count > 0)
            {
                foreach (var statItem in statData.Data)
                {
                    if (statItem.StatCode! == stat_code)
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            Assert.IsTrue(isFound);

            #region Export stat config
            var exportStream = _Sdk.GetSocialApi().StatConfiguration.ExportStatsOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            string exportStr = exportStream.ReadToString();

            //delete first
            #region Delete a stat config
            _Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion

            MemoryStream importStream = new MemoryStream(Encoding.UTF8.GetBytes(exportStr));
            var importStatus = _Sdk.GetSocialApi().StatConfiguration.ImportStatsOp
                .SetFile(importStream)
                .SetReplaceExisting(true)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            Assert.IsNotNull(importStatus);

            #region Query Stats
            statData = _Sdk.GetSocialApi().StatConfiguration.QueryStatsOp
                .Execute(_Sdk.Namespace, "csharp")
                .EnsureSuccess();
            #endregion

            isFound = false;
            if (statData.Data != null && statData.Data.Count > 0)
            {
                foreach (var statItem in statData.Data)
                {
                    if (statItem.StatCode! == stat_code)
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            Assert.IsTrue(isFound);

            //delete again
            _Sdk.GetSocialApi().StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code)
                .EnsureSuccess();
        }
    }
}
