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
    public class AdminItems
    {
        private readonly IAccelByteSdk _sdk;

        public AdminItems(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListItems.AdminListItemsBuilder AdminListItemsOp
        {
            get { return new Operation.AdminListItems.AdminListItemsBuilder(_sdk); }
        }
        public AdminGetInventoryItem.AdminGetInventoryItemBuilder AdminGetInventoryItemOp
        {
            get { return new Operation.AdminGetInventoryItem.AdminGetInventoryItemBuilder(_sdk); }
        }
        public AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder AdminBulkUpdateMyItemsOp
        {
            get { return new Operation.AdminBulkUpdateMyItems.AdminBulkUpdateMyItemsBuilder(_sdk); }
        }
        public AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder AdminSaveItemToInventoryOp
        {
            get { return new Operation.AdminSaveItemToInventory.AdminSaveItemToInventoryBuilder(_sdk); }
        }
        public AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder AdminBulkRemoveItemsOp
        {
            get { return new Operation.AdminBulkRemoveItems.AdminBulkRemoveItemsBuilder(_sdk); }
        }
        public AdminConsumeUserItem.AdminConsumeUserItemBuilder AdminConsumeUserItemOp
        {
            get { return new Operation.AdminConsumeUserItem.AdminConsumeUserItemBuilder(_sdk); }
        }
        public AdminSaveItem.AdminSaveItemBuilder AdminSaveItemOp
        {
            get { return new Operation.AdminSaveItem.AdminSaveItemBuilder(_sdk); }
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
        public Model.ApimodelsItemResp? AdminGetInventoryItem(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ApimodelsItemResp<T1, T2>? AdminGetInventoryItem<T1, T2>(AdminGetInventoryItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
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
        public Model.ApimodelsItemResp? AdminSaveItemToInventory(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ApimodelsItemResp<T1, T2>? AdminSaveItemToInventory<T1, T2>(AdminSaveItemToInventory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
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
        public Model.ApimodelsItemResp? AdminConsumeUserItem(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        
        public Model.ApimodelsItemResp<T1, T2>? AdminConsumeUserItem<T1, T2>(AdminConsumeUserItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
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
        
        public Model.ApimodelsItemResp<T1, T2>? AdminSaveItem<T1, T2>(AdminSaveItem input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}