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
    public class Admin
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Admin(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Admin(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetWorkerConfig.GetWorkerConfigBuilder GetWorkerConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetWorkerConfig.GetWorkerConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateWorkerConfig.UpdateWorkerConfigBuilder UpdateWorkerConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdateWorkerConfig.UpdateWorkerConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateWorkerConfig.CreateWorkerConfigBuilder CreateWorkerConfigOp
        {
            get
            {
                var opBuilder = new Operation.CreateWorkerConfig.CreateWorkerConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AddBuffer.AddBufferBuilder AddBufferOp
        {
            get
            {
                var opBuilder = new Operation.AddBuffer.AddBufferBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListServer.ListServerBuilder ListServerOp
        {
            get
            {
                var opBuilder = new Operation.ListServer.ListServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CountServer.CountServerBuilder CountServerOp
        {
            get
            {
                var opBuilder = new Operation.CountServer.CountServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CountServerDetailed.CountServerDetailedBuilder CountServerDetailedOp
        {
            get
            {
                var opBuilder = new Operation.CountServerDetailed.CountServerDetailedBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListLocalServer.ListLocalServerBuilder ListLocalServerOp
        {
            get
            {
                var opBuilder = new Operation.ListLocalServer.ListLocalServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteLocalServer.DeleteLocalServerBuilder DeleteLocalServerOp
        {
            get
            {
                var opBuilder = new Operation.DeleteLocalServer.DeleteLocalServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetServer.GetServerBuilder GetServerOp
        {
            get
            {
                var opBuilder = new Operation.GetServer.GetServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteServer.DeleteServerBuilder DeleteServerOp
        {
            get
            {
                var opBuilder = new Operation.DeleteServer.DeleteServerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListSession.ListSessionBuilder ListSessionOp
        {
            get
            {
                var opBuilder = new Operation.ListSession.ListSessionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CountSession.CountSessionBuilder CountSessionOp
        {
            get
            {
                var opBuilder = new Operation.CountSession.CountSessionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteSession.DeleteSessionBuilder DeleteSessionOp
        {
            get
            {
                var opBuilder = new Operation.DeleteSession.DeleteSessionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RunGhostCleanerRequestHandler.RunGhostCleanerRequestHandlerBuilder RunGhostCleanerRequestHandlerOp
        {
            get
            {
                var opBuilder = new Operation.RunGhostCleanerRequestHandler.RunGhostCleanerRequestHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public RunZombieCleanerRequestHandler.RunZombieCleanerRequestHandlerBuilder RunZombieCleanerRequestHandlerOp
        {
            get
            {
                var opBuilder = new Operation.RunZombieCleanerRequestHandler.RunZombieCleanerRequestHandlerBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsWorkerConfig? GetWorkerConfig(GetWorkerConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsWorkerConfig?> GetWorkerConfigAsync(GetWorkerConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UpdateWorkerConfig(UpdateWorkerConfig input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UpdateWorkerConfigAsync(UpdateWorkerConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsWorkerConfig? CreateWorkerConfig(CreateWorkerConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsWorkerConfig?> CreateWorkerConfigAsync(CreateWorkerConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsAddBufferResponse? AddBuffer(AddBuffer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsAddBufferResponse?> AddBufferAsync(AddBuffer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListServer(ListServer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListServerResponse?> ListServerAsync(ListServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountServerResponse? CountServer(CountServer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCountServerResponse?> CountServerAsync(CountServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDetailedCountServerResponse? CountServerDetailed(CountServerDetailed input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDetailedCountServerResponse?> CountServerDetailedAsync(CountServerDetailed input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListLocalServer(ListLocalServer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListServerResponse?> ListLocalServerAsync(ListLocalServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLocalServer(DeleteLocalServer input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteLocalServerAsync(DeleteLocalServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServerDetailsResponse? GetServer(GetServer input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsServerDetailsResponse?> GetServerAsync(GetServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteServer(DeleteServer input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteServerAsync(DeleteServer input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListSessionResponse? ListSession(ListSession input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsListSessionResponse?> ListSessionAsync(ListSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountSessionResponse? CountSession(CountSession input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsCountSessionResponse?> CountSessionAsync(CountSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSession(DeleteSession input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteSessionAsync(DeleteSession input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void RunGhostCleanerRequestHandler(RunGhostCleanerRequestHandler input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task RunGhostCleanerRequestHandlerAsync(RunGhostCleanerRequestHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void RunZombieCleanerRequestHandler(RunZombieCleanerRequestHandler input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task RunZombieCleanerRequestHandlerAsync(RunZombieCleanerRequestHandler input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}