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
    public class PaymentStation
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PaymentStation(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PaymentStation(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetPaymentCustomization.GetPaymentCustomizationBuilder GetPaymentCustomizationOp
        {
            get
            {
                var opBuilder = new Operation.GetPaymentCustomization.GetPaymentCustomizationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetPaymentUrl.PublicGetPaymentUrlBuilder PublicGetPaymentUrlOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetPaymentUrl.PublicGetPaymentUrlBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetPaymentMethods.PublicGetPaymentMethodsBuilder PublicGetPaymentMethodsOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetPaymentMethods.PublicGetPaymentMethodsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUnpaidPaymentOrder.PublicGetUnpaidPaymentOrderBuilder PublicGetUnpaidPaymentOrderOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUnpaidPaymentOrder.PublicGetUnpaidPaymentOrderBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public Pay.PayBuilder PayOp
        {
            get
            {
                var opBuilder = new Operation.Pay.PayBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicCheckPaymentOrderPaidStatus.PublicCheckPaymentOrderPaidStatusBuilder PublicCheckPaymentOrderPaidStatusOp
        {
            get
            {
                var opBuilder = new Operation.PublicCheckPaymentOrderPaidStatus.PublicCheckPaymentOrderPaidStatusBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetPaymentPublicConfig.GetPaymentPublicConfigBuilder GetPaymentPublicConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetPaymentPublicConfig.GetPaymentPublicConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetQRCode.PublicGetQRCodeBuilder PublicGetQRCodeOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetQRCode.PublicGetQRCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicNormalizePaymentReturnUrl.PublicNormalizePaymentReturnUrlBuilder PublicNormalizePaymentReturnUrlOp
        {
            get
            {
                var opBuilder = new Operation.PublicNormalizePaymentReturnUrl.PublicNormalizePaymentReturnUrlBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetPaymentTaxValue.GetPaymentTaxValueBuilder GetPaymentTaxValueOp
        {
            get
            {
                var opBuilder = new Operation.GetPaymentTaxValue.GetPaymentTaxValueBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetPaymentCustomization.Response GetPaymentCustomization(GetPaymentCustomization input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPaymentCustomization.Response> GetPaymentCustomizationAsync(GetPaymentCustomization input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public PublicGetPaymentUrl.Response PublicGetPaymentUrl(PublicGetPaymentUrl input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetPaymentUrl.Response> PublicGetPaymentUrlAsync(PublicGetPaymentUrl input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetPaymentMethods.Response PublicGetPaymentMethods(PublicGetPaymentMethods input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetPaymentMethods.Response> PublicGetPaymentMethodsAsync(PublicGetPaymentMethods input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetUnpaidPaymentOrder.Response PublicGetUnpaidPaymentOrder(PublicGetUnpaidPaymentOrder input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUnpaidPaymentOrder.Response> PublicGetUnpaidPaymentOrderAsync(PublicGetUnpaidPaymentOrder input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Pay.Response Pay(Pay input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Pay.Response> PayAsync(Pay input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicCheckPaymentOrderPaidStatus.Response PublicCheckPaymentOrderPaidStatus(PublicCheckPaymentOrderPaidStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicCheckPaymentOrderPaidStatus.Response> PublicCheckPaymentOrderPaidStatusAsync(PublicCheckPaymentOrderPaidStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetPaymentPublicConfig.Response GetPaymentPublicConfig(GetPaymentPublicConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPaymentPublicConfig.Response> GetPaymentPublicConfigAsync(GetPaymentPublicConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetQRCode.Response PublicGetQRCode(PublicGetQRCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetQRCode.Response> PublicGetQRCodeAsync(PublicGetQRCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicNormalizePaymentReturnUrl.Response PublicNormalizePaymentReturnUrl(PublicNormalizePaymentReturnUrl input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicNormalizePaymentReturnUrl.Response> PublicNormalizePaymentReturnUrlAsync(PublicNormalizePaymentReturnUrl input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetPaymentTaxValue.Response GetPaymentTaxValue(GetPaymentTaxValue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPaymentTaxValue.Response> GetPaymentTaxValueAsync(GetPaymentTaxValue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}