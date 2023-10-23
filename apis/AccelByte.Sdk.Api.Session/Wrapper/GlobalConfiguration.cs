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
    public class GlobalConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        public GlobalConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListGlobalConfiguration.AdminListGlobalConfigurationBuilder AdminListGlobalConfigurationOp
        {
            get { return new Operation.AdminListGlobalConfiguration.AdminListGlobalConfigurationBuilder(_sdk); }
        }
        public AdminUpdateGlobalConfiguration.AdminUpdateGlobalConfigurationBuilder AdminUpdateGlobalConfigurationOp
        {
            get { return new Operation.AdminUpdateGlobalConfiguration.AdminUpdateGlobalConfigurationBuilder(_sdk); }
        }
        public AdminDeleteGlobalConfiguration.AdminDeleteGlobalConfigurationBuilder AdminDeleteGlobalConfigurationOp
        {
            get { return new Operation.AdminDeleteGlobalConfiguration.AdminDeleteGlobalConfigurationBuilder(_sdk); }
        }
        #endregion

        public Model.ApimodelsGlobalConfigurationResponse? AdminListGlobalConfiguration(AdminListGlobalConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsGlobalConfigurationResponse? AdminUpdateGlobalConfiguration(AdminUpdateGlobalConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public string? AdminDeleteGlobalConfiguration(AdminDeleteGlobalConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}