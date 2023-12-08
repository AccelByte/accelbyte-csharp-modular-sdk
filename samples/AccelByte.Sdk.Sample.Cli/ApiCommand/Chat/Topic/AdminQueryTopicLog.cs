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
    [SdkConsoleCommand("chat","adminquerytopiclog")]
    public class AdminQueryTopicLogCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Chat"; } }

        public string OperationName{ get { return "AdminQueryTopicLog"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endCreatedAt")]
        public long? EndCreatedAt { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("senderUserId")]
        public string? SenderUserId { get; set; }

        [SdkCommandArgument("startCreatedAt")]
        public long? StartCreatedAt { get; set; }

        [SdkCommandArgument("topicId")]
        public string? TopicId { get; set; }

        [SdkCommandArgument("topicIds")]
        public List<string>? TopicIds { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminQueryTopicLogCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Topic wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Topic(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminQueryTopicLog.Builder;

            if (EndCreatedAt != null)
                opBuilder.SetEndCreatedAt((long)EndCreatedAt);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SenderUserId != null)
                opBuilder.SetSenderUserId((string)SenderUserId);
            if (StartCreatedAt != null)
                opBuilder.SetStartCreatedAt((long)StartCreatedAt);
            if (TopicId != null)
                opBuilder.SetTopicId((string)TopicId);
            if (TopicIds != null)
                opBuilder.SetTopicIds((List<string>)TopicIds);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminQueryTopicLog operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Chat.Model.ModelsTopicLogWithPaginationResponse? response = wrapper.AdminQueryTopicLog(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}