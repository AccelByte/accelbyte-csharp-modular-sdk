// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2", "deletematchpool")]
    public class DeleteMatchPoolCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Match2"; } }

        public string OperationName { get { return "DeleteMatchPool"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("pool")]
        public string Pool { get; set; } = String.Empty;

        public DeleteMatchPoolCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.MatchPools wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.MatchPools(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Match2.Operation.DeleteMatchPool.Builder;





            DeleteMatchPool operation = opBuilder.Build(
                Namespace,
                Pool
            );


            var response = wrapper.DeleteMatchPool(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}