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
    public class LocalizedPolicyVersions
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public LocalizedPolicyVersions(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public LocalizedPolicyVersions(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public RetrieveLocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsBuilder RetrieveLocalizedPolicyVersionsOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveLocalizedPolicyVersions.RetrieveLocalizedPolicyVersionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateLocalizedPolicyVersion.CreateLocalizedPolicyVersionBuilder CreateLocalizedPolicyVersionOp
        {
            get
            {
                var opBuilder = new Operation.CreateLocalizedPolicyVersion.CreateLocalizedPolicyVersionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveSingleLocalizedPolicyVersion.RetrieveSingleLocalizedPolicyVersionBuilder RetrieveSingleLocalizedPolicyVersionOp
        {
            get
            {
                var opBuilder = new Operation.RetrieveSingleLocalizedPolicyVersion.RetrieveSingleLocalizedPolicyVersionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateLocalizedPolicyVersion.UpdateLocalizedPolicyVersionBuilder UpdateLocalizedPolicyVersionOp
        {
            get
            {
                var opBuilder = new Operation.UpdateLocalizedPolicyVersion.UpdateLocalizedPolicyVersionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RequestPresignedURL.RequestPresignedURLBuilder RequestPresignedURLOp
        {
            get
            {
                var opBuilder = new Operation.RequestPresignedURL.RequestPresignedURLBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SetDefaultPolicy.SetDefaultPolicyBuilder SetDefaultPolicyOp
        {
            get
            {
                var opBuilder = new Operation.SetDefaultPolicy.SetDefaultPolicyBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RetrieveSingleLocalizedPolicyVersion2.RetrieveSingleLocalizedPolicyVersion2Builder RetrieveSingleLocalizedPolicyVersion2Op
        {
            get
            {
                var opBuilder = new Operation.RetrieveSingleLocalizedPolicyVersion2.RetrieveSingleLocalizedPolicyVersion2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.RetrieveLocalizedPolicyVersionResponse>? RetrieveLocalizedPolicyVersions(RetrieveLocalizedPolicyVersions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveLocalizedPolicyVersionResponse>?> RetrieveLocalizedPolicyVersionsAsync(RetrieveLocalizedPolicyVersions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CreateLocalizedPolicyVersionResponse? CreateLocalizedPolicyVersion(CreateLocalizedPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.CreateLocalizedPolicyVersionResponse?> CreateLocalizedPolicyVersionAsync(CreateLocalizedPolicyVersion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionResponse? RetrieveSingleLocalizedPolicyVersion(RetrieveSingleLocalizedPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveLocalizedPolicyVersionResponse?> RetrieveSingleLocalizedPolicyVersionAsync(RetrieveSingleLocalizedPolicyVersion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UpdateLocalizedPolicyVersionResponse? UpdateLocalizedPolicyVersion(UpdateLocalizedPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UpdateLocalizedPolicyVersionResponse?> UpdateLocalizedPolicyVersionAsync(UpdateLocalizedPolicyVersion input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? RequestPresignedURL(RequestPresignedURL input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.UploadLocalizedPolicyVersionAttachmentResponse?> RequestPresignedURLAsync(RequestPresignedURL input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy(SetDefaultPolicy input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SetDefaultPolicyAsync(SetDefaultPolicy input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveLocalizedPolicyVersionPublicResponse? RetrieveSingleLocalizedPolicyVersion2(RetrieveSingleLocalizedPolicyVersion2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.RetrieveLocalizedPolicyVersionPublicResponse?> RetrieveSingleLocalizedPolicyVersion2Async(RetrieveSingleLocalizedPolicyVersion2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}