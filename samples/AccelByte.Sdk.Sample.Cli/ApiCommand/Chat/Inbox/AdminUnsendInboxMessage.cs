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
    [SdkConsoleCommand("chat","adminunsendinboxmessage")]
    public class AdminUnsendInboxMessageCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminUnsendInboxMessage"; } }

        [SdkCommandArgument("inbox")]
        public string Inbox { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUnsendInboxMessageRequest Body { get; set; } = new ModelsUnsendInboxMessageRequest();

        public AdminUnsendInboxMessageCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Inbox wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Inbox(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminUnsendInboxMessage.Builder;





            AdminUnsendInboxMessage operation = opBuilder.Build(
                Body,
                Inbox,
                Namespace
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsUnsendInboxMessageResponse? response = wrapper.AdminUnsendInboxMessage(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}