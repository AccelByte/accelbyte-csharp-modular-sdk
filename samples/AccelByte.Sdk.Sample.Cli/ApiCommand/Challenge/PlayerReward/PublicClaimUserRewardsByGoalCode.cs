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
    [SdkConsoleCommand("challenge", "publicclaimuserrewardsbygoalcode")]
    public class PublicClaimUserRewardsByGoalCodeCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "PublicClaimUserRewardsByGoalCode"; } }

        [SdkCommandArgument("challengeCode")]
        public string ChallengeCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelClaimUserRewardsByGoalCodeRequest Body { get; set; } = new ModelClaimUserRewardsByGoalCodeRequest();

        public PublicClaimUserRewardsByGoalCodeCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.PublicClaimUserRewardsByGoalCode.Builder;





            PublicClaimUserRewardsByGoalCode operation = opBuilder.Build(
                Body,
                ChallengeCode,
                Namespace
            );


            List<AccelByte.Sdk.Api.Challenge.Model.ModelUserReward>? response = wrapper.PublicClaimUserRewardsByGoalCode(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}