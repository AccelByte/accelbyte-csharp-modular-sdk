// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Inventory
{
    [SdkConsoleCommand("inventory", "adminupdateintegrationconfiguration")]
    public class AdminUpdateIntegrationConfigurationCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "AdminUpdateIntegrationConfiguration"; } }

        [SdkCommandArgument("integrationConfigurationId")]
        public string IntegrationConfigurationId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsUpdateIntegrationConfigurationReq Body { get; set; } = new ApimodelsUpdateIntegrationConfigurationReq();

        public AdminUpdateIntegrationConfigurationCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminIntegrationConfigurations wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminIntegrationConfigurations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminUpdateIntegrationConfiguration.Builder;





            AdminUpdateIntegrationConfiguration operation = opBuilder.Build(
                Body,
                IntegrationConfigurationId,
                Namespace
            );


            AccelByte.Sdk.Api.Inventory.Model.ApimodelsIntegrationConfigurationResp? response = wrapper.AdminUpdateIntegrationConfiguration(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}