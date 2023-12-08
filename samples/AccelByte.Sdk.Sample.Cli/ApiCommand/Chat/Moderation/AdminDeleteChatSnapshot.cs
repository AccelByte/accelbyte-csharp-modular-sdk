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
    [SdkConsoleCommand("chat","admindeletechatsnapshot")]
    public class AdminDeleteChatSnapshotCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminDeleteChatSnapshot"; } }

        [SdkCommandArgument("chatId")]
        public string ChatId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminDeleteChatSnapshotCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Moderation wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Moderation(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminDeleteChatSnapshot.Builder;





            AdminDeleteChatSnapshot operation = opBuilder.Build(
                ChatId,
                Namespace
            );


            wrapper.AdminDeleteChatSnapshot(operation);
            return String.Empty;
        }
    }
}