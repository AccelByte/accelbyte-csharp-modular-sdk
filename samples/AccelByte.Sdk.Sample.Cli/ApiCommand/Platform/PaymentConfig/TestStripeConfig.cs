// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","teststripeconfig")]
    public class TestStripeConfigCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "TestStripeConfig"; } }

        [SdkCommandArgument("sandbox")]
        public bool? Sandbox { get; set; }

        [SdkCommandData("body")]
        public StripeConfig Body { get; set; } = new StripeConfig();

        public TestStripeConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.TestStripeConfig.Builder;

            if (Sandbox != null)
                opBuilder.SetSandbox((bool)Sandbox);

            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.StripeConfig)Body);



            TestStripeConfig operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Platform.Model.TestResult? response = wrapper.TestStripeConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}