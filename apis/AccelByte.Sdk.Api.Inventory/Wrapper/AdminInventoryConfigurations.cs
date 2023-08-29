// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Api.Inventory.Wrapper
{
    public class AdminInventoryConfigurations
    {
        private readonly IAccelByteSdk _sdk;

        public AdminInventoryConfigurations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder AdminListInventoryConfigurationsOp
        {
            get { return new Operation.AdminListInventoryConfigurations.AdminListInventoryConfigurationsBuilder(_sdk); }
        }
        public AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder AdminCreateInventoryConfigurationOp
        {
            get { return new Operation.AdminCreateInventoryConfiguration.AdminCreateInventoryConfigurationBuilder(_sdk); }
        }
        public AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder AdminGetInventoryConfigurationOp
        {
            get { return new Operation.AdminGetInventoryConfiguration.AdminGetInventoryConfigurationBuilder(_sdk); }
        }
        public AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder AdminUpdateInventoryConfigurationOp
        {
            get { return new Operation.AdminUpdateInventoryConfiguration.AdminUpdateInventoryConfigurationBuilder(_sdk); }
        }
        public AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder AdminDeleteInventoryConfigurationOp
        {
            get { return new Operation.AdminDeleteInventoryConfiguration.AdminDeleteInventoryConfigurationBuilder(_sdk); }
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
        public Model.ApimodelsInventoryConfigurationResp? AdminCreateInventoryConfiguration(AdminCreateInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.ApimodelsInventoryConfigurationResp? AdminUpdateInventoryConfiguration(AdminUpdateInventoryConfiguration input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteInventoryConfiguration(AdminDeleteInventoryConfiguration input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}