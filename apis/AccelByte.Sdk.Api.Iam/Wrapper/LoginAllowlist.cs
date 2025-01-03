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
    public class LoginAllowlist
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public LoginAllowlist(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public LoginAllowlist(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetLoginAllowlistV3.AdminGetLoginAllowlistV3Builder AdminGetLoginAllowlistV3Op
        {
            get
            {
                var opBuilder = new Operation.AdminGetLoginAllowlistV3.AdminGetLoginAllowlistV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateLoginAllowlistV3.AdminUpdateLoginAllowlistV3Builder AdminUpdateLoginAllowlistV3Op
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateLoginAllowlistV3.AdminUpdateLoginAllowlistV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminGetLoginAllowlistV3.Response AdminGetLoginAllowlistV3(AdminGetLoginAllowlistV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetLoginAllowlistV3.Response> AdminGetLoginAllowlistV3Async(AdminGetLoginAllowlistV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminUpdateLoginAllowlistV3.Response AdminUpdateLoginAllowlistV3(AdminUpdateLoginAllowlistV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdateLoginAllowlistV3.Response> AdminUpdateLoginAllowlistV3Async(AdminUpdateLoginAllowlistV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}