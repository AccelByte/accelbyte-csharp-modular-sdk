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
    [SdkConsoleCommand("platform","updatewxpayconfig")]
    public class UpdateWxPayConfigCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateWxPayConfig"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("validate")]
        public bool? Validate { get; set; }

        [SdkCommandData("body")]
        public WxPayConfigRequest Body { get; set; } = new WxPayConfigRequest();

        public UpdateWxPayConfigCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdateWxPayConfig.Builder;

            if (Validate != null)
                opBuilder.SetValidate((bool)Validate);

            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.WxPayConfigRequest)Body);



            UpdateWxPayConfig operation = opBuilder.Build(
                Id
            );


            AccelByte.Sdk.Api.Platform.Model.PaymentMerchantConfigInfo? response = wrapper.UpdateWxPayConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}