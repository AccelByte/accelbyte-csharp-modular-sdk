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
    [SdkConsoleCommand("platform", "bulkdebit")]
    public class BulkDebitCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "BulkDebit"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<BulkDebitRequest> Body { get; set; } = new List<BulkDebitRequest>();

        public BulkDebitCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Wallet wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Wallet(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.BulkDebit.Builder;


            if (Body != null)
                opBuilder.SetBody((List<AccelByte.Sdk.Api.Platform.Model.BulkDebitRequest>)Body);



            BulkDebit operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.BulkDebitResult? response = wrapper.BulkDebit(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}