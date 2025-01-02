// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("dslogmanager", "downloadserverlogs")]
    public class DownloadServerLogsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dslogmanager"; } }

        public string OperationName { get { return "DownloadServerLogs"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("podName")]
        public string PodName { get; set; } = String.Empty;

        public DownloadServerLogsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dslogmanager.Operation.DownloadServerLogs.Builder;





            DownloadServerLogs operation = opBuilder.Build(
                Namespace,
                PodName
            );


            var response = wrapper.DownloadServerLogs(operation);
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