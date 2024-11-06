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
    [SdkConsoleCommand("gdpr","admingetplatformaccountclosureclient")]
    public class AdminGetPlatformAccountClosureClientCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Gdpr"; } }

        public string OperationName{ get { return "AdminGetPlatformAccountClosureClient"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platform")]
        public string Platform { get; set; } = String.Empty;

        public AdminGetPlatformAccountClosureClientCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureClient wrapper = new AccelByte.Sdk.Api.Gdpr.Wrapper.PlatformAccountClosureClient(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Gdpr.Operation.AdminGetPlatformAccountClosureClient.Builder;





            AdminGetPlatformAccountClosureClient operation = opBuilder.Build(
                Namespace,
                Platform
            );


            var response = wrapper.AdminGetPlatformAccountClosureClient(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}