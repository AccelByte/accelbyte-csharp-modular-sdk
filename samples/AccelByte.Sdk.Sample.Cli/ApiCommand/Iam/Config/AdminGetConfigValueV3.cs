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
    [SdkConsoleCommand("iam", "admingetconfigvaluev3")]
    public class AdminGetConfigValueV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetConfigValueV3"; } }

        [SdkCommandArgument("configKey")]
        public string ConfigKey { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetConfigValueV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetConfigValueV3.Builder;





            AdminGetConfigValueV3 operation = opBuilder.Build(
                ConfigKey,
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelConfigValueResponseV3? response = wrapper.AdminGetConfigValueV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}