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
    public class Anonymization
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Anonymization(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Anonymization(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AnonymizeCampaign.AnonymizeCampaignBuilder AnonymizeCampaignOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeCampaign.AnonymizeCampaignBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeEntitlement.AnonymizeEntitlementBuilder AnonymizeEntitlementOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeEntitlement.AnonymizeEntitlementBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeFulfillment.AnonymizeFulfillmentBuilder AnonymizeFulfillmentOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeFulfillment.AnonymizeFulfillmentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeIntegration.AnonymizeIntegrationBuilder AnonymizeIntegrationOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeIntegration.AnonymizeIntegrationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeOrder.AnonymizeOrderBuilder AnonymizeOrderOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeOrder.AnonymizeOrderBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizePayment.AnonymizePaymentBuilder AnonymizePaymentOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizePayment.AnonymizePaymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeRevocation.AnonymizeRevocationBuilder AnonymizeRevocationOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeRevocation.AnonymizeRevocationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeSubscription.AnonymizeSubscriptionBuilder AnonymizeSubscriptionOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeSubscription.AnonymizeSubscriptionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AnonymizeWallet.AnonymizeWalletBuilder AnonymizeWalletOp
        {
            get
            {
                var opBuilder = new Operation.AnonymizeWallet.AnonymizeWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public void AnonymizeCampaign(AnonymizeCampaign input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeCampaignAsync(AnonymizeCampaign input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeEntitlement(AnonymizeEntitlement input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeEntitlementAsync(AnonymizeEntitlement input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeFulfillment(AnonymizeFulfillment input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeFulfillmentAsync(AnonymizeFulfillment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeIntegration(AnonymizeIntegration input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeIntegrationAsync(AnonymizeIntegration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeOrder(AnonymizeOrder input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeOrderAsync(AnonymizeOrder input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizePayment(AnonymizePayment input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizePaymentAsync(AnonymizePayment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeRevocation(AnonymizeRevocation input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeRevocationAsync(AnonymizeRevocation input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeSubscription(AnonymizeSubscription input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeSubscriptionAsync(AnonymizeSubscription input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AnonymizeWallet(AnonymizeWallet input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AnonymizeWalletAsync(AnonymizeWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}