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
    [SdkConsoleCommand("platform","downloadcategories")]
    public class DownloadCategoriesCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DownloadCategories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public DownloadCategoriesCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Category wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Category(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.DownloadCategories.Builder;

            if (Language != null)
                opBuilder.SetLanguage((string)Language);
            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);




            DownloadCategories operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Platform.Model.HierarchicalCategoryInfo>? response = wrapper.DownloadCategories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}