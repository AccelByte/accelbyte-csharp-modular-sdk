// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc", "deleteconfig")]
    public class DeleteConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "DeleteConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.DeleteConfig.Builder;





            DeleteConfig operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.DeleteConfig(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}