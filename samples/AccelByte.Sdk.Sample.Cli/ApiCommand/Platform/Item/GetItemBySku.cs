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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","getitembysku")]
    public class GetItemBySkuCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetItemBySku"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("sku")]
        public string Sku { get; set; } = String.Empty;

        public GetItemBySkuCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetItemBySku.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);




            GetItemBySku operation = opBuilder.Build(
                Namespace,
                Sku
            );

            
            AccelByte.Sdk.Api.Platform.Model.FullItemInfo? response = wrapper.GetItemBySku(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}