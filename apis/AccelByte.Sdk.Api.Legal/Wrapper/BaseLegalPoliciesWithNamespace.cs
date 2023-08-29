// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class BaseLegalPoliciesWithNamespace
    {
        private readonly IAccelByteSdk _sdk;

        public BaseLegalPoliciesWithNamespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder RetrieveAllLegalPoliciesByNamespaceOp
        {
            get { return new Operation.RetrieveAllLegalPoliciesByNamespace.RetrieveAllLegalPoliciesByNamespaceBuilder(_sdk); }
        }
        public CreatePolicy1.CreatePolicy1Builder CreatePolicy1Op
        {
            get { return new Operation.CreatePolicy1.CreatePolicy1Builder(_sdk); }
        }
        public RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder RetrieveSinglePolicy1Op
        {
            get { return new Operation.RetrieveSinglePolicy1.RetrieveSinglePolicy1Builder(_sdk); }
        }
        public PartialUpdatePolicy1.PartialUpdatePolicy1Builder PartialUpdatePolicy1Op
        {
            get { return new Operation.PartialUpdatePolicy1.PartialUpdatePolicy1Builder(_sdk); }
        }
        public RetrievePolicyCountry1.RetrievePolicyCountry1Builder RetrievePolicyCountry1Op
        {
            get { return new Operation.RetrievePolicyCountry1.RetrievePolicyCountry1Builder(_sdk); }
        }
        public RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder RetrieveAllPolicyTypes1Op
        {
            get { return new Operation.RetrieveAllPolicyTypes1.RetrieveAllPolicyTypes1Builder(_sdk); }
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
        public Model.CreateBasePolicyResponse? CreatePolicy1(CreatePolicy1 input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.UpdateBasePolicyResponse? PartialUpdatePolicy1(PartialUpdatePolicy1 input)
        {
            var response = _sdk.RunRequest(input);

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
        public List<Model.RetrievePolicyTypeResponse>? RetrieveAllPolicyTypes1(RetrieveAllPolicyTypes1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}