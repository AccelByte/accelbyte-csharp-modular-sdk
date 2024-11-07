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
    [SdkConsoleCommand("matchmaking","adduserintosessioninchannel")]
    public class AddUserIntoSessionInChannelCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "AddUserIntoSessionInChannel"; } }

        [SdkCommandArgument("channelName")]
        public string ChannelName { get; set; } = String.Empty;

        [SdkCommandArgument("matchID")]
        public string MatchID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsMatchAddUserIntoSessionRequest Body { get; set; } = new ModelsMatchAddUserIntoSessionRequest();

        public AddUserIntoSessionInChannelCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.AddUserIntoSessionInChannel.Builder;





            AddUserIntoSessionInChannel operation = opBuilder.Build(
                Body,
                ChannelName,
                MatchID,
                Namespace
            );


            var response = wrapper.AddUserIntoSessionInChannel(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}