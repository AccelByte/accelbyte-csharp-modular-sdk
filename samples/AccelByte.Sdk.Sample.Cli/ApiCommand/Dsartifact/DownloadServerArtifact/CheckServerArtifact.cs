// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsartifact.Wrapper;
using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsartifact
{
    [SdkConsoleCommand("dsartifact", "checkserverartifact")]
    public class CheckServerArtifactCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Dsartifact"; } }

        public string OperationName { get { return "CheckServerArtifact"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("podName")]
        public string PodName { get; set; } = String.Empty;

        public CheckServerArtifactCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsartifact.Wrapper.DownloadServerArtifact wrapper = new AccelByte.Sdk.Api.Dsartifact.Wrapper.DownloadServerArtifact(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsartifact.Operation.CheckServerArtifact.Builder;





            CheckServerArtifact operation = opBuilder.Build(
                Namespace,
                PodName
            );


            AccelByte.Sdk.Api.Dsartifact.Model.ModelsArtifactFileStatus? response = wrapper.CheckServerArtifact(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}