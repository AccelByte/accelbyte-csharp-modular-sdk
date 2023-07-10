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
    [SdkConsoleCommand("platform","createpaymentproviderconfig")]
    public class CreatePaymentProviderConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CreatePaymentProviderConfig"; } }

        [SdkCommandData("body")]
        public PaymentProviderConfigEdit Body { get; set; } = new PaymentProviderConfigEdit();
                
        public CreatePaymentProviderConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.CreatePaymentProviderConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.PaymentProviderConfigEdit)Body);



            CreatePaymentProviderConfig operation = opBuilder.Build(
            );

            
            AccelByte.Sdk.Api.Platform.Model.PaymentProviderConfigInfo? response = wrapper.CreatePaymentProviderConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}