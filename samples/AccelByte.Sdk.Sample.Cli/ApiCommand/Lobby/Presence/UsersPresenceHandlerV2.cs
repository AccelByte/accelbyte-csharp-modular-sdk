// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","userspresencehandlerv2")]
    public class UsersPresenceHandlerV2Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "UsersPresenceHandlerV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("countOnly")]
        public bool? CountOnly { get; set; }

        [SdkCommandData("body")]
        public ModelRequestUserPresence Body { get; set; } = new ModelRequestUserPresence();

        public UsersPresenceHandlerV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Presence wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Presence(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.UsersPresenceHandlerV2.Builder;

            if (CountOnly != null)
                opBuilder.SetCountOnly((bool)CountOnly);




            UsersPresenceHandlerV2 operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.UsersPresenceHandlerV2(operation);
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