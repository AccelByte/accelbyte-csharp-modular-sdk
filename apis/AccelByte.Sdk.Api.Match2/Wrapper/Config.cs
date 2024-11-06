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

using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Api.Match2.Wrapper
{
    public class Config
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Config(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Config(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetLogConfig.AdminGetLogConfigBuilder AdminGetLogConfigOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetLogConfig.AdminGetLogConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPatchUpdateLogConfig.AdminPatchUpdateLogConfigBuilder AdminPatchUpdateLogConfigOp
        {
            get
            {
                var opBuilder = new Operation.AdminPatchUpdateLogConfig.AdminPatchUpdateLogConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetAllConfigV1.AdminGetAllConfigV1Builder AdminGetAllConfigV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetAllConfigV1.AdminGetAllConfigV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetConfigV1.AdminGetConfigV1Builder AdminGetConfigV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetConfigV1.AdminGetConfigV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPatchConfigV1.AdminPatchConfigV1Builder AdminPatchConfigV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminPatchConfigV1.AdminPatchConfigV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminGetLogConfig.Response AdminGetLogConfig(AdminGetLogConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetLogConfig.Response> AdminGetLogConfigAsync(AdminGetLogConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPatchUpdateLogConfig.Response AdminPatchUpdateLogConfig(AdminPatchUpdateLogConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPatchUpdateLogConfig.Response> AdminPatchUpdateLogConfigAsync(AdminPatchUpdateLogConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetAllConfigV1.Response AdminGetAllConfigV1(AdminGetAllConfigV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetAllConfigV1.Response> AdminGetAllConfigV1Async(AdminGetAllConfigV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetConfigV1.Response AdminGetConfigV1(AdminGetConfigV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetConfigV1.Response> AdminGetConfigV1Async(AdminGetConfigV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminPatchConfigV1.Response AdminPatchConfigV1(AdminPatchConfigV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminPatchConfigV1.Response> AdminPatchConfigV1Async(AdminPatchConfigV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}