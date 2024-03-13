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
    [SdkConsoleCommand("challenge", "publicgetuserprogression")]
    public class PublicGetUserProgressionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "PublicGetUserProgression"; } }

        [SdkCommandArgument("challengeCode")]
        public string ChallengeCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("goalCode")]
        public string? GoalCode { get; set; }

        public PublicGetUserProgressionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.PublicGetUserProgression.Builder;

            if (GoalCode != null)
                opBuilder.SetGoalCode((string)GoalCode);




            PublicGetUserProgression operation = opBuilder.Build(
                ChallengeCode,
                Namespace
            );


            AccelByte.Sdk.Api.Challenge.Model.ModelUserProgressionResponse? response = wrapper.PublicGetUserProgression(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}