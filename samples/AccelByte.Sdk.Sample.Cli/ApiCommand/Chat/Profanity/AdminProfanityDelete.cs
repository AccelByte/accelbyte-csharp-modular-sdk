// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat","adminprofanitydelete")]
    public class AdminProfanityDeleteCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminProfanityDelete"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminProfanityDeleteCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Profanity(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminProfanityDelete.Builder;





            AdminProfanityDelete operation = opBuilder.Build(
                Id,
                Namespace
            );


            var response = wrapper.AdminProfanityDelete(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}