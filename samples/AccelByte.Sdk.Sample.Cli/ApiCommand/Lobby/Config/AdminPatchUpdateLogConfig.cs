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
    [SdkConsoleCommand("lobby", "adminpatchupdatelogconfig")]
    public class AdminPatchUpdateLogConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "AdminPatchUpdateLogConfig"; } }

        [SdkCommandData("body")]
        public LogconfigConfiguration Body { get; set; } = new LogconfigConfiguration();

        public AdminPatchUpdateLogConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminPatchUpdateLogConfig.Builder;





            AdminPatchUpdateLogConfig operation = opBuilder.Build(
                Body
            );


            var response = wrapper.AdminPatchUpdateLogConfig(operation);
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