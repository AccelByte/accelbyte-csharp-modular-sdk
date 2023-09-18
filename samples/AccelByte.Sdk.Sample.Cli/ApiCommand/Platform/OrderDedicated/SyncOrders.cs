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
    [SdkConsoleCommand("platform","syncorders")]
    public class SyncOrdersCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "SyncOrders"; } }

        [SdkCommandArgument("nextEvaluatedKey")]
        public string? NextEvaluatedKey { get; set; }

        [SdkCommandArgument("end")]
        public string End { get; set; } = String.Empty;

        [SdkCommandArgument("start")]
        public string Start { get; set; } = String.Empty;

        public SyncOrdersCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.OrderDedicated wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.OrderDedicated(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.SyncOrders.Builder;

            if (NextEvaluatedKey != null)
                opBuilder.SetNextEvaluatedKey((string)NextEvaluatedKey);




            SyncOrders operation = opBuilder.Build(
                End,
                Start
            );


            AccelByte.Sdk.Api.Platform.Model.OrderSyncResult? response = wrapper.SyncOrders(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}