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
    [SdkConsoleCommand("inventory", "publicconsumemyitem")]
    public class PublicConsumeMyItemCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "PublicConsumeMyItem"; } }

        [SdkCommandArgument("inventoryId")]
        public string InventoryId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsConsumeItemReq Body { get; set; } = new ApimodelsConsumeItemReq();

        public PublicConsumeMyItemCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.PublicConsumeMyItem.Builder;





            PublicConsumeMyItem operation = opBuilder.Build(
                Body,
                InventoryId,
                Namespace
            );


            AccelByte.Sdk.Api.Inventory.Model.ApimodelsItemResp? response = wrapper.PublicConsumeMyItem(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}