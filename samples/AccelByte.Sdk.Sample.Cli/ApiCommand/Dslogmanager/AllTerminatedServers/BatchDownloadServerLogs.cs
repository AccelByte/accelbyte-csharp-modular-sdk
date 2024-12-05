// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dslogmanager
{
    [SdkConsoleCommand("dslogmanager", "batchdownloadserverlogs")]
    public class BatchDownloadServerLogsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dslogmanager"; } }

        public string OperationName { get { return "BatchDownloadServerLogs"; } }

        [SdkCommandData("body")]
        public ModelsBatchDownloadLogsRequest Body { get; set; } = new ModelsBatchDownloadLogsRequest();

        public BatchDownloadServerLogsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dslogmanager.Operation.BatchDownloadServerLogs.Builder;





            BatchDownloadServerLogs operation = opBuilder.Build(
                Body
            );


            var response = wrapper.BatchDownloadServerLogs(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(response.Data.ReadToString());
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