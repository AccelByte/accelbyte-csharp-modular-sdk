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

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Policies
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Policies(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Policies(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public RetrievePolicies.RetrievePoliciesBuilder RetrievePoliciesOp
        {
            get
            {
                var opBuilder = new Operation.RetrievePolicies.RetrievePoliciesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePolicy.UpdatePolicyBuilder UpdatePolicyOp
        {
            get
            {
                var opBuilder = new Operation.UpdatePolicy.UpdatePolicyBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SetDefaultPolicy2.SetDefaultPolicy2Builder SetDefaultPolicy2Op
        {
            get
            {
                var opBuilder = new Operation.SetDefaultPolicy2.SetDefaultPolicy2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveCountryListWithPolicies.RetrieveCountryListWithPoliciesBuilder RetrieveCountryListWithPoliciesOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveCountryListWithPolicies.RetrieveCountryListWithPoliciesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveLatestPolicies.RetrieveLatestPoliciesBuilder RetrieveLatestPoliciesOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveLatestPolicies.RetrieveLatestPoliciesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveLatestPoliciesPublic.RetrieveLatestPoliciesPublicBuilder RetrieveLatestPoliciesPublicOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveLatestPoliciesPublic.RetrieveLatestPoliciesPublicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveLatestPoliciesByNamespaceAndCountryPublic.RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder RetrieveLatestPoliciesByNamespaceAndCountryPublicOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveLatestPoliciesByNamespaceAndCountryPublic.RetrieveLatestPoliciesByNamespaceAndCountryPublicBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.RetrievePolicyResponse>? RetrievePolicies(RetrievePolicies input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyResponse>?> RetrievePoliciesAsync(RetrievePolicies input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdatePolicy(UpdatePolicy input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdatePolicyAsync(UpdatePolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy2(SetDefaultPolicy2 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SetDefaultPolicy2Async(SetDefaultPolicy2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? RetrieveCountryListWithPolicies(RetrieveCountryListWithPolicies input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<string>?> RetrieveCountryListWithPoliciesAsync(RetrieveCountryListWithPolicies input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPolicies(RetrieveLatestPolicies input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyPublicResponse>?> RetrieveLatestPoliciesAsync(RetrieveLatestPolicies input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesPublic(RetrieveLatestPoliciesPublic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyPublicResponse>?> RetrieveLatestPoliciesPublicAsync(RetrieveLatestPoliciesPublic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyPublicResponse>? RetrieveLatestPoliciesByNamespaceAndCountryPublic(RetrieveLatestPoliciesByNamespaceAndCountryPublic input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyPublicResponse>?> RetrieveLatestPoliciesByNamespaceAndCountryPublicAsync(RetrieveLatestPoliciesByNamespaceAndCountryPublic input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}