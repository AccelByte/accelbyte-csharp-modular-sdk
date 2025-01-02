// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("chat", "admintopicchathistory")]
    public class AdminTopicChatHistoryCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminTopicChatHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("topic")]
        public string Topic { get; set; } = String.Empty;

        [SdkCommandArgument("endCreatedAt")]
        public long? EndCreatedAt { get; set; }

        [SdkCommandArgument("keyword")]
        public string? Keyword { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("order")]
        public string? Order { get; set; }

        [SdkCommandArgument("senderUserId")]
        public string? SenderUserId { get; set; }

        [SdkCommandArgument("shardId")]
        public string? ShardId { get; set; }

        [SdkCommandArgument("startCreatedAt")]
        public long? StartCreatedAt { get; set; }

        [SdkCommandArgument("unfiltered")]
        public bool? Unfiltered { get; set; }

        public AdminTopicChatHistoryCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminTopicChatHistory.Builder;

            if (EndCreatedAt != null)
                opBuilder.SetEndCreatedAt((long)EndCreatedAt);
            if (Keyword != null)
                opBuilder.SetKeyword((string)Keyword);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Order != null)
                opBuilder.SetOrder((string)Order);
            if (SenderUserId != null)
                opBuilder.SetSenderUserId((string)SenderUserId);
            if (ShardId != null)
                opBuilder.SetShardId((string)ShardId);
            if (StartCreatedAt != null)
                opBuilder.SetStartCreatedAt((long)StartCreatedAt);
            if (Unfiltered != null)
                opBuilder.SetUnfiltered((bool)Unfiltered);




            AdminTopicChatHistory operation = opBuilder.Build(
                Namespace,
                Topic
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.AdminTopicChatHistory(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}