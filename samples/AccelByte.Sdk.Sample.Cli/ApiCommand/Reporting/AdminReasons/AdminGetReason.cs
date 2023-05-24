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
    [SdkConsoleCommand("reporting","admingetreason")]
    public class AdminGetReasonCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "AdminGetReason"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("reasonId")]
        public string ReasonId { get; set; } = String.Empty;

        public AdminGetReasonCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.AdminGetReason.Builder;





            AdminGetReason operation = opBuilder.Build(
                Namespace,
                ReasonId
            );

            
            AccelByte.Sdk.Api.Reporting.Model.RestapiAdminReasonResponse? response = wrapper.AdminGetReason(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}