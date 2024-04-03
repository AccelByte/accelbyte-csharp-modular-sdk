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
    public class BaseLegalPolicies
    {
        private readonly IAccelByteSdk _sdk;

        public BaseLegalPolicies(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAllLegalPolicies.RetrieveAllLegalPoliciesBuilder RetrieveAllLegalPoliciesOp
        {
            get { return new Operation.RetrieveAllLegalPolicies.RetrieveAllLegalPoliciesBuilder(_sdk); }
        }
        public CreatePolicy.CreatePolicyBuilder CreatePolicyOp
        {
            get { return new Operation.CreatePolicy.CreatePolicyBuilder(_sdk); }
        }
        public RetrieveSinglePolicy.RetrieveSinglePolicyBuilder RetrieveSinglePolicyOp
        {
            get { return new Operation.RetrieveSinglePolicy.RetrieveSinglePolicyBuilder(_sdk); }
        }
        public PartialUpdatePolicy.PartialUpdatePolicyBuilder PartialUpdatePolicyOp
        {
            get { return new Operation.PartialUpdatePolicy.PartialUpdatePolicyBuilder(_sdk); }
        }
        public RetrievePolicyCountry.RetrievePolicyCountryBuilder RetrievePolicyCountryOp
        {
            get { return new Operation.RetrievePolicyCountry.RetrievePolicyCountryBuilder(_sdk); }
        }
        public RetrieveAllPolicyTypes.RetrieveAllPolicyTypesBuilder RetrieveAllPolicyTypesOp
        {
            get { return new Operation.RetrieveAllPolicyTypes.RetrieveAllPolicyTypesBuilder(_sdk); }
        }
        #endregion

        public List<Model.RetrieveBasePolicyResponse>? RetrieveAllLegalPolicies(RetrieveAllLegalPolicies input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveBasePolicyResponse>?> RetrieveAllLegalPoliciesAsync(RetrieveAllLegalPolicies input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateBasePolicyResponse? CreatePolicy(CreatePolicy input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CreateBasePolicyResponse?> CreatePolicyAsync(CreatePolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveBasePolicyResponse? RetrieveSinglePolicy(RetrieveSinglePolicy input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveBasePolicyResponse?> RetrieveSinglePolicyAsync(RetrieveSinglePolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateBasePolicyResponse? PartialUpdatePolicy(PartialUpdatePolicy input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UpdateBasePolicyResponse?> PartialUpdatePolicyAsync(PartialUpdatePolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrievePolicyResponse? RetrievePolicyCountry(RetrievePolicyCountry input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrievePolicyResponse?> RetrievePolicyCountryAsync(RetrievePolicyCountry input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyTypeResponse>? RetrieveAllPolicyTypes(RetrieveAllPolicyTypes input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrievePolicyTypeResponse>?> RetrieveAllPolicyTypesAsync(RetrieveAllPolicyTypes input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}