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

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","updateleaderboardconfigurationadminv3")]
    public class UpdateLeaderboardConfigurationAdminV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "UpdateLeaderboardConfigurationAdminV3"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateLeaderboardConfigReqV3 Body { get; set; } = new ModelsUpdateLeaderboardConfigReqV3();
                
        public UpdateLeaderboardConfigurationAdminV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.UpdateLeaderboardConfigurationAdminV3.Builder;





            UpdateLeaderboardConfigurationAdminV3 operation = opBuilder.Build(
                Body,
                LeaderboardCode,
                Namespace
            );

            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetLeaderboardConfigRespV3? response = wrapper.UpdateLeaderboardConfigurationAdminV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}