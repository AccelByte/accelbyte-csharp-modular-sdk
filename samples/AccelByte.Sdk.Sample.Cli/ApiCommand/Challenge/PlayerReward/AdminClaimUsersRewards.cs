// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Challenge
{
    [SdkConsoleCommand("challenge","adminclaimusersrewards")]
    public class AdminClaimUsersRewardsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Challenge"; } }

        public string OperationName{ get { return "AdminClaimUsersRewards"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<ModelClaimUsersRewardsRequest> Body { get; set; } = new List<ModelClaimUsersRewardsRequest>();

        public AdminClaimUsersRewardsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.AdminClaimUsersRewards.Builder;





            AdminClaimUsersRewards operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.AdminClaimUsersRewards(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}