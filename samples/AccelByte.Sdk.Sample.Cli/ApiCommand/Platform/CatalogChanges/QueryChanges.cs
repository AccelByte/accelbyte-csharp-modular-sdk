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
    [SdkConsoleCommand("platform","querychanges")]
    public class QueryChangesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryChanges"; } }

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

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("selected")]
        public bool? Selected { get; set; }

        [SdkCommandArgument("sortBy")]
        public List<string>? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("updatedAtEnd")]
        public string? UpdatedAtEnd { get; set; }

        [SdkCommandArgument("updatedAtStart")]
        public string? UpdatedAtStart { get; set; }

        [SdkCommandArgument("withTotal")]
        public bool? WithTotal { get; set; }

        public QueryChangesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryChanges.Builder;

            if (Action != null)
                opBuilder.SetAction(QueryChangesAction.NewValue(Action));
            if (ItemSku != null)
                opBuilder.SetItemSku((string)ItemSku);
            if (ItemType != null)
                opBuilder.SetItemType(QueryChangesItemType.NewValue(ItemType));
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Selected != null)
                opBuilder.SetSelected((bool)Selected);
            if (SortBy != null)
                opBuilder.SetSortBy(QueryChangesSortBy.NewValue(SortBy));
            if (Status != null)
                opBuilder.SetStatus(QueryChangesStatus.NewValue(Status));
            if (Type != null)
                opBuilder.SetType(QueryChangesType.NewValue(Type));
            if (UpdatedAtEnd != null)
                opBuilder.SetUpdatedAtEnd((string)UpdatedAtEnd);
            if (UpdatedAtStart != null)
                opBuilder.SetUpdatedAtStart((string)UpdatedAtStart);
            if (WithTotal != null)
                opBuilder.SetWithTotal((bool)WithTotal);




            QueryChanges operation = opBuilder.Build(
                Namespace,
                StoreId
            );


            var response = wrapper.QueryChanges(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}