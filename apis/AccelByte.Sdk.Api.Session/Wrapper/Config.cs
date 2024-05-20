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

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
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
        #endregion

        public Model.LogconfigConfiguration? AdminGetLogConfig(AdminGetLogConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.LogconfigConfiguration?> AdminGetLogConfigAsync(AdminGetLogConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.LogconfigConfiguration? AdminPatchUpdateLogConfig(AdminPatchUpdateLogConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.LogconfigConfiguration?> AdminPatchUpdateLogConfigAsync(AdminPatchUpdateLogConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}