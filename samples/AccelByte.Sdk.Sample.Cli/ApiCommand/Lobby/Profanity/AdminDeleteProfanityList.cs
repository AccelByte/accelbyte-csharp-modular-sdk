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
    [SdkConsoleCommand("lobby","admindeleteprofanitylist")]
    public class AdminDeleteProfanityListCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminDeleteProfanityList"; } }

        [SdkCommandArgument("list")]
        public string List { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminDeleteProfanityListCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminDeleteProfanityList.Builder;





            AdminDeleteProfanityList operation = opBuilder.Build(
                List,
                Namespace
            );


            wrapper.AdminDeleteProfanityList(operation);
            return String.Empty;
        }
    }
}