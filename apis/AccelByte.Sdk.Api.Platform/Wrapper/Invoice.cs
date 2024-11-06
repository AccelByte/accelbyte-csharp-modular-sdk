// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Invoice
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Invoice(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Invoice(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public DownloadInvoiceDetails.DownloadInvoiceDetailsBuilder DownloadInvoiceDetailsOp
        {
            get
            {
                var opBuilder = new Operation.DownloadInvoiceDetails.DownloadInvoiceDetailsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GenerateInvoiceSummary.GenerateInvoiceSummaryBuilder GenerateInvoiceSummaryOp
        {
            get
            {
                var opBuilder = new Operation.GenerateInvoiceSummary.GenerateInvoiceSummaryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public DownloadInvoiceDetails.Response DownloadInvoiceDetails(DownloadInvoiceDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DownloadInvoiceDetails.Response> DownloadInvoiceDetailsAsync(DownloadInvoiceDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GenerateInvoiceSummary.Response GenerateInvoiceSummary(GenerateInvoiceSummary input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GenerateInvoiceSummary.Response> GenerateInvoiceSummaryAsync(GenerateInvoiceSummary input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}