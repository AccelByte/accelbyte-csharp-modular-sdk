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

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class Configuration
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Configuration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Configuration(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public ListGroupConfigurationAdminV1.ListGroupConfigurationAdminV1Builder ListGroupConfigurationAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.ListGroupConfigurationAdminV1.ListGroupConfigurationAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateGroupConfigurationAdminV1.CreateGroupConfigurationAdminV1Builder CreateGroupConfigurationAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.CreateGroupConfigurationAdminV1.CreateGroupConfigurationAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public InitiateGroupConfigurationAdminV1.InitiateGroupConfigurationAdminV1Builder InitiateGroupConfigurationAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.InitiateGroupConfigurationAdminV1.InitiateGroupConfigurationAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGroupConfigurationAdminV1.GetGroupConfigurationAdminV1Builder GetGroupConfigurationAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupConfigurationAdminV1.GetGroupConfigurationAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupConfigurationV1.DeleteGroupConfigurationV1Builder DeleteGroupConfigurationV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupConfigurationV1.DeleteGroupConfigurationV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupConfigurationAdminV1.UpdateGroupConfigurationAdminV1Builder UpdateGroupConfigurationAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupConfigurationAdminV1.UpdateGroupConfigurationAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateGroupConfigurationGlobalRuleAdminV1.UpdateGroupConfigurationGlobalRuleAdminV1Builder UpdateGroupConfigurationGlobalRuleAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.UpdateGroupConfigurationGlobalRuleAdminV1.UpdateGroupConfigurationGlobalRuleAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteGroupConfigurationGlobalRuleAdminV1.DeleteGroupConfigurationGlobalRuleAdminV1Builder DeleteGroupConfigurationGlobalRuleAdminV1Op
        {
            get
            {
                var opBuilder = new Operation.DeleteGroupConfigurationGlobalRuleAdminV1.DeleteGroupConfigurationGlobalRuleAdminV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public ListGroupConfigurationAdminV1.Response ListGroupConfigurationAdminV1(ListGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListGroupConfigurationAdminV1.Response> ListGroupConfigurationAdminV1Async(ListGroupConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateGroupConfigurationAdminV1.Response CreateGroupConfigurationAdminV1(CreateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateGroupConfigurationAdminV1.Response> CreateGroupConfigurationAdminV1Async(CreateGroupConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public InitiateGroupConfigurationAdminV1.Response InitiateGroupConfigurationAdminV1(InitiateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<InitiateGroupConfigurationAdminV1.Response> InitiateGroupConfigurationAdminV1Async(InitiateGroupConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGroupConfigurationAdminV1.Response GetGroupConfigurationAdminV1(GetGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGroupConfigurationAdminV1.Response> GetGroupConfigurationAdminV1Async(GetGroupConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteGroupConfigurationV1.Response DeleteGroupConfigurationV1(DeleteGroupConfigurationV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteGroupConfigurationV1.Response> DeleteGroupConfigurationV1Async(DeleteGroupConfigurationV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateGroupConfigurationAdminV1.Response UpdateGroupConfigurationAdminV1(UpdateGroupConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateGroupConfigurationAdminV1.Response> UpdateGroupConfigurationAdminV1Async(UpdateGroupConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateGroupConfigurationGlobalRuleAdminV1.Response UpdateGroupConfigurationGlobalRuleAdminV1(UpdateGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateGroupConfigurationGlobalRuleAdminV1.Response> UpdateGroupConfigurationGlobalRuleAdminV1Async(UpdateGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteGroupConfigurationGlobalRuleAdminV1.Response DeleteGroupConfigurationGlobalRuleAdminV1(DeleteGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteGroupConfigurationGlobalRuleAdminV1.Response> DeleteGroupConfigurationGlobalRuleAdminV1Async(DeleteGroupConfigurationGlobalRuleAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}