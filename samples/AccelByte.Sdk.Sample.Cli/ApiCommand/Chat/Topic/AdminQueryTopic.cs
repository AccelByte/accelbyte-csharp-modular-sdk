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
    [SdkConsoleCommand("chat", "adminquerytopic")]
    public class AdminQueryTopicCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminQueryTopic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("includeMembers")]
        public bool? IncludeMembers { get; set; }

        [SdkCommandArgument("includePastMembers")]
        public bool? IncludePastMembers { get; set; }

        [SdkCommandArgument("includePastTopics")]
        public bool? IncludePastTopics { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("topic")]
        public List<string>? Topic { get; set; }

        [SdkCommandArgument("topicSubType")]
        public string? TopicSubType { get; set; }

        [SdkCommandArgument("topicType")]
        public string? TopicType { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminQueryTopicCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminQueryTopic.Builder;

            if (IncludeMembers != null)
                opBuilder.SetIncludeMembers((bool)IncludeMembers);
            if (IncludePastMembers != null)
                opBuilder.SetIncludePastMembers((bool)IncludePastMembers);
            if (IncludePastTopics != null)
                opBuilder.SetIncludePastTopics((bool)IncludePastTopics);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Topic != null)
                opBuilder.SetTopic((List<string>)Topic);
            if (TopicSubType != null)
                opBuilder.SetTopicSubType(AdminQueryTopicTopicSubType.NewValue(TopicSubType));
            if (TopicType != null)
                opBuilder.SetTopicType(AdminQueryTopicTopicType.NewValue(TopicType));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminQueryTopic operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminQueryTopic(operation);
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
        }
    }
}