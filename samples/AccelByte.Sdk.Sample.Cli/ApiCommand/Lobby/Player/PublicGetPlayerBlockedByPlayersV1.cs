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
    [SdkConsoleCommand("lobby","publicgetplayerblockedbyplayersv1")]
    public class PublicGetPlayerBlockedByPlayersV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "PublicGetPlayerBlockedByPlayersV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGetPlayerBlockedByPlayersV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Player wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Player(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.PublicGetPlayerBlockedByPlayersV1.Builder;





            PublicGetPlayerBlockedByPlayersV1 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Lobby.Model.ModelsGetAllPlayerBlockedByUsersResponse? response = wrapper.PublicGetPlayerBlockedByPlayersV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}