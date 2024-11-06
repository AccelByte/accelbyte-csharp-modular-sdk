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
    [SdkConsoleCommand("gdpr","admindeleteplatformaccountclosureclient")]
    public class AdminDeletePlatformAccountClosureClientCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminDeletePlatformAccountClosureClient"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platform")]
        public string Platform { get; set; } = String.Empty;

        public AdminDeletePlatformAccountClosureClientCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureClient wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureClient(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.AdminDeletePlatformAccountClosureClient.Builder;





            AdminDeletePlatformAccountClosureClient operation = opBuilder.Build(
                Namespace,
                Platform
            );


            var response = wrapper.AdminDeletePlatformAccountClosureClient(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}