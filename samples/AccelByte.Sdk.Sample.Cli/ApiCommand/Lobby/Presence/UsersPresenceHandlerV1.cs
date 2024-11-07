// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("lobby","userspresencehandlerv1")]
    public class UsersPresenceHandlerV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "UsersPresenceHandlerV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("countOnly")]
        public bool? CountOnly { get; set; }

        [SdkCommandArgument("userIds")]
        public string UserIds { get; set; } = String.Empty;

        public UsersPresenceHandlerV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Presence wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Presence(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.UsersPresenceHandlerV1.Builder;

            if (CountOnly != null)
                opBuilder.SetCountOnly((bool)CountOnly);




            UsersPresenceHandlerV1 operation = opBuilder.Build(
                Namespace,
                UserIds
            );


            var response = wrapper.UsersPresenceHandlerV1(operation);
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