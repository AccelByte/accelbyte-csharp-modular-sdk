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
    [SdkConsoleCommand("platform","publicqueryusersubscriptions")]
    public class PublicQueryUserSubscriptionsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicQueryUserSubscriptions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

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

        public PublicQueryUserSubscriptionsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicQueryUserSubscriptions.Builder;

            if (ChargeStatus != null)
                opBuilder.SetChargeStatus(PublicQueryUserSubscriptionsChargeStatus.NewValue(ChargeStatus));
            if (ItemId != null)
                opBuilder.SetItemId((string)ItemId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Sku != null)
                opBuilder.SetSku((string)Sku);
            if (Status != null)
                opBuilder.SetStatus(PublicQueryUserSubscriptionsStatus.NewValue(Status));
            if (SubscribedBy != null)
                opBuilder.SetSubscribedBy(PublicQueryUserSubscriptionsSubscribedBy.NewValue(SubscribedBy));




            PublicQueryUserSubscriptions operation = opBuilder.Build(
                Namespace,
                UserId
            );


            var response = wrapper.PublicQueryUserSubscriptions(operation);
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