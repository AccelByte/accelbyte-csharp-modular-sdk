// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Api.Session.Wrapper
{
    public class PlatformCredential
    {
        private readonly IAccelByteSdk _sdk;

        public PlatformCredential(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetPlatformCredentials.AdminGetPlatformCredentialsBuilder AdminGetPlatformCredentialsOp
        {
            get { return new Operation.AdminGetPlatformCredentials.AdminGetPlatformCredentialsBuilder(_sdk); }
        }
        public AdminUpdatePlatformCredentials.AdminUpdatePlatformCredentialsBuilder AdminUpdatePlatformCredentialsOp
        {
            get { return new Operation.AdminUpdatePlatformCredentials.AdminUpdatePlatformCredentialsBuilder(_sdk); }
        }
        public AdminDeletePlatformCredentials.AdminDeletePlatformCredentialsBuilder AdminDeletePlatformCredentialsOp
        {
            get { return new Operation.AdminDeletePlatformCredentials.AdminDeletePlatformCredentialsBuilder(_sdk); }
        }
        #endregion
        
        public Model.ModelsPlatformCredentials? AdminGetPlatformCredentials(AdminGetPlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPlatformCredentials? AdminUpdatePlatformCredentials(AdminUpdatePlatformCredentials input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlatformCredentials(AdminDeletePlatformCredentials input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}