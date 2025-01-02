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
    [SdkConsoleCommand("platform", "generateinvoicesummary")]
    public class GenerateInvoiceSummaryCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GenerateInvoiceSummary"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endTime")]
        public string EndTime { get; set; } = String.Empty;

        [SdkCommandArgument("feature")]
        public string Feature { get; set; } = String.Empty;

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        [SdkCommandArgument("itemType")]
        public string ItemType { get; set; } = String.Empty;

        [SdkCommandArgument("startTime")]
        public string StartTime { get; set; } = String.Empty;

        public GenerateInvoiceSummaryCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Invoice wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Invoice(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GenerateInvoiceSummary.Builder;





            GenerateInvoiceSummary operation = opBuilder.Build(
                Namespace,
                EndTime,
                Feature,
                ItemId,
                ItemType,
                StartTime
            );


            var response = wrapper.GenerateInvoiceSummary(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}