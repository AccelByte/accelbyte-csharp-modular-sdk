// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("gdpr","saveadminemailconfiguration")]
    public class SaveAdminEmailConfigurationCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "SaveAdminEmailConfiguration"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<string> Body { get; set; } = new List<string>();

        public SaveAdminEmailConfigurationCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.Configuration(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.SaveAdminEmailConfiguration.Builder;





            SaveAdminEmailConfiguration operation = opBuilder.Build(
                Body,
                Namespace
            );


            var response = wrapper.SaveAdminEmailConfiguration(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}