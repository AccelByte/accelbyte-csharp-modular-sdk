// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","updateadyenconfig")]
    public class UpdateAdyenConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateAdyenConfig"; } }

        [SdkCommandArgument("id")]
        public string Id { get; set; } = String.Empty;

        [SdkCommandArgument("sandbox")]
        public bool? Sandbox { get; set; }

        [SdkCommandArgument("validate")]
        public bool? Validate { get; set; }

        [SdkCommandData("body")]
        public AdyenConfig Body { get; set; } = new AdyenConfig();
                
        public UpdateAdyenConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            UpdateAdyenConfig operation = new UpdateAdyenConfig(
                Id,                
                Sandbox,                
                Validate,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PaymentMerchantConfigInfo? response = wrapper.UpdateAdyenConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}