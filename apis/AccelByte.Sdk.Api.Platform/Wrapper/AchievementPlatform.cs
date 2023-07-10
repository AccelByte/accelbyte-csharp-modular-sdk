// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class AchievementPlatform
    {
        private readonly IAccelByteSdk _sdk;

        public AchievementPlatform(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UnlockSteamUserAchievement.UnlockSteamUserAchievementBuilder UnlockSteamUserAchievementOp
        {
            get { return new Operation.UnlockSteamUserAchievement.UnlockSteamUserAchievementBuilder(_sdk); }
        }
        public GetXblUserAchievements.GetXblUserAchievementsBuilder GetXblUserAchievementsOp
        {
            get { return new Operation.GetXblUserAchievements.GetXblUserAchievementsBuilder(_sdk); }
        }
        public UpdateXblUserAchievement.UpdateXblUserAchievementBuilder UpdateXblUserAchievementOp
        {
            get { return new Operation.UpdateXblUserAchievement.UpdateXblUserAchievementBuilder(_sdk); }
        }
        #endregion

        public void UnlockSteamUserAchievement(UnlockSteamUserAchievement input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.XblUserAchievements? GetXblUserAchievements(GetXblUserAchievements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateXblUserAchievement(UpdateXblUserAchievement input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}