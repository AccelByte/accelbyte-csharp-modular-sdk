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

using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class AdminInventoryConfigurations
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminInventoryConfigurations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminInventoryConfigurations(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder AdminListInventoryConfigurationsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder AdminCreateInventoryConfigurationOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder AdminGetInventoryConfigurationOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder AdminUpdateInventoryConfigurationOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder AdminDeleteInventoryConfigurationOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ApimodelsListInventoryConfigurationsResp? AdminListInventoryConfigurations(AdminListInventoryConfigurations input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListInventoryConfigurationsResp?> AdminListInventoryConfigurationsAsync(AdminListInventoryConfigurations input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryConfigurationResp? AdminCreateInventoryConfiguration(AdminCreateInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryConfigurationResp?> AdminCreateInventoryConfigurationAsync(AdminCreateInventoryConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryConfigurationResp? AdminGetInventoryConfiguration(AdminGetInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryConfigurationResp?> AdminGetInventoryConfigurationAsync(AdminGetInventoryConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryConfigurationResp? AdminUpdateInventoryConfiguration(AdminUpdateInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryConfigurationResp?> AdminUpdateInventoryConfigurationAsync(AdminUpdateInventoryConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteInventoryConfiguration(AdminDeleteInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminDeleteInventoryConfigurationAsync(AdminDeleteInventoryConfiguration input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}