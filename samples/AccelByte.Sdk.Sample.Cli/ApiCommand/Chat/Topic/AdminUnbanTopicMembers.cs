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
    [SdkConsoleCommand("chat", "adminunbantopicmembers")]
    public class AdminUnbanTopicMembersCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminUnbanTopicMembers"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("topic")]
        public string Topic { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUnbanTopicMemberParam Body { get; set; } = new ModelsUnbanTopicMemberParam();

        public AdminUnbanTopicMembersCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminUnbanTopicMembers.Builder;





            AdminUnbanTopicMembers operation = opBuilder.Build(
                Body,
                Namespace,
                Topic
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsUnbanTopicMemberResult? response = wrapper.AdminUnbanTopicMembers(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}