// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking","updateplaytimeweight")]
    public class UpdatePlayTimeWeightCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "UpdatePlayTimeWeight"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdatePlayTimeWeightRequest Body { get; set; } = new ModelsUpdatePlayTimeWeightRequest();

        public UpdatePlayTimeWeightCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.SocialMatchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.SocialMatchmaking(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.UpdatePlayTimeWeight.Builder;





            UpdatePlayTimeWeight operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.UpdatePlayTimeWeight(operation);
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