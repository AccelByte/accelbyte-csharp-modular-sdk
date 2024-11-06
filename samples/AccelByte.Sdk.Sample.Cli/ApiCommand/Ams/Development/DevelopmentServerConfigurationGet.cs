// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams","developmentserverconfigurationget")]
    public class DevelopmentServerConfigurationGetCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Ams"; } }

        public string OperationName{ get { return "DevelopmentServerConfigurationGet"; } }

        [SdkCommandArgument("developmentServerConfigID")]
        public string DevelopmentServerConfigID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DevelopmentServerConfigurationGetCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Development wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Development(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.DevelopmentServerConfigurationGet.Builder;





            DevelopmentServerConfigurationGet operation = opBuilder.Build(
                DevelopmentServerConfigID,
                Namespace
            );


            var response = wrapper.DevelopmentServerConfigurationGet(operation);
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