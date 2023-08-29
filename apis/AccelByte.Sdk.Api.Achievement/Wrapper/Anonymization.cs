// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Api.Achievement.Wrapper
{
    public class Anonymization
    {
        private readonly IAccelByteSdk _sdk;

        public Anonymization(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminAnonymizeUserAchievement.AdminAnonymizeUserAchievementBuilder AdminAnonymizeUserAchievementOp
        {
            get { return new Operation.AdminAnonymizeUserAchievement.AdminAnonymizeUserAchievementBuilder(_sdk); }
        }
        #endregion

        public void AdminAnonymizeUserAchievement(AdminAnonymizeUserAchievement input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}