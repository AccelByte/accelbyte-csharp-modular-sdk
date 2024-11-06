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
    public class SSO
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public SSO(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public SSO(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public LoginSSOClient.LoginSSOClientBuilder LoginSSOClientOp
        {
            get
            {
                var opBuilder = new Operation.LoginSSOClient.LoginSSOClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public LogoutSSOClient.LogoutSSOClientBuilder LogoutSSOClientOp
        {
            get
            {
                var opBuilder = new Operation.LogoutSSOClient.LogoutSSOClientBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public LoginSSOClient.Response LoginSSOClient(LoginSSOClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<LoginSSOClient.Response> LoginSSOClientAsync(LoginSSOClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public LogoutSSOClient.Response LogoutSSOClient(LogoutSSOClient input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<LogoutSSOClient.Response> LogoutSSOClientAsync(LogoutSSOClient input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}