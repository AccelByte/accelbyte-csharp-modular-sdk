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
    [SdkConsoleCommand("platform","querypaymentorders")]
    public class QueryPaymentOrdersCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryPaymentOrders"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("channel")]
        public string? Channel { get; set; }

        [SdkCommandArgument("extTxId")]
        public string? ExtTxId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public QueryPaymentOrdersCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryPaymentOrders.Builder;

            if (Channel != null)
                opBuilder.SetChannel(QueryPaymentOrdersChannel.NewValue(Channel));
            if (ExtTxId != null)
                opBuilder.SetExtTxId((string)ExtTxId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Status != null)
                opBuilder.SetStatus(QueryPaymentOrdersStatus.NewValue(Status));




            QueryPaymentOrders operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.PaymentOrderPagingSlicedResult? response = wrapper.QueryPaymentOrders(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}