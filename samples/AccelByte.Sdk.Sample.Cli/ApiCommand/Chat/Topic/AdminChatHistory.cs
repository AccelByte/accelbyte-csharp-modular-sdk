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
    [SdkConsoleCommand("chat","adminchathistory")]
    public class AdminChatHistoryCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminChatHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("chatId")]
        public List<string>? ChatId { get; set; }

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

        [SdkCommandArgument("topic")]
        public List<string>? Topic { get; set; }

        [SdkCommandArgument("unfiltered")]
        public bool? Unfiltered { get; set; }

        public AdminChatHistoryCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminChatHistory.Builder;

            if (ChatId != null)
                opBuilder.SetChatId((List<string>)ChatId);
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
            if (Topic != null)
                opBuilder.SetTopic((List<string>)Topic);
            if (Unfiltered != null)
                opBuilder.SetUnfiltered((bool)Unfiltered);




            AdminChatHistory operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminChatHistory(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}