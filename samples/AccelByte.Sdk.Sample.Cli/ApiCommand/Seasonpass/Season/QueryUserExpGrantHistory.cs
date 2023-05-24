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

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","queryuserexpgranthistory")]
    public class QueryUserExpGrantHistoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "QueryUserExpGrantHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("from")]
        public string? From { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("seasonId")]
        public string? SeasonId { get; set; }

        [SdkCommandArgument("source")]
        public string? Source { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        [SdkCommandArgument("to")]
        public string? To { get; set; }

        public QueryUserExpGrantHistoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.QueryUserExpGrantHistory.Builder;

            if (From != null)
                opBuilder.SetFrom((string)From);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (SeasonId != null)
                opBuilder.SetSeasonId((string)SeasonId);
            if (Source != null)
                opBuilder.SetSource(QueryUserExpGrantHistorySource.NewValue(Source));
            if (Tags != null)
                opBuilder.SetTags((List<string>)Tags);
            if (To != null)
                opBuilder.SetTo((string)To);




            QueryUserExpGrantHistory operation = opBuilder.Build(
                Namespace,
                UserId
            );

            
            AccelByte.Sdk.Api.Seasonpass.Model.ExpGrantHistoryPagingSlicedResult? response = wrapper.QueryUserExpGrantHistory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}