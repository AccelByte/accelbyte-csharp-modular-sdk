// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session","adminreconcilemaxactivesession")]
    public class AdminReconcileMaxActiveSessionCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Session"; } }

        public string OperationName{ get { return "AdminReconcileMaxActiveSession"; } }

        [SdkCommandArgument("name")]
        public string Name { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsRequestReconcileMaxActiveSession Body { get; set; } = new ModelsRequestReconcileMaxActiveSession();

        public AdminReconcileMaxActiveSessionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.MaxActive wrapper = new AccelByte.Sdk.Api.Session.Wrapper.MaxActive(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminReconcileMaxActiveSession.Builder;





            AdminReconcileMaxActiveSession operation = opBuilder.Build(
                Body,
                Name,
                Namespace
            );


            var response = wrapper.AdminReconcileMaxActiveSession(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}