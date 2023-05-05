// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","unlocksteamuserachievement")]
    public class UnlockSteamUserAchievementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UnlockSteamUserAchievement"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SteamAchievementUpdateRequest Body { get; set; } = new SteamAchievementUpdateRequest();
                
        public UnlockSteamUserAchievementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.AchievementPlatform wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.AchievementPlatform(_SDK);

            UnlockSteamUserAchievement operation = new UnlockSteamUserAchievement(
                Namespace,                
                UserId,                
                Body                
            );            
            
            wrapper.UnlockSteamUserAchievement(operation);
            return String.Empty;
        }
    }
}