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
    [SdkConsoleCommand("lobby","adminbulkunblockplayersv1")]
    public class AdminBulkUnblockPlayersV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminBulkUnblockPlayersV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsListUnblockPlayerRequest Body { get; set; } = new ModelsListUnblockPlayerRequest();

        public AdminBulkUnblockPlayersV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Player wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Player(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminBulkUnblockPlayersV1.Builder;





            AdminBulkUnblockPlayersV1 operation = opBuilder.Build(
                Body,
                Namespace,
                UserId
            );


            var response = wrapper.AdminBulkUnblockPlayersV1(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}