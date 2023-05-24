// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","updateoverrideregionoverride")]
    public class UpdateOverrideRegionOverrideCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "UpdateOverrideRegionOverride"; } }

        [SdkCommandArgument("deployment")]
        public string Deployment { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        [SdkCommandArgument("version")]
        public string Version { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateRegionOverrideRequest Body { get; set; } = new ModelsUpdateRegionOverrideRequest();
                
        public UpdateOverrideRegionOverrideCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.UpdateOverrideRegionOverride.Builder;





            UpdateOverrideRegionOverride operation = opBuilder.Build(
                Body,
                Deployment,
                Namespace,
                Region,
                Version
            );

            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsDeploymentWithOverride? response = wrapper.UpdateOverrideRegionOverride(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}