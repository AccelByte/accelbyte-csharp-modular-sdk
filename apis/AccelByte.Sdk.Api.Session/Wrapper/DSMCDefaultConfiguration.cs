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
    public class DSMCDefaultConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public DSMCDefaultConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public DSMCDefaultConfiguration(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetDSMCConfigurationDefault.AdminGetDSMCConfigurationDefaultBuilder AdminGetDSMCConfigurationDefaultOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetDSMCConfigurationDefault.AdminGetDSMCConfigurationDefaultBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsDefaultDSMCConfig? AdminGetDSMCConfigurationDefault(AdminGetDSMCConfigurationDefault input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDefaultDSMCConfig?> AdminGetDSMCConfigurationDefaultAsync(AdminGetDSMCConfigurationDefault input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}