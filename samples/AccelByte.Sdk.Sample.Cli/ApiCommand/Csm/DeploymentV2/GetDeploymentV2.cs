// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("csm", "getdeploymentv2")]
    public class GetDeploymentV2Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "GetDeploymentV2"; } }

        [SdkCommandArgument("deploymentId")]
        public string DeploymentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetDeploymentV2Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.DeploymentV2 wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.DeploymentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.GetDeploymentV2.Builder;





            GetDeploymentV2 operation = opBuilder.Build(
                DeploymentId,
                Namespace
            );


            var response = wrapper.GetDeploymentV2(operation);
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