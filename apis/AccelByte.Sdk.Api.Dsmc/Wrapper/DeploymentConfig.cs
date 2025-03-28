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
    public class DeploymentConfig
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public DeploymentConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public DeploymentConfig(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetAllDeployment.GetAllDeploymentBuilder GetAllDeploymentOp
        {
            get
            {
                var opBuilder = new Operation.GetAllDeployment.GetAllDeploymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetDeployment.GetDeploymentBuilder GetDeploymentOp
        {
            get
            {
                var opBuilder = new Operation.GetDeployment.GetDeploymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateDeployment.CreateDeploymentBuilder CreateDeploymentOp
        {
            get
            {
                var opBuilder = new Operation.CreateDeployment.CreateDeploymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteDeployment.DeleteDeploymentBuilder DeleteDeploymentOp
        {
            get
            {
                var opBuilder = new Operation.DeleteDeployment.DeleteDeploymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateDeployment.UpdateDeploymentBuilder UpdateDeploymentOp
        {
            get
            {
                var opBuilder = new Operation.UpdateDeployment.UpdateDeploymentBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateRootRegionOverride.CreateRootRegionOverrideBuilder CreateRootRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.CreateRootRegionOverride.CreateRootRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder DeleteRootRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.DeleteRootRegionOverride.DeleteRootRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder UpdateRootRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.UpdateRootRegionOverride.UpdateRootRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateDeploymentOverride.CreateDeploymentOverrideBuilder CreateDeploymentOverrideOp
        {
            get
            {
                var opBuilder = new Operation.CreateDeploymentOverride.CreateDeploymentOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder DeleteDeploymentOverrideOp
        {
            get
            {
                var opBuilder = new Operation.DeleteDeploymentOverride.DeleteDeploymentOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder UpdateDeploymentOverrideOp
        {
            get
            {
                var opBuilder = new Operation.UpdateDeploymentOverride.UpdateDeploymentOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder CreateOverrideRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.CreateOverrideRegionOverride.CreateOverrideRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder DeleteOverrideRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.DeleteOverrideRegionOverride.DeleteOverrideRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder UpdateOverrideRegionOverrideOp
        {
            get
            {
                var opBuilder = new Operation.UpdateOverrideRegionOverride.UpdateOverrideRegionOverrideBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteCreatingServerCountQueue.DeleteCreatingServerCountQueueBuilder DeleteCreatingServerCountQueueOp
        {
            get
            {
                var opBuilder = new Operation.DeleteCreatingServerCountQueue.DeleteCreatingServerCountQueueBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetAllDeploymentClient.GetAllDeploymentClientBuilder GetAllDeploymentClientOp
        {
            get
            {
                var opBuilder = new Operation.GetAllDeploymentClient.GetAllDeploymentClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetDeploymentClient.GetDeploymentClientBuilder GetDeploymentClientOp
        {
            get
            {
                var opBuilder = new Operation.GetDeploymentClient.GetDeploymentClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateDeploymentClient.CreateDeploymentClientBuilder CreateDeploymentClientOp
        {
            get
            {
                var opBuilder = new Operation.CreateDeploymentClient.CreateDeploymentClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteDeploymentClient.DeleteDeploymentClientBuilder DeleteDeploymentClientOp
        {
            get
            {
                var opBuilder = new Operation.DeleteDeploymentClient.DeleteDeploymentClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetAllDeployment.Response GetAllDeployment(GetAllDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllDeployment.Response> GetAllDeploymentAsync(GetAllDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetDeployment.Response GetDeployment(GetDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetDeployment.Response> GetDeploymentAsync(GetDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateDeployment.Response CreateDeployment(CreateDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateDeployment.Response> CreateDeploymentAsync(CreateDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteDeployment.Response DeleteDeployment(DeleteDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteDeployment.Response> DeleteDeploymentAsync(DeleteDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateDeployment.Response UpdateDeployment(UpdateDeployment input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateDeployment.Response> UpdateDeploymentAsync(UpdateDeployment input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateRootRegionOverride.Response CreateRootRegionOverride(CreateRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateRootRegionOverride.Response> CreateRootRegionOverrideAsync(CreateRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteRootRegionOverride.Response DeleteRootRegionOverride(DeleteRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteRootRegionOverride.Response> DeleteRootRegionOverrideAsync(DeleteRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateRootRegionOverride.Response UpdateRootRegionOverride(UpdateRootRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateRootRegionOverride.Response> UpdateRootRegionOverrideAsync(UpdateRootRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateDeploymentOverride.Response CreateDeploymentOverride(CreateDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateDeploymentOverride.Response> CreateDeploymentOverrideAsync(CreateDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteDeploymentOverride.Response DeleteDeploymentOverride(DeleteDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteDeploymentOverride.Response> DeleteDeploymentOverrideAsync(DeleteDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateDeploymentOverride.Response UpdateDeploymentOverride(UpdateDeploymentOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateDeploymentOverride.Response> UpdateDeploymentOverrideAsync(UpdateDeploymentOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateOverrideRegionOverride.Response CreateOverrideRegionOverride(CreateOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateOverrideRegionOverride.Response> CreateOverrideRegionOverrideAsync(CreateOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteOverrideRegionOverride.Response DeleteOverrideRegionOverride(DeleteOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteOverrideRegionOverride.Response> DeleteOverrideRegionOverrideAsync(DeleteOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateOverrideRegionOverride.Response UpdateOverrideRegionOverride(UpdateOverrideRegionOverride input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateOverrideRegionOverride.Response> UpdateOverrideRegionOverrideAsync(UpdateOverrideRegionOverride input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteCreatingServerCountQueue.Response DeleteCreatingServerCountQueue(DeleteCreatingServerCountQueue input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteCreatingServerCountQueue.Response> DeleteCreatingServerCountQueueAsync(DeleteCreatingServerCountQueue input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetAllDeploymentClient.Response GetAllDeploymentClient(GetAllDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetAllDeploymentClient.Response> GetAllDeploymentClientAsync(GetAllDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetDeploymentClient.Response GetDeploymentClient(GetDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetDeploymentClient.Response> GetDeploymentClientAsync(GetDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateDeploymentClient.Response CreateDeploymentClient(CreateDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateDeploymentClient.Response> CreateDeploymentClientAsync(CreateDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteDeploymentClient.Response DeleteDeploymentClient(DeleteDeploymentClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteDeploymentClient.Response> DeleteDeploymentClientAsync(DeleteDeploymentClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}