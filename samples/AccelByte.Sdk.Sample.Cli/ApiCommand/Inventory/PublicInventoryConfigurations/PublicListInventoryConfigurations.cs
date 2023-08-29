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

using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Inventory
{
    [SdkConsoleCommand("inventory","publiclistinventoryconfigurations")]
    public class PublicListInventoryConfigurationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Inventory"; } }

        public string OperationName{ get { return "PublicListInventoryConfigurations"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        public PublicListInventoryConfigurationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.PublicInventoryConfigurations wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.PublicInventoryConfigurations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.PublicListInventoryConfigurations.Builder;

            if (Code != null)
                opBuilder.SetCode((string)Code);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(PublicListInventoryConfigurationsSortBy.NewValue(SortBy));




            PublicListInventoryConfigurations operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Inventory.Model.ApimodelsListInventoryConfigurationsResp? response = wrapper.PublicListInventoryConfigurations(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}