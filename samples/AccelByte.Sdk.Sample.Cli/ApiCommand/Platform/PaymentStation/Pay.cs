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
    [SdkConsoleCommand("platform","pay")]
    public class PayCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "Pay"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("paymentProvider")]
        public string? PaymentProvider { get; set; }

        [SdkCommandArgument("zipCode")]
        public string? ZipCode { get; set; }

        [SdkCommandData("body")]
        public PaymentToken Body { get; set; } = new PaymentToken();

        public PayCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.Pay.Builder;

            if (PaymentProvider != null)
                opBuilder.SetPaymentProvider(PayPaymentProvider.NewValue(PaymentProvider));
            if (ZipCode != null)
                opBuilder.SetZipCode((string)ZipCode);




            Pay operation = opBuilder.Build(
                Body,
                Namespace,
                PaymentOrderNo
            );


            var response = wrapper.Pay(operation);
            if (response.IsSuccess)
            {
                if (response.Data != null)
                    return CommandResult.Success(SdkHelper.SerializeToJson(response.Data));
                else
                    return CommandResult.Fail("-","response data is null.");
            }   
            else if (!response.Error.IsAvailable)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}