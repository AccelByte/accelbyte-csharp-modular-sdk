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
    [SdkConsoleCommand("platform", "queryuserthirdpartysubscriptiontransactions")]
    public class QueryUserThirdPartySubscriptionTransactionsCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryUserThirdPartySubscriptionTransactions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("groupId")]
        public string? GroupId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("platform")]
        public string? Platform { get; set; }

        [SdkCommandArgument("productId")]
        public string? ProductId { get; set; }

        public QueryUserThirdPartySubscriptionTransactionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAPSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryUserThirdPartySubscriptionTransactions.Builder;

            if (ActiveOnly != null)
                opBuilder.SetActiveOnly((bool)ActiveOnly);
            if (GroupId != null)
                opBuilder.SetGroupId((string)GroupId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Platform != null)
                opBuilder.SetPlatform(QueryUserThirdPartySubscriptionTransactionsPlatform.NewValue(Platform));
            if (ProductId != null)
                opBuilder.SetProductId((string)ProductId);




            QueryUserThirdPartySubscriptionTransactions operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Platform.Model.ThirdPartySubscriptionTransactionPagingSlicedResult? response = wrapper.QueryUserThirdPartySubscriptionTransactions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}