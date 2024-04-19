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
    public class BaseLegalPoliciesWithNamespace
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public BaseLegalPoliciesWithNamespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public BaseLegalPoliciesWithNamespace(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder RetrieveAllLegalPoliciesByNamespaceOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreatePolicy1.CreatePolicy1Builder CreatePolicy1Op
        {
            get
            {
                var opBuilder = new Operation.CreatePolicy1.CreatePolicy1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder RetrieveSinglePolicy1Op
        {
            get
            {
                var opBuilder = new Operation.RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PartialUpdatePolicy1.PartialUpdatePolicy1Builder PartialUpdatePolicy1Op
        {
            get
            {
                var opBuilder = new Operation.PartialUpdatePolicy1.PartialUpdatePolicy1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrievePolicyCountry1.RetrievePolicyCountry1Builder RetrievePolicyCountry1Op
        {
            get
            {
                var opBuilder = new Operation.RetrievePolicyCountry1.RetrievePolicyCountry1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder RetrieveAllPolicyTypes1Op
        {
            get
            {
                var opBuilder = new Operation.RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.RetrieveBasePolicyResponse>? RetrieveAllLegalPoliciesByNamespace(RetrieveAllLegalPoliciesByNamespace input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveBasePolicyResponse>?> RetrieveAllLegalPoliciesByNamespaceAsync(RetrieveAllLegalPoliciesByNamespace input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateBasePolicyResponse? CreatePolicy1(CreatePolicy1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CreateBasePolicyResponse?> CreatePolicy1Async(CreatePolicy1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveBasePolicyResponse? RetrieveSinglePolicy1(RetrieveSinglePolicy1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveBasePolicyResponse?> RetrieveSinglePolicy1Async(RetrieveSinglePolicy1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateBasePolicyResponse? PartialUpdatePolicy1(PartialUpdatePolicy1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UpdateBasePolicyResponse?> PartialUpdatePolicy1Async(PartialUpdatePolicy1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrievePolicyResponse? RetrievePolicyCountry1(RetrievePolicyCountry1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrievePolicyResponse?> RetrievePolicyCountry1Async(RetrievePolicyCountry1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyTypeResponse>? RetrieveAllPolicyTypes1(RetrieveAllPolicyTypes1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyTypeResponse>?> RetrieveAllPolicyTypes1Async(RetrieveAllPolicyTypes1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}