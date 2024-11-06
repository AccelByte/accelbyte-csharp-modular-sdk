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
    [SdkConsoleCommand("reporting","deletereason")]
    public class DeleteReasonCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Reporting"; } }

        public string OperationName{ get { return "DeleteReason"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("reasonId")]
        public string ReasonId { get; set; } = String.Empty;

        public DeleteReasonCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons wrapper = new AccelByte.Sdk.Api.Reporting.Wrapper.AdminReasons(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Reporting.Operation.DeleteReason.Builder;





            DeleteReason operation = opBuilder.Build(
                Namespace,
                ReasonId
            );


            var response = wrapper.DeleteReason(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}