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
    [SdkConsoleCommand("platform","querythirdpartynotifications")]
    public class QueryThirdPartyNotificationsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryThirdPartyNotifications"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("externalId")]
        public string? ExternalId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("source")]
        public string? Source { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        public QueryThirdPartyNotificationsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAPNotification wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAPNotification(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryThirdPartyNotifications.Builder;

            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (ExternalId != null)
                opBuilder.SetExternalId((string)ExternalId);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Source != null)
                opBuilder.SetSource(QueryThirdPartyNotificationsSource.NewValue(Source));
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);
            if (Status != null)
                opBuilder.SetStatus(QueryThirdPartyNotificationsStatus.NewValue(Status));
            if (Type != null)
                opBuilder.SetType((string)Type);




            QueryThirdPartyNotifications operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.QueryThirdPartyNotifications(operation);
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