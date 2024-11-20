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
    [SdkConsoleCommand("csm","getdeploymentv1")]
    public class GetDeploymentV1Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Csm"; } }

        public string OperationName{ get { return "GetDeploymentV1"; } }

        [SdkCommandArgument("deploymentId")]
        public string DeploymentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetDeploymentV1Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.Deployment wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.Deployment(_SDK);

            #pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.GetDeploymentV1.Builder;





            GetDeploymentV1 operation = opBuilder.Build(
                DeploymentId,
                Namespace
            );

            #pragma warning restore ab_deprecated_operation

            #pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.GetDeploymentV1(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}