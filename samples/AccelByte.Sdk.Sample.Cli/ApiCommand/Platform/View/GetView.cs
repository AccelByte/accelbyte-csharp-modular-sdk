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
    [SdkConsoleCommand("platform", "getview")]
    public class GetViewCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetView"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("viewId")]
        public string ViewId { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public GetViewCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.View wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.View(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetView.Builder;

            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);




            GetView operation = opBuilder.Build(
                Namespace,
                ViewId
            );


            AccelByte.Sdk.Api.Platform.Model.FullViewInfo? response = wrapper.GetView(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}