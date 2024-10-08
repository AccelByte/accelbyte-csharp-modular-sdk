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
    public class AdminItems
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public AdminItems(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public AdminItems(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminListItems.AdminListItemsBuilder AdminListItemsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListItems.AdminListItemsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetInventoryItem.AdminGetInventoryItemBuilder AdminGetInventoryItemOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetInventoryItem.AdminGetInventoryItemBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminConsumeUserItem.AdminConsumeUserItemBuilder AdminConsumeUserItemOp
        {
            get
            {
                var opBuilder = new Operation.AdminConsumeUserItem.AdminConsumeUserItemBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder AdminBulkUpdateMyItemsOp
        {
            get
            {
                var opBuilder = new Operation.AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder AdminSaveItemToInventoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder AdminBulkRemoveItemsOp
        {
            get
            {
                var opBuilder = new Operation.AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkSaveItemToInventory.AdminBulkSaveItemToInventoryBuilder AdminBulkSaveItemToInventoryOp
        {
            get
            {
                var opBuilder = new Operation.AdminBulkSaveItemToInventory.AdminBulkSaveItemToInventoryBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSaveItem.AdminSaveItemBuilder AdminSaveItemOp
        {
            get
            {
                var opBuilder = new Operation.AdminSaveItem.AdminSaveItemBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminBulkSaveItem.AdminBulkSaveItemBuilder AdminBulkSaveItemOp
        {
            get
            {
                var opBuilder = new Operation.AdminBulkSaveItem.AdminBulkSaveItemBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminSyncUserEntitlements.AdminSyncUserEntitlementsBuilder AdminSyncUserEntitlementsOp
        {
            get
            {
                var opBuilder = new Operation.AdminSyncUserEntitlements.AdminSyncUserEntitlementsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ApimodelsListItemResp? AdminListItems(AdminListItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsListItemResp?> AdminListItemsAsync(AdminListItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminGetInventoryItem(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminGetInventoryItemAsync(AdminGetInventoryItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? AdminGetInventoryItem<T1, T2, T3>(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2, T3>?> AdminGetInventoryItemAsync<T1, T2, T3>(AdminGetInventoryItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminConsumeUserItem(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminConsumeUserItemAsync(AdminConsumeUserItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? AdminConsumeUserItem<T1, T2, T3>(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2, T3>?> AdminConsumeUserItemAsync<T1, T2, T3>(AdminConsumeUserItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? AdminBulkUpdateMyItems(AdminBulkUpdateMyItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsUpdateItemResp>?> AdminBulkUpdateMyItemsAsync(AdminBulkUpdateMyItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminSaveItemToInventory(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminSaveItemToInventoryAsync(AdminSaveItemToInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? AdminSaveItemToInventory<T1, T2, T3>(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2, T3>?> AdminSaveItemToInventoryAsync<T1, T2, T3>(AdminSaveItemToInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsUpdateItemResp>? AdminBulkRemoveItems(AdminBulkRemoveItems input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsUpdateItemResp>?> AdminBulkRemoveItemsAsync(AdminBulkRemoveItems input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsBulkSaveItemResp>? AdminBulkSaveItemToInventory(AdminBulkSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsBulkSaveItemResp>?> AdminBulkSaveItemToInventoryAsync(AdminBulkSaveItemToInventory input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ApimodelsItemResp? AdminSaveItem(AdminSaveItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp?> AdminSaveItemAsync(AdminSaveItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ApimodelsItemResp<T1, T2, T3>? AdminSaveItem<T1, T2, T3>(AdminSaveItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ApimodelsItemResp<T1, T2, T3>?> AdminSaveItemAsync<T1, T2, T3>(AdminSaveItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ApimodelsBulkSaveItemResp>? AdminBulkSaveItem(AdminBulkSaveItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ApimodelsBulkSaveItemResp>?> AdminBulkSaveItemAsync(AdminBulkSaveItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSyncUserEntitlements(AdminSyncUserEntitlements input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminSyncUserEntitlementsAsync(AdminSyncUserEntitlements input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}