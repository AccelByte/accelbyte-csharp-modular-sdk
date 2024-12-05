// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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
    [SdkConsoleCommand("iam", "admingetprofileupdatestrategyv3")]
    public class AdminGetProfileUpdateStrategyV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetProfileUpdateStrategyV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("field")]
        public string? Field { get; set; }

        public AdminGetProfileUpdateStrategyV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ProfileUpdateStrategy wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ProfileUpdateStrategy(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetProfileUpdateStrategyV3.Builder;

            if (Field != null)
                opBuilder.SetField(AdminGetProfileUpdateStrategyV3Field.NewValue(Field));




            AdminGetProfileUpdateStrategyV3 operation = opBuilder.Build(
                Namespace
            );


            var response = wrapper.AdminGetProfileUpdateStrategyV3(operation);
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
        }
    }
}