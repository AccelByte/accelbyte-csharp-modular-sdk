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
    [SdkConsoleCommand("leaderboard", "createleaderboardconfigurationadminv3")]
    public class CreateLeaderboardConfigurationAdminV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "CreateLeaderboardConfigurationAdminV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsLeaderboardConfigReqV3 Body { get; set; } = new ModelsLeaderboardConfigReqV3();

        public CreateLeaderboardConfigurationAdminV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.CreateLeaderboardConfigurationAdminV3.Builder;





            CreateLeaderboardConfigurationAdminV3 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetLeaderboardConfigRespV3? response = wrapper.CreateLeaderboardConfigurationAdminV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}