// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Reporting
{
    [SdkConsoleCommand("reporting","listreports")]
    public class ListReportsCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "ListReports"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("category")]
        public string? Category { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("reportedUserId")]
        public string? ReportedUserId { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        public ListReportsCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminReports wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminReports(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.ListReports.Builder;

            if (Category != null)
                opBuilder.SetCategory((string)Category);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (ReportedUserId != null)
                opBuilder.SetReportedUserId((string)ReportedUserId);
            if (SortBy != null)
                opBuilder.SetSortBy((string)SortBy);




            ListReports operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Reporting.Model.RestapiReportListResponse? response = wrapper.ListReports(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}