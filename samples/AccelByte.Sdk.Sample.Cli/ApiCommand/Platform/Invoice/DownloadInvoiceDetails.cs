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
    [SdkConsoleCommand("platform","downloadinvoicedetails")]
    public class DownloadInvoiceDetailsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DownloadInvoiceDetails"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("feature")]
        public string? Feature { get; set; }

        [SdkCommandArgument("itemId")]
        public string? ItemId { get; set; }

        [SdkCommandArgument("itemType")]
        public string? ItemType { get; set; }

        [SdkCommandArgument("endTime")]
        public string EndTime { get; set; } = String.Empty;

        [SdkCommandArgument("startTime")]
        public string StartTime { get; set; } = String.Empty;

        public DownloadInvoiceDetailsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Invoice wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Invoice(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.DownloadInvoiceDetails.Builder;

            if (Feature != null)
                opBuilder.SetFeature((string)Feature);
            if (ItemId != null)
                opBuilder.SetItemId((string)ItemId);
            if (ItemType != null)
                opBuilder.SetItemType(DownloadInvoiceDetailsItemType.NewValue(ItemType));




            DownloadInvoiceDetails operation = opBuilder.Build(
                Namespace,
                EndTime,
                StartTime
            );

            
            Stream? response = wrapper.DownloadInvoiceDetails(operation);
            if (response == null)
                return "No response from server.";

            return Helper.ConvertInputStreamToString(response);
        }
    }
}