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
    [SdkConsoleCommand("lobby", "syncnativeblockeduser")]
    public class SyncNativeBlockedUserCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "SyncNativeBlockedUser"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<ModelNativeUserBlockRequest> Body { get; set; } = new List<ModelNativeUserBlockRequest>();

        public SyncNativeBlockedUserCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Blocks wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Blocks(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.SyncNativeBlockedUser.Builder;





            SyncNativeBlockedUser operation = opBuilder.Build(
                Body,
                Namespace
            );


            List<AccelByte.Sdk.Api.Lobby.Model.ModelNativeUserBlockResponse>? response = wrapper.SyncNativeBlockedUser(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}