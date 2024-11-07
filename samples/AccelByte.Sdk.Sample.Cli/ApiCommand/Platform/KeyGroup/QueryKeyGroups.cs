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
    [SdkConsoleCommand("platform","querykeygroups")]
    public class QueryKeyGroupsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryKeyGroups"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("tag")]
        public string? Tag { get; set; }

        public QueryKeyGroupsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.KeyGroup wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.KeyGroup(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryKeyGroups.Builder;

            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Name != null)
                opBuilder.SetName((string)Name);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Tag != null)
                opBuilder.SetTag((string)Tag);




            QueryKeyGroups operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.QueryKeyGroups(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}