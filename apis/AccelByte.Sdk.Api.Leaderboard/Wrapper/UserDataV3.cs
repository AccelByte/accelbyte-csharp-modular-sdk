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

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class UserDataV3
    {
        private readonly IAccelByteSdk _sdk;

        public UserDataV3(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserLeaderboardRankingsAdminV3.GetUserLeaderboardRankingsAdminV3Builder GetUserLeaderboardRankingsAdminV3Op
        {
            get { return new Operation.GetUserLeaderboardRankingsAdminV3.GetUserLeaderboardRankingsAdminV3Builder(_sdk); }
        }
        #endregion

        public Model.ModelsGetAllUserLeaderboardsRespV3? GetUserLeaderboardRankingsAdminV3(GetUserLeaderboardRankingsAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllUserLeaderboardsRespV3?> GetUserLeaderboardRankingsAdminV3Async(GetUserLeaderboardRankingsAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}