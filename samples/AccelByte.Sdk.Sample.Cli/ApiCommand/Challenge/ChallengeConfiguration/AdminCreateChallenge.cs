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
    [SdkConsoleCommand("challenge","admincreatechallenge")]
    public class AdminCreateChallengeCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Challenge"; } }

        public string OperationName{ get { return "AdminCreateChallenge"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelCreateChallengeRequest Body { get; set; } = new ModelCreateChallengeRequest();

        public AdminCreateChallengeCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeConfiguration wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.ChallengeConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.AdminCreateChallenge.Builder;





            AdminCreateChallenge operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.AdminCreateChallenge(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}