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
    [SdkConsoleCommand("platform","querysubscriptions")]
    public class QuerySubscriptionsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QuerySubscriptions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("chargeStatus")]
        public string? ChargeStatus { get; set; }

        [SdkCommandArgument("itemId")]
        public string? ItemId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sku")]
        public string? Sku { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("subscribedBy")]
        public string? SubscribedBy { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QuerySubscriptionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QuerySubscriptions.Builder;

            if (ChargeStatus != null)
                opBuilder.SetChargeStatus(QuerySubscriptionsChargeStatus.NewValue(ChargeStatus));
            if (ItemId != null)
                opBuilder.SetItemId((string)ItemId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Sku != null)
                opBuilder.SetSku((string)Sku);
            if (Status != null)
                opBuilder.SetStatus(QuerySubscriptionsStatus.NewValue(Status));
            if (SubscribedBy != null)
                opBuilder.SetSubscribedBy(QuerySubscriptionsSubscribedBy.NewValue(SubscribedBy));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            QuerySubscriptions operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.QuerySubscriptions(operation);
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