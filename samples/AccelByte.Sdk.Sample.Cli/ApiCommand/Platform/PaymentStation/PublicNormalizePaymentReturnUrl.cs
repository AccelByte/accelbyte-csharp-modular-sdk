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
    [SdkConsoleCommand("platform","publicnormalizepaymentreturnurl")]
    public class PublicNormalizePaymentReturnUrlCommand: ISdkConsoleCommand
    {
        private IAccelByteSdk _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicNormalizePaymentReturnUrl"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("payerID")]
        public string? PayerID { get; set; }

        [SdkCommandArgument("foreinginvoice")]
        public string? Foreinginvoice { get; set; }

        [SdkCommandArgument("invoiceId")]
        public string? InvoiceId { get; set; }

        [SdkCommandArgument("payload")]
        public string? Payload { get; set; }

        [SdkCommandArgument("redirectResult")]
        public string? RedirectResult { get; set; }

        [SdkCommandArgument("resultCode")]
        public string? ResultCode { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("token")]
        public string? Token { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("orderNo")]
        public string OrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("paymentOrderNo")]
        public string PaymentOrderNo { get; set; } = String.Empty;

        [SdkCommandArgument("paymentProvider")]
        public string PaymentProvider { get; set; } = String.Empty;

        [SdkCommandArgument("returnUrl")]
        public string ReturnUrl { get; set; } = String.Empty;

        public PublicNormalizePaymentReturnUrlCommand(IAccelByteSdk sdk)
        {
            _SDK = sdk;
        }

        public CommandResult Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.PaymentStation(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicNormalizePaymentReturnUrl.Builder;

            if (PayerID != null)
                opBuilder.SetPayerID((string)PayerID);
            if (Foreinginvoice != null)
                opBuilder.SetForeinginvoice((string)Foreinginvoice);
            if (InvoiceId != null)
                opBuilder.SetInvoiceId((string)InvoiceId);
            if (Payload != null)
                opBuilder.SetPayload((string)Payload);
            if (RedirectResult != null)
                opBuilder.SetRedirectResult((string)RedirectResult);
            if (ResultCode != null)
                opBuilder.SetResultCode((string)ResultCode);
            if (SessionId != null)
                opBuilder.SetSessionId((string)SessionId);
            if (Status != null)
                opBuilder.SetStatus((string)Status);
            if (Token != null)
                opBuilder.SetToken((string)Token);
            if (Type != null)
                opBuilder.SetType((string)Type);
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            PublicNormalizePaymentReturnUrl operation = opBuilder.Build(
                Namespace,
                OrderNo,
                PaymentOrderNo,
                PaymentProvider,
                ReturnUrl
            );


            var response = wrapper.PublicNormalizePaymentReturnUrl(operation);
            if (response.IsSuccess)
                return CommandResult.Success("");
            else if (response.Error != null)
                return CommandResult.Fail(response.Error.Code, response.Error.Message);
            else
                return CommandResult.Fail("-", "Valid error message unavailable");
        }
    }
}