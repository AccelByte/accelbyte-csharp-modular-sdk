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
    [SdkConsoleCommand("platform","querypaymentnotifications")]
    public class QueryPaymentNotificationsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryPaymentNotifications"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("externalId")]
        public string? ExternalId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("notificationSource")]
        public string? NotificationSource { get; set; }

        [SdkCommandArgument("notificationType")]
        public string? NotificationType { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public QueryPaymentNotificationsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Payment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Payment(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryPaymentNotifications.Builder;

            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (ExternalId != null)
                opBuilder.SetExternalId((string)ExternalId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (NotificationSource != null)
                opBuilder.SetNotificationSource(QueryPaymentNotificationsNotificationSource.NewValue(NotificationSource));
            if (NotificationType != null)
                opBuilder.SetNotificationType((string)NotificationType);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (PaymentOrderNo != null)
                opBuilder.SetPaymentOrderNo((string)PaymentOrderNo);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (Status != null)
                opBuilder.SetStatus(QueryPaymentNotificationsStatus.NewValue(Status));




            QueryPaymentNotifications operation = opBuilder.Build(
                Namespace
            );

            
            AccelByte.Sdk.Api.Platform.Model.PaymentNotificationPagingSlicedResult? response = wrapper.QueryPaymentNotifications(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}