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
    [SdkConsoleCommand("platform","syncepicgamedlc")]
    public class SyncEpicGameDLCCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SyncEpicGameDLC"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public EpicGamesDLCSyncRequest Body { get; set; } = new EpicGamesDLCSyncRequest();

        public SyncEpicGameDLCCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.DLC wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.DLC(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.SyncEpicGameDLC.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.EpicGamesDLCSyncRequest)Body);



            SyncEpicGameDLC operation = opBuilder.Build(
                Namespace,
                UserId
            );


            var response = wrapper.SyncEpicGameDLC(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}