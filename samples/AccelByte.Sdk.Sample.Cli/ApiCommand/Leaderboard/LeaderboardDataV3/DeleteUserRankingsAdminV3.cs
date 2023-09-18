// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","deleteuserrankingsadminv3")]
    public class DeleteUserRankingsAdminV3Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "DeleteUserRankingsAdminV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("leaderboardCode")]
        public List<string> LeaderboardCode { get; set; } = new List<string>();

        public DeleteUserRankingsAdminV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.DeleteUserRankingsAdminV3.Builder;





            DeleteUserRankingsAdminV3 operation = opBuilder.Build(
                Namespace,
                UserId,
                LeaderboardCode
            );


            wrapper.DeleteUserRankingsAdminV3(operation);
            return String.Empty;
        }
    }
}