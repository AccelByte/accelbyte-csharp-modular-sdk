// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("social", "getstatcycles")]
    public class GetStatCyclesCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "GetStatCycles"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("cycleType")]
        public string? CycleType { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public GetStatCyclesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration wrapper = new AccelByte.Sdk.Api.Social.Wrapper.StatCycleConfiguration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.GetStatCycles.Builder;

            if (CycleType != null)
                opBuilder.SetCycleType(GetStatCyclesCycleType.NewValue(CycleType));
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Name != null)
                opBuilder.SetName((string)Name);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);
            if (Status != null)
                opBuilder.SetStatus(GetStatCyclesStatus.NewValue(Status));




            GetStatCycles operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.GetStatCycles(operation);
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