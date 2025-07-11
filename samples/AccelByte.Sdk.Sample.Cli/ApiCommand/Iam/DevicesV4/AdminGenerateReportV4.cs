// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","admingeneratereportv4")]
    public class AdminGenerateReportV4Command: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGenerateReportV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("deviceType")]
        public string DeviceType { get; set; } = String.Empty;

        public AdminGenerateReportV4Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGenerateReportV4.Builder;

            if (EndDate != null)
                opBuilder.SetEndDate((string)EndDate);
            if (StartDate != null)
                opBuilder.SetStartDate((string)StartDate);




            AdminGenerateReportV4 operation = opBuilder.Build(
                Namespace,
                DeviceType
            );


            var response = wrapper.AdminGenerateReportV4(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}