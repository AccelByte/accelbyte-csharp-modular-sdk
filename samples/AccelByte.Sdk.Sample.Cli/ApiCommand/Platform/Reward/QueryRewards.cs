// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","queryrewards")]
    public class QueryRewardsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryRewards"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("eventTopic")]
        public string? EventTopic { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public List<string>? SortBy { get; set; }

        public QueryRewardsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Reward wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Reward(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryRewards.Builder;

            if (EventTopic != null)
                opBuilder.SetEventTopic((string)EventTopic);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(QueryRewardsSortBy.NewValue(SortBy));




            QueryRewards operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Platform.Model.RewardPagingSlicedResult? response = wrapper.QueryRewards(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}