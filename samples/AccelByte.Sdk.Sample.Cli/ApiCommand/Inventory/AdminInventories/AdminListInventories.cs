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
    [SdkConsoleCommand("inventory","adminlistinventories")]
    public class AdminListInventoriesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Inventory"; } }

        public string OperationName{ get { return "AdminListInventories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("inventoryConfigurationCode")]
        public string? InventoryConfigurationCode { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminListInventoriesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventories wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventories(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminListInventories.Builder;

            if (InventoryConfigurationCode != null)
                opBuilder.SetInventoryConfigurationCode((string)InventoryConfigurationCode);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(AdminListInventoriesSortBy.NewValue(SortBy));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            AdminListInventories operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminListInventories(operation);
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