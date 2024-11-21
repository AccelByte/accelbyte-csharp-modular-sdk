// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class AchievementTests : BaseServiceTests
    {
        public class ExportAchievementItem
        {
            [JsonPropertyName("AchievementCode")]
            public string AchievementCode { get; set; } = "";
        }

        public AchievementTests() : base(true) { }

        [Test]
        public void AchievementServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string achievement_code = "csharp-sdk-test-3";
            string achievement_name = "CSharp Extend SDK Test 3";

            #region Create an achievement
            ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
            {
                AchievementCode = achievement_code,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", achievement_name }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                },
                GoalValue = 1000.0,
                StatCode = achievement_code,
                Hidden = true,
                Incremental = false,
                LockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-locked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/50000f325ef841a6972a005779e20991.png"
                    }
                },
                UnlockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-unlocked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/fe89fd07102f4057be202fbd3fdd9a21.png"
                    }
                },
                Tags = new List<string>() { "sdk", "test", "csharp" }
            };

            ModelsAchievementResponse cResp = _Sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                .Execute(newAchievement, _Sdk.Namespace).EnsureSuccess();
            #endregion
            Assert.AreEqual(cResp?.AchievementCode!, achievement_code);

            #region Updating achievement
            ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
            {
                GoalValue = 2000.0,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", achievement_name }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                }
            };

            ModelsAchievementResponse uResp = _Sdk.GetAchievementApi().Achievements.AdminUpdateAchievementOp
                .Execute(updateAchievement, achievement_code, _Sdk.Namespace).EnsureSuccess();
            #endregion
            Assert.AreEqual(uResp?.GoalValue!, 2000.0);

            #region Retrieve achievement by code
            ModelsAchievementResponse rResp = _Sdk.GetAchievementApi().Achievements.AdminGetAchievementOp
                .Execute(achievement_code, _Sdk.Namespace).EnsureSuccess();
            #endregion
            Assert.AreEqual(rResp?.GoalValue!, 2000.0);
            Assert.AreEqual(rResp?.Name!["en"], achievement_name);

            #region Get all achievements
            ModelsPaginatedAchievementResponse gaResp = _Sdk.GetAchievementApi().Achievements.AdminListAchievementsOp
                .SetLimit(100)
                .SetOffset(0)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.Greater(gaResp?.Data?.Count, 0);

            #region Delete an achievement
            _Sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                .Execute(achievement_code, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            //Finally, recheck if the data is truly deleted.
            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                DisableRetry();
                _ = _Sdk.GetAchievementApi().Achievements.AdminGetAchievementOp
                    .Execute(achievement_code, _Sdk.Namespace).EnsureSuccess();
            });
        }

        [Test]
        public void AchievementExportTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string achievement_code = "csharp-sdk-test-3";
            string achievement_name = "CSharp Extend SDK Test 3";

            ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
            {
                AchievementCode = achievement_code,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", achievement_name }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                },
                GoalValue = 1000.0,
                StatCode = achievement_code,
                Hidden = true,
                Incremental = false,
                LockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-locked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/50000f325ef841a6972a005779e20991.png"
                    }
                },
                UnlockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-unlocked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/fe89fd07102f4057be202fbd3fdd9a21.png"
                    }
                },
                Tags = new List<string>() { "sdk", "test", "csharp" }
            };

            ModelsAchievementResponse? cResp = _Sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                .Execute(newAchievement, _Sdk.Namespace)
                .EnsureSuccess();
            Assert.IsNotNull(cResp);
            Assert.AreEqual(cResp?.AchievementCode!, achievement_code);

            try
            {
                var exportStream = _Sdk.GetAchievementApi().Achievements.ExportAchievementsOp
                    .Execute(_Sdk.Namespace)
                    .EnsureSuccess();
                Assert.IsNotNull(exportStream);
                if (exportStream != null)
                {
                    string test = exportStream.ReadToString();
                    List<ExportAchievementItem>? items = JsonSerializer.Deserialize<List<ExportAchievementItem>>(test);
                    Assert.IsNotNull(items);
                    if (items != null)
                    {
                        var searchedItem = items.Where(e => e.AchievementCode == achievement_code).FirstOrDefault();
                        Assert.IsNotNull(searchedItem);
                    }
                }
            }
            finally
            {
                _Sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                    .Execute(achievement_code, _Sdk.Namespace)
                    .EnsureSuccess();
            }
        }

        [Test]
        public async Task AchievementAsyncServiceTests()
        {
            var retryPolicy = HttpClientPolicy.Default;
            retryPolicy.MaxRetryCount = 3;
            retryPolicy.RetryInterval = 500;
            retryPolicy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

            var sdk = AccelByteSdk.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(retryPolicy)
                    .Build())
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            await sdk.LoginUserAsync();

            string achievement_code = "csharp-sdk-test-3";
            string achievement_name = "CSharp Server SDK Test 3";

            ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
            {
                AchievementCode = achievement_code,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", achievement_name }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                },
                GoalValue = 1000.0,
                StatCode = achievement_code,
                Hidden = true,
                Incremental = false,
                LockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-locked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/50000f325ef841a6972a005779e20991.png"
                    }
                },
                UnlockedIcons = new List<ModelsIcon>()
                {
                    new ModelsIcon()
                    {
                        Slug = "shield-unlocked",
                        Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/fe89fd07102f4057be202fbd3fdd9a21.png"
                    }
                },
                Tags = new List<string>() { "sdk", "test", "csharp" }
            };

            var createResponse = await sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                .ExecuteAsync(newAchievement, sdk.Namespace);
            ModelsAchievementResponse cResp = createResponse.EnsureSuccess();
            Assert.AreEqual(cResp?.AchievementCode!, achievement_code);

            ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
            {
                GoalValue = 2000.0,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", achievement_name }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                }
            };

            var updateResponse = await sdk.GetAchievementApi().Achievements.AdminUpdateAchievementOp
                .ExecuteAsync(updateAchievement, achievement_code, sdk.Namespace);
            ModelsAchievementResponse uResp = updateResponse.EnsureSuccess();
            Assert.AreEqual(uResp?.GoalValue!, 2000.0);

            var getResponse = await sdk.GetAchievementApi().Achievements.AdminGetAchievementOp
                .ExecuteAsync(achievement_code, sdk.Namespace);
            ModelsAchievementResponse rResp = getResponse.EnsureSuccess();
            Assert.AreEqual(rResp?.GoalValue!, 2000.0);
            Assert.AreEqual(rResp?.Name!["en"], achievement_name);

            var listResponse = await sdk.GetAchievementApi().Achievements.AdminListAchievementsOp
                .SetLimit(100)
                .SetOffset(0)
                .ExecuteAsync(sdk.Namespace);
            ModelsPaginatedAchievementResponse gaResp = listResponse.EnsureSuccess();
            Assert.Greater(gaResp?.Data?.Count, 0);

            await sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                .ExecuteAsync(achievement_code, sdk.Namespace);

            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                retryPolicy.RetryOnException = false;
                sdk.GetAchievementApi().Achievements.AdminGetAchievementOp
                    .Execute(achievement_code, sdk.Namespace)
                    .EnsureSuccess();
            });
        }
    }
}