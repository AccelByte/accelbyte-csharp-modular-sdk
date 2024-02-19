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
    [SdkConsoleCommand("iam", "publicgetconfigvaluev3")]
    public class PublicGetConfigValueV3Command : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PublicGetConfigValueV3"; } }

        [SdkCommandArgument("configKey")]
        public string ConfigKey { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicGetConfigValueV3Command(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicGetConfigValueV3.Builder;





            PublicGetConfigValueV3 operation = opBuilder.Build(
                ConfigKey,
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelConfigValueResponseV3? response = wrapper.PublicGetConfigValueV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}