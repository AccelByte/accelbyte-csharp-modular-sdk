// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class AchievementPlatform
    {
        private readonly AccelByteSDK _sdk;

        public AchievementPlatform(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UnlockSteamUserAchievement.UnlockSteamUserAchievementBuilder UnlockSteamUserAchievementOp
        {
            get { return Operation.UnlockSteamUserAchievement.Builder.SetWrapperObject(this); }
        }
        public GetXblUserAchievements.GetXblUserAchievementsBuilder GetXblUserAchievementsOp
        {
            get { return Operation.GetXblUserAchievements.Builder.SetWrapperObject(this); }
        }
        public UpdateXblUserAchievement.UpdateXblUserAchievementBuilder UpdateXblUserAchievementOp
        {
            get { return Operation.UpdateXblUserAchievement.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public void UnlockSteamUserAchievement(UnlockSteamUserAchievement input) {
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
        public void UpdateXblUserAchievement(UpdateXblUserAchievement input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}