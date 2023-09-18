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
    [SdkConsoleCommand("dslogmanager","getserverlogs")]
    public class GetServerLogsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Dslogmanager"; } }

        public string OperationName{ get { return "GetServerLogs"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("podName")]
        public string PodName { get; set; } = String.Empty;

        [SdkCommandArgument("logType")]
        public string? LogType { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("origin")]
        public string? Origin { get; set; }

        public GetServerLogsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.Admin wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.Admin(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dslogmanager.Operation.GetServerLogs.Builder;

            if (LogType != null)
                opBuilder.SetLogType((string)LogType);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (Origin != null)
                opBuilder.SetOrigin((string)Origin);




            GetServerLogs operation = opBuilder.Build(
                Namespace,
                PodName
            );


            AccelByte.Sdk.Api.Dslogmanager.Model.ModelsServerLogs? response = wrapper.GetServerLogs(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}