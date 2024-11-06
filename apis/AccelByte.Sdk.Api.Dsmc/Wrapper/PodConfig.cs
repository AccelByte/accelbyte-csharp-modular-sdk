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

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class PodConfig
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PodConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PodConfig(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetLowestInstanceSpec.GetLowestInstanceSpecBuilder GetLowestInstanceSpecOp
        {
            get
            {
                var opBuilder = new Operation.GetLowestInstanceSpec.GetLowestInstanceSpecBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetAllPodConfig.GetAllPodConfigBuilder GetAllPodConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetAllPodConfig.GetAllPodConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetPodConfig.GetPodConfigBuilder GetPodConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetPodConfig.GetPodConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreatePodConfig.CreatePodConfigBuilder CreatePodConfigOp
        {
            get
            {
                var opBuilder = new Operation.CreatePodConfig.CreatePodConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeletePodConfig.DeletePodConfigBuilder DeletePodConfigOp
        {
            get
            {
                var opBuilder = new Operation.DeletePodConfig.DeletePodConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePodConfig.UpdatePodConfigBuilder UpdatePodConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdatePodConfig.UpdatePodConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetAllPodConfigClient.GetAllPodConfigClientBuilder GetAllPodConfigClientOp
        {
            get
            {
                var opBuilder = new Operation.GetAllPodConfigClient.GetAllPodConfigClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreatePodConfigClient.CreatePodConfigClientBuilder CreatePodConfigClientOp
        {
            get
            {
                var opBuilder = new Operation.CreatePodConfigClient.CreatePodConfigClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeletePodConfigClient.DeletePodConfigClientBuilder DeletePodConfigClientOp
        {
            get
            {
                var opBuilder = new Operation.DeletePodConfigClient.DeletePodConfigClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetLowestInstanceSpec.Response GetLowestInstanceSpec(GetLowestInstanceSpec input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetLowestInstanceSpec.Response> GetLowestInstanceSpecAsync(GetLowestInstanceSpec input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetAllPodConfig.Response GetAllPodConfig(GetAllPodConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPodConfig.Response> GetAllPodConfigAsync(GetAllPodConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetPodConfig.Response GetPodConfig(GetPodConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPodConfig.Response> GetPodConfigAsync(GetPodConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreatePodConfig.Response CreatePodConfig(CreatePodConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreatePodConfig.Response> CreatePodConfigAsync(CreatePodConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeletePodConfig.Response DeletePodConfig(DeletePodConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeletePodConfig.Response> DeletePodConfigAsync(DeletePodConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdatePodConfig.Response UpdatePodConfig(UpdatePodConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdatePodConfig.Response> UpdatePodConfigAsync(UpdatePodConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetAllPodConfigClient.Response GetAllPodConfigClient(GetAllPodConfigClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllPodConfigClient.Response> GetAllPodConfigClientAsync(GetAllPodConfigClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreatePodConfigClient.Response CreatePodConfigClient(CreatePodConfigClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreatePodConfigClient.Response> CreatePodConfigClientAsync(CreatePodConfigClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeletePodConfigClient.Response DeletePodConfigClient(DeletePodConfigClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeletePodConfigClient.Response> DeletePodConfigClientAsync(DeletePodConfigClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}