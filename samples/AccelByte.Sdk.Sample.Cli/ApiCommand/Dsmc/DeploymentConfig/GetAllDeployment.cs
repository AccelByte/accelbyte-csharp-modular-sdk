// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","getalldeployment")]
    public class GetAllDeploymentCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "GetAllDeployment"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("count")]
        public long Count { get; set; } = 0;

        [SdkCommandArgument("offset")]
        public long Offset { get; set; } = 0;

        public GetAllDeploymentCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.GetAllDeployment.Builder;

            if (Name != null)
                opBuilder.SetName((string)Name);




            GetAllDeployment operation = opBuilder.Build(
                Namespace,
                Count,
                Offset
            );


            var response = wrapper.GetAllDeployment(operation);
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
        }
    }
}