// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Sample.AsyncOperation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int iteration = 5;

            Console.WriteLine("AccelByte .NET (C#) Extend SDK Async Operation Sample");
            Stopwatch sw = new Stopwatch();

            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .Build();

            StartSyncOpsSample(sw, sdk, iteration);

            await StartAsyncOpsSample(sw, sdk, iteration);

            await StartAsyncOpsWithWhenAnyAndWhenAllSample(sw, sdk, iteration);

            await Task.CompletedTask;
        }

        static ModelsAchievementRequest CreateAchievementData(string aCode)
        {
            string aName = $"Achievement Test {aCode.ToUpper()}";
            return new ModelsAchievementRequest()
            {
                AchievementCode = aCode,
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", aName }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                },
                GoalValue = 1000.0,
                StatCode = aCode,
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
        }

        static async Task<ModelsAchievementResponse> CreateAchievementAsync(IAccelByteSdk sdk)
        {
            Random rand = new Random();
            string aCode = $"cs{rand.GenerateRandomId(6)}";
            var newAchievement = CreateAchievementData(aCode);
            ModelsAchievementResponse? cResp = await sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                .ExecuteAsync(newAchievement, sdk.Namespace);
            if (cResp != null)
                return cResp;
            else
                throw new Exception("NULL response!");
        }

        static void StartSyncOpsSample(Stopwatch sw, IAccelByteSdk sdk, int iteration)
        {
            sw.Restart();
            sdk.LoginClient();
            Random rand = new Random();

            List<string> achievementCodes = new List<string>();
            for (int i = 0; i < iteration; i++)
            {
                string aCode = $"cs{rand.GenerateRandomId(6)}";

                //Create achievement
                var newAchievement = CreateAchievementData(aCode);
                ModelsAchievementResponse? cResp = sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                    .Execute(newAchievement, sdk.Namespace);
                if (cResp != null)
                    achievementCodes.Add(cResp.AchievementCode!);

                //Delete achievement
                sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                    .Execute(aCode, sdk.Namespace);
            }

            foreach (var code in achievementCodes)
                Console.WriteLine($"\t{code}");

            sdk.Logout();
            sw.Stop();
            Console.WriteLine($"Sync Ops: {sw.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }

        static async Task StartAsyncOpsSample(Stopwatch sw, IAccelByteSdk sdk, int iteration)
        {
            sw.Restart();
            sdk.LoginClient();
            Random rand = new Random();

            List<string> achievementCodes = new List<string>();
            for (int i = 0; i < iteration; i++)
            {
                string aCode = $"cs{rand.GenerateRandomId(6)}";

                //Create achievement
                var newAchievement = CreateAchievementData(aCode);
                ModelsAchievementResponse? cResp = await sdk.GetAchievementApi().Achievements.AdminCreateNewAchievementOp
                    .ExecuteAsync(newAchievement, sdk.Namespace);
                if (cResp != null)
                    achievementCodes.Add(cResp.AchievementCode!);

                //Delete achievement
                await sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                    .ExecuteAsync(aCode, sdk.Namespace);
            }

            foreach (var code in achievementCodes)
                Console.WriteLine($"\t{code}");

            sdk.Logout();
            sw.Stop();
            Console.WriteLine($"Async Ops: {sw.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }

        static async Task StartAsyncOpsWithWhenAnyAndWhenAllSample(Stopwatch sw, IAccelByteSdk sdk, int iteration)
        {
            sw.Restart();
            await sdk.LoginClientAsync();

            List<Task<ModelsAchievementResponse>> createTasks = new();
            for (int i = 0; i < iteration; i++)
            {
                createTasks.Add(CreateAchievementAsync(sdk));
            }

            List<Task> deleteTasks = new();
            while (createTasks.Count > 0)
            {
                var fTask = await Task.WhenAny(createTasks);
                var aCode = fTask.Result.AchievementCode!;

                Console.WriteLine($"\t{aCode}");
                deleteTasks.Add(sdk.GetAchievementApi().Achievements.AdminDeleteAchievementOp
                    .ExecuteAsync(aCode, sdk.Namespace));
                createTasks.Remove(fTask);
            }

            await Task.WhenAll(deleteTasks);

            sdk.Logout();
            sw.Stop();
            Console.WriteLine($"Async WhenAnyWhenAll Ops: {sw.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }
    }
}