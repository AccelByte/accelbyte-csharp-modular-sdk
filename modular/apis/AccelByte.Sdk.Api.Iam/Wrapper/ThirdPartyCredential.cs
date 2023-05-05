// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class ThirdPartyCredential
    {
        private readonly IAccelByteSdk _sdk;

        public ThirdPartyCredential(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public RetrieveAllThirdPartyLoginPlatformCredentialV3.RetrieveAllThirdPartyLoginPlatformCredentialV3Builder RetrieveAllThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.RetrieveAllThirdPartyLoginPlatformCredentialV3.RetrieveAllThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public RetrieveThirdPartyLoginPlatformCredentialV3.RetrieveThirdPartyLoginPlatformCredentialV3Builder RetrieveThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.RetrieveThirdPartyLoginPlatformCredentialV3.RetrieveThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public AddThirdPartyLoginPlatformCredentialV3.AddThirdPartyLoginPlatformCredentialV3Builder AddThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.AddThirdPartyLoginPlatformCredentialV3.AddThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public DeleteThirdPartyLoginPlatformCredentialV3.DeleteThirdPartyLoginPlatformCredentialV3Builder DeleteThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.DeleteThirdPartyLoginPlatformCredentialV3.DeleteThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public UpdateThirdPartyLoginPlatformCredentialV3.UpdateThirdPartyLoginPlatformCredentialV3Builder UpdateThirdPartyLoginPlatformCredentialV3Op
        {
            get { return new Operation.UpdateThirdPartyLoginPlatformCredentialV3.UpdateThirdPartyLoginPlatformCredentialV3Builder(_sdk); }
        }
        public UpdateThirdPartyLoginPlatformDomainV3.UpdateThirdPartyLoginPlatformDomainV3Builder UpdateThirdPartyLoginPlatformDomainV3Op
        {
            get { return new Operation.UpdateThirdPartyLoginPlatformDomainV3.UpdateThirdPartyLoginPlatformDomainV3Builder(_sdk); }
        }
        public DeleteThirdPartyLoginPlatformDomainV3.DeleteThirdPartyLoginPlatformDomainV3Builder DeleteThirdPartyLoginPlatformDomainV3Op
        {
            get { return new Operation.DeleteThirdPartyLoginPlatformDomainV3.DeleteThirdPartyLoginPlatformDomainV3Builder(_sdk); }
        }
        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Op
        {
            get { return new Operation.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Builder(_sdk); }
        }
        public RetrieveActiveOIDCClientsPublicV3.RetrieveActiveOIDCClientsPublicV3Builder RetrieveActiveOIDCClientsPublicV3Op
        {
            get { return new Operation.RetrieveActiveOIDCClientsPublicV3.RetrieveActiveOIDCClientsPublicV3Builder(_sdk); }
        }
        #endregion
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllThirdPartyLoginPlatformCredentialV3(RetrieveAllThirdPartyLoginPlatformCredentialV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? RetrieveThirdPartyLoginPlatformCredentialV3(RetrieveThirdPartyLoginPlatformCredentialV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? AddThirdPartyLoginPlatformCredentialV3(AddThirdPartyLoginPlatformCredentialV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteThirdPartyLoginPlatformCredentialV3(DeleteThirdPartyLoginPlatformCredentialV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelThirdPartyLoginPlatformCredentialResponse? UpdateThirdPartyLoginPlatformCredentialV3(UpdateThirdPartyLoginPlatformCredentialV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPlatformDomainResponse? UpdateThirdPartyLoginPlatformDomainV3(UpdateThirdPartyLoginPlatformDomainV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteThirdPartyLoginPlatformDomainV3(DeleteThirdPartyLoginPlatformDomainV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelPublicThirdPartyPlatformInfo>? RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelPublicThirdPartyPlatformInfo>? RetrieveActiveOIDCClientsPublicV3(RetrieveActiveOIDCClientsPublicV3 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}