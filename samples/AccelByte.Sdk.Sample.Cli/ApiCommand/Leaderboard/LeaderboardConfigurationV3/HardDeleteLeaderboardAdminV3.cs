// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("leaderboard", "harddeleteleaderboardadminv3")]
    public class HardDeleteLeaderboardAdminV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "HardDeleteLeaderboardAdminV3"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public HardDeleteLeaderboardAdminV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.HardDeleteLeaderboardAdminV3.Builder;





            HardDeleteLeaderboardAdminV3 operation = opBuilder.Build(
                LeaderboardCode,
                Namespace
            );


            var response = wrapper.HardDeleteLeaderboardAdminV3(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}