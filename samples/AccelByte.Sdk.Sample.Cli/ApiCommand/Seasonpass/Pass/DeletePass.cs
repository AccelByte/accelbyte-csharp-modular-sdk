// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass", "deletepass")]
    public class DeletePassCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Seasonpass"; } }

        public string OperationName { get { return "DeletePass"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        public DeletePassCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Pass(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Seasonpass.Operation.DeletePass.Builder;





            DeletePass operation = opBuilder.Build(
                Code,
                Namespace,
                SeasonId
            );


            var response = wrapper.DeletePass(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}