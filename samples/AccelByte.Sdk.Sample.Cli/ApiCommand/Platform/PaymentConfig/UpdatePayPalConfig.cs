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
    [SdkConsoleCommand("platform", "updatepaypalconfig")]
    public class UpdatePayPalConfigCommand : ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UpdatePayPalConfig"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("sandbox")]
        public bool? Sandbox { get; set; }

        [SdkCommandArgument("validate")]
        public bool? Validate { get; set; }

        [SdkCommandData("body")]
        public PayPalConfig Body { get; set; } = new PayPalConfig();

        public UpdatePayPalConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdatePayPalConfig.Builder;

            if (Sandbox != null)
                opBuilder.SetSandbox((bool)Sandbox);
            if (Validate != null)
                opBuilder.SetValidate((bool)Validate);

            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.PayPalConfig)Body);



            UpdatePayPalConfig operation = opBuilder.Build(
                Id
            );


            AccelByte.Sdk.Api.Platform.Model.PaymentMerchantConfigInfo? response = wrapper.UpdatePayPalConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}