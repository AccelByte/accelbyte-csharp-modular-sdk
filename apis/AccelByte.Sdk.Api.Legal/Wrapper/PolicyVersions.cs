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
    public class PolicyVersions
    {
        private readonly IAccelByteSdk _sdk;

        public PolicyVersions(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePolicyVersion.UpdatePolicyVersionBuilder UpdatePolicyVersionOp
        {
            get { return new Operation.UpdatePolicyVersion.UpdatePolicyVersionBuilder(_sdk); }
        }
        public PublishPolicyVersion.PublishPolicyVersionBuilder PublishPolicyVersionOp
        {
            get { return new Operation.PublishPolicyVersion.PublishPolicyVersionBuilder(_sdk); }
        }
        public RetrieveSinglePolicyVersion.RetrieveSinglePolicyVersionBuilder RetrieveSinglePolicyVersionOp
        {
            get { return new Operation.RetrieveSinglePolicyVersion.RetrieveSinglePolicyVersionBuilder(_sdk); }
        }
        public CreatePolicyVersion.CreatePolicyVersionBuilder CreatePolicyVersionOp
        {
            get { return new Operation.CreatePolicyVersion.CreatePolicyVersionBuilder(_sdk); }
        }
        #endregion

        public Model.UpdatePolicyVersionResponse? UpdatePolicyVersion(UpdatePolicyVersion input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublishPolicyVersion(PublishPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrievePolicyVersionResponse>? RetrieveSinglePolicyVersion(RetrieveSinglePolicyVersion input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreatePolicyVersionResponse? CreatePolicyVersion(CreatePolicyVersion input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}