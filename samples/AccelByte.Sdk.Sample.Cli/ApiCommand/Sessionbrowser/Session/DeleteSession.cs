// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser", "deletesession")]
    public class DeleteSessionCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Sessionbrowser"; } }

        public string OperationName { get { return "DeleteSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionID")]
        public string SessionID { get; set; } = String.Empty;

        public DeleteSessionCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Sessionbrowser.Operation.DeleteSession.Builder;





            DeleteSession operation = opBuilder.Build(
                Namespace,
                SessionID
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            var response = wrapper.DeleteSession(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-", "response data is null.");
            }
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}