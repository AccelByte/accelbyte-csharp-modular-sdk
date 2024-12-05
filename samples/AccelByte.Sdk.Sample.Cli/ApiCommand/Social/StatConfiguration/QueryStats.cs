// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "querystats")]
    public class QueryStatsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "QueryStats"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("isGlobal")]
        public bool? IsGlobal { get; set; }

        [SdkCommandArgument("isPublic")]
        public bool? IsPublic { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("keyword")]
        public string Keyword { get; set; } = String.Empty;

        public QueryStatsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.QueryStats.Builder;

            if (IsGlobal != null)
                opBuilder.SetIsGlobal((bool)IsGlobal);
            if (IsPublic != null)
                opBuilder.SetIsPublic((bool)IsPublic);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);




            QueryStats operation = opBuilder.Build(
                Namespace,
                Keyword
            );


            var response = wrapper.QueryStats(operation);
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