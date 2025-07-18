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
    [SdkConsoleCommand("inventory","admincreateinventory")]
    public class AdminCreateInventoryCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Inventory"; } }

        public string OperationName{ get { return "AdminCreateInventory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsCreateInventoryReq Body { get; set; } = new ApimodelsCreateInventoryReq();

        public AdminCreateInventoryCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventories wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminInventories(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminCreateInventory.Builder;





            AdminCreateInventory operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.AdminCreateInventory(operation);
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