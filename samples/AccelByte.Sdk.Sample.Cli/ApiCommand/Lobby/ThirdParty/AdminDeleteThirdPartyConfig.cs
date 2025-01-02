// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby", "admindeletethirdpartyconfig")]
    public class AdminDeleteThirdPartyConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "AdminDeleteThirdPartyConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminDeleteThirdPartyConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.ThirdParty wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.ThirdParty(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminDeleteThirdPartyConfig.Builder;





            AdminDeleteThirdPartyConfig operation = opBuilder.Build(
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.AdminDeleteThirdPartyConfig(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}