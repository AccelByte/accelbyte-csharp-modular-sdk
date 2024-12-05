// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "queryorders")]
    public class QueryOrdersCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryOrders"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endTime")]
        public string? EndTime { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("orderNos")]
        public List<string>? OrderNos { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("startTime")]
        public string? StartTime { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("withTotal")]
        public bool? WithTotal { get; set; }

        public QueryOrdersCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Order wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Order(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryOrders.Builder;

            if (EndTime != null)
                opBuilder.SetEndTime((string)EndTime);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (OrderNos != null)
                opBuilder.SetOrderNos((List<string>)OrderNos);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (StartTime != null)
                opBuilder.SetStartTime((string)StartTime);
            if (Status != null)
                opBuilder.SetStatus(QueryOrdersStatus.NewValue(Status));
            if (WithTotal != null)
                opBuilder.SetWithTotal((bool)WithTotal);




            QueryOrders operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.QueryOrders(operation);
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