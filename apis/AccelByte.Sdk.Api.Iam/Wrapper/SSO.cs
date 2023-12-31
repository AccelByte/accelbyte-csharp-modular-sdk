// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class SSO
    {
        private readonly IAccelByteSdk _sdk;

        public SSO(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public LoginSSOClient.LoginSSOClientBuilder LoginSSOClientOp
        {
            get { return new Operation.LoginSSOClient.LoginSSOClientBuilder(_sdk); }
        }
        public LogoutSSOClient.LogoutSSOClientBuilder LogoutSSOClientOp
        {
            get { return new Operation.LogoutSSOClient.LogoutSSOClientBuilder(_sdk); }
        }
        #endregion

        public void LoginSSOClient(LoginSSOClient input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void LogoutSSOClient(LogoutSSOClient input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}