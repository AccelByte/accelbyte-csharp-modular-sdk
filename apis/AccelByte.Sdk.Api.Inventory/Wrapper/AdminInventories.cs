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
    public class AdminInventories
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminInventories(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminInventories(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListInventories.AdminListInventoriesBuilder AdminListInventoriesOp
        {
            get
            {
                var opBuilder = new Operation.AdminListInventories.AdminListInventoriesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateInventory.AdminCreateInventoryBuilder AdminCreateInventoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateInventory.AdminCreateInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInventory.AdminGetInventoryBuilder AdminGetInventoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInventory.AdminGetInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateInventory.AdminUpdateInventoryBuilder AdminUpdateInventoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateInventory.AdminUpdateInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteInventory.DeleteInventoryBuilder DeleteInventoryOp
        {
            get
            {
                var opBuilder = new Operation.DeleteInventory.DeleteInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateUserInventoriesByInventoryCode.AdminUpdateUserInventoriesByInventoryCodeBuilder AdminUpdateUserInventoriesByInventoryCodeOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateUserInventoriesByInventoryCode.AdminUpdateUserInventoriesByInventoryCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminPurchasable.AdminPurchasableBuilder AdminPurchasableOp
        {
            get
            {
                var opBuilder = new Operation.AdminPurchasable.AdminPurchasableBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ApimodelsListInventoryResp? AdminListInventories(AdminListInventories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListInventoryResp?> AdminListInventoriesAsync(AdminListInventories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryResp? AdminCreateInventory(AdminCreateInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryResp?> AdminCreateInventoryAsync(AdminCreateInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryResp? AdminGetInventory(AdminGetInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryResp?> AdminGetInventoryAsync(AdminGetInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsInventoryResp? AdminUpdateInventory(AdminUpdateInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsInventoryResp?> AdminUpdateInventoryAsync(AdminUpdateInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteInventory(DeleteInventory input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteInventoryAsync(DeleteInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsInventoryResp>? AdminUpdateUserInventoriesByInventoryCode(AdminUpdateUserInventoriesByInventoryCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsInventoryResp>?> AdminUpdateUserInventoriesByInventoryCodeAsync(AdminUpdateUserInventoriesByInventoryCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPurchasable(AdminPurchasable input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminPurchasableAsync(AdminPurchasable input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}