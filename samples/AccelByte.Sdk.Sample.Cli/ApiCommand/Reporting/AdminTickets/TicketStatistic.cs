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

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","ticketstatistic")]
    public class TicketStatisticCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "TicketStatistic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("extensionCategory")]
        public string? ExtensionCategory { get; set; }

        [SdkCommandArgument("category")]
        public string Category { get; set; } = String.Empty;

        public TicketStatisticCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminTickets(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.TicketStatistic.Builder;

            if (ExtensionCategory != null)
                opBuilder.SetExtensionCategory((string)ExtensionCategory);




            TicketStatistic operation = opBuilder.Build(
                Namespace,
                Category
            );

            
            AccelByte.Sdk.Api.Reporting.Model.RestapiTicketStatisticResponse? response = wrapper.TicketStatistic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}