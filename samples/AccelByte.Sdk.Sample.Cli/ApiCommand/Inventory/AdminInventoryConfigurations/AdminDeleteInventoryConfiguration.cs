// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("inventory","admindeleteinventoryconfiguration")]
    public class AdminDeleteInventoryConfigurationCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Inventory"; } }

        public string OperationName{ get { return "AdminDeleteInventoryConfiguration"; } }

        [SdkCommandArgument("inventoryConfigurationId")]
        public string InventoryConfigurationId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminDeleteInventoryConfigurationCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventoryConfigurations wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventoryConfigurations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminDeleteInventoryConfiguration.Builder;





            AdminDeleteInventoryConfiguration operation = opBuilder.Build(
                InventoryConfigurationId,
                Namespace
            );


            var response = wrapper.AdminDeleteInventoryConfiguration(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}