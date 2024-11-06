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

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
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
        public AdminGetConfigValueV3.AdminGetConfigValueV3Builder AdminGetConfigValueV3Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetConfigValueV3.AdminGetConfigValueV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetConfigValueV3.PublicGetConfigValueV3Builder PublicGetConfigValueV3Op
        {
            get
            {
                var opBuilder = new Operation.PublicGetConfigValueV3.PublicGetConfigValueV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminGetConfigValueV3.Response AdminGetConfigValueV3(AdminGetConfigValueV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetConfigValueV3.Response> AdminGetConfigValueV3Async(AdminGetConfigValueV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminGetConfigValueV3.Response<T1> AdminGetConfigValueV3<T1>(AdminGetConfigValueV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetConfigValueV3.Response<T1>> AdminGetConfigValueV3Async<T1>(AdminGetConfigValueV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetConfigValueV3.Response PublicGetConfigValueV3(PublicGetConfigValueV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetConfigValueV3.Response> PublicGetConfigValueV3Async(PublicGetConfigValueV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicGetConfigValueV3.Response<T1> PublicGetConfigValueV3<T1>(PublicGetConfigValueV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetConfigValueV3.Response<T1>> PublicGetConfigValueV3Async<T1>(PublicGetConfigValueV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}