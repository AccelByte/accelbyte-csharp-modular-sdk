// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Csm
{
    [SdkConsoleCommand("csm","deletedeploymentv2")]
    public class DeleteDeploymentV2Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Csm"; } }

        public string OperationName{ get { return "DeleteDeploymentV2"; } }

        [SdkCommandArgument("deploymentId")]
        public string DeploymentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteDeploymentV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.DeploymentV2 wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.DeploymentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.DeleteDeploymentV2.Builder;





            DeleteDeploymentV2 operation = opBuilder.Build(
                DeploymentId,
                Namespace
            );


            var response = wrapper.DeleteDeploymentV2(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}