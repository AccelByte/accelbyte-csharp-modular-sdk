// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicbulkgetitems")]
    public class PublicBulkGetItemsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicBulkGetItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("autoCalcEstimatedPrice")]
        public bool? AutoCalcEstimatedPrice { get; set; }

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("itemIds")]
        public string ItemIds { get; set; } = String.Empty;

        public PublicBulkGetItemsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicBulkGetItems.Builder;

            if (AutoCalcEstimatedPrice != null)
                opBuilder.SetAutoCalcEstimatedPrice((bool)AutoCalcEstimatedPrice);
            if (Language != null)
                opBuilder.SetLanguage((string)Language);
            if (Region != null)
                opBuilder.SetRegion((string)Region);
            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);




            PublicBulkGetItems operation = opBuilder.Build(
                Namespace,
                ItemIds
            );


            var response = wrapper.PublicBulkGetItems(operation);
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