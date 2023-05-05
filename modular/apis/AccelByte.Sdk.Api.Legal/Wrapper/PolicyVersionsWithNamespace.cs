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
    public class PolicyVersionsWithNamespace
    {
        private readonly IAccelByteSdk _sdk;

        public PolicyVersionsWithNamespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePolicyVersion1.UpdatePolicyVersion1Builder UpdatePolicyVersion1Op
        {
            get { return new Operation.UpdatePolicyVersion1.UpdatePolicyVersion1Builder(_sdk); }
        }
        public PublishPolicyVersion1.PublishPolicyVersion1Builder PublishPolicyVersion1Op
        {
            get { return new Operation.PublishPolicyVersion1.PublishPolicyVersion1Builder(_sdk); }
        }
        public RetrieveSinglePolicyVersion1.RetrieveSinglePolicyVersion1Builder RetrieveSinglePolicyVersion1Op
        {
            get { return new Operation.RetrieveSinglePolicyVersion1.RetrieveSinglePolicyVersion1Builder(_sdk); }
        }
        public CreatePolicyVersion1.CreatePolicyVersion1Builder CreatePolicyVersion1Op
        {
            get { return new Operation.CreatePolicyVersion1.CreatePolicyVersion1Builder(_sdk); }
        }
        #endregion
        
        public Model.UpdatePolicyVersionResponse? UpdatePolicyVersion1(UpdatePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublishPolicyVersion1(PublishPolicyVersion1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrieveSinglePolicyVersion1(RetrieveSinglePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreatePolicyVersionResponse? CreatePolicyVersion1(CreatePolicyVersion1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}