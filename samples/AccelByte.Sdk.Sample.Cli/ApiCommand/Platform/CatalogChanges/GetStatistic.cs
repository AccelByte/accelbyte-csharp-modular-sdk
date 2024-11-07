// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("platform","getstatistic")]
    public class GetStatisticCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetStatistic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string StoreId { get; set; } = String.Empty;

        [SdkCommandArgument("action")]
        public string? Action { get; set; }

        [SdkCommandArgument("itemSku")]
        public string? ItemSku { get; set; }

        [SdkCommandArgument("itemType")]
        public string? ItemType { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("updatedAtEnd")]
        public string? UpdatedAtEnd { get; set; }

        [SdkCommandArgument("updatedAtStart")]
        public string? UpdatedAtStart { get; set; }

        public GetStatisticCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetStatistic.Builder;

            if (Action != null)
                opBuilder.SetAction(GetStatisticAction.NewValue(Action));
            if (ItemSku != null)
                opBuilder.SetItemSku((string)ItemSku);
            if (ItemType != null)
                opBuilder.SetItemType(GetStatisticItemType.NewValue(ItemType));
            if (Type != null)
                opBuilder.SetType(GetStatisticType.NewValue(Type));
            if (UpdatedAtEnd != null)
                opBuilder.SetUpdatedAtEnd((string)UpdatedAtEnd);
            if (UpdatedAtStart != null)
                opBuilder.SetUpdatedAtStart((string)UpdatedAtStart);




            GetStatistic operation = opBuilder.Build(
                Namespace,
                StoreId
            );


            var response = wrapper.GetStatistic(operation);
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