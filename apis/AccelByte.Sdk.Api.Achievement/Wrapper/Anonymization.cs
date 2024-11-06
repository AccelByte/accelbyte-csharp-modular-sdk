// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class Anonymization
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Anonymization(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Anonymization(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminAnonymizeUserAchievement.AdminAnonymizeUserAchievementBuilder AdminAnonymizeUserAchievementOp
        {
            get
            {
                var opBuilder = new Operation.AdminAnonymizeUserAchievement.AdminAnonymizeUserAchievementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminAnonymizeUserAchievement.Response AdminAnonymizeUserAchievement(AdminAnonymizeUserAchievement input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminAnonymizeUserAchievement.Response> AdminAnonymizeUserAchievementAsync(AdminAnonymizeUserAchievement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}