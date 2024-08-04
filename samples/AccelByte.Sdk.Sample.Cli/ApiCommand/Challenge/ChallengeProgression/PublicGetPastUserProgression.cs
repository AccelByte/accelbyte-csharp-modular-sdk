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
    [SdkConsoleCommand("challenge", "publicgetpastuserprogression")]
    public class PublicGetPastUserProgressionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "PublicGetPastUserProgression"; } }

        [SdkCommandArgument("challengeCode")]
        public string ChallengeCode { get; set; } = String.Empty;

        [SdkCommandArgument("index")]
        public long Index { get; set; } = 0;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("goalCode")]
        public string? GoalCode { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        public PublicGetPastUserProgressionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeProgression(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.PublicGetPastUserProgression.Builder;

            if (GoalCode != null)
                opBuilder.SetGoalCode((string)GoalCode);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);




            PublicGetPastUserProgression operation = opBuilder.Build(
                ChallengeCode,
                Index,
                Namespace
            );


            AccelByte.Sdk.Api.Challenge.Model.ModelUserProgressionResponse? response = wrapper.PublicGetPastUserProgression(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}