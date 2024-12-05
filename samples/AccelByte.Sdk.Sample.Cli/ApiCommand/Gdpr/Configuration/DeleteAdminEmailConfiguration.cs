// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gdpr.Wrapper;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Api.Gdpr.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gdpr
{
    [SdkConsoleCommand("gdpr", "deleteadminemailconfiguration")]
    public class DeleteAdminEmailConfigurationCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Gdpr"; } }

        public string OperationName { get { return "DeleteAdminEmailConfiguration"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("emails")]
        public List<string> Emails { get; set; } = new List<string>();

        public DeleteAdminEmailConfigurationCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.DeleteAdminEmailConfiguration.Builder;





            DeleteAdminEmailConfiguration operation = opBuilder.Build(
                Namespace,
                Emails
            );


            var response = wrapper.DeleteAdminEmailConfiguration(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}