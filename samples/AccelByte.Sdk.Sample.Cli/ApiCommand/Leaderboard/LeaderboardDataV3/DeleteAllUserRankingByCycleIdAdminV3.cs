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
    [SdkConsoleCommand("leaderboard","deletealluserrankingbycycleidadminv3")]
    public class DeleteAllUserRankingByCycleIdAdminV3Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "DeleteAllUserRankingByCycleIdAdminV3"; } }

        [SdkCommandArgument("cycleId")]
        public string CycleId { get; set; } = String.Empty;

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteAllUserRankingByCycleIdAdminV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.DeleteAllUserRankingByCycleIdAdminV3.Builder;





            DeleteAllUserRankingByCycleIdAdminV3 operation = opBuilder.Build(
                CycleId,
                LeaderboardCode,
                Namespace
            );


            var response = wrapper.DeleteAllUserRankingByCycleIdAdminV3(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}