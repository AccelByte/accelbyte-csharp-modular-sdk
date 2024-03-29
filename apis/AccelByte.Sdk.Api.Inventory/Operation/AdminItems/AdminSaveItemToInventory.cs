// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminSaveItemToInventory
    ///
    /// 
    /// Saving an item to specific inventory.
    /// The item will be saved in specific user's inventory,
    /// 
    /// If the item already exists, its qty will be increased,
    /// so no new item with same sourceItemId will be created
    /// 
    /// Tags will be auto-created.
    /// ItemType will be auto-created.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]
    /// </summary>
    public class AdminSaveItemToInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSaveItemToInventoryBuilder Builder { get => new AdminSaveItemToInventoryBuilder(); }

        public class AdminSaveItemToInventoryBuilder
            : OperationBuilder<AdminSaveItemToInventoryBuilder>
        {





            internal AdminSaveItemToInventoryBuilder() { }

            internal AdminSaveItemToInventoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSaveItemToInventory Build(
                ApimodelsSaveItemToInventoryReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminSaveItemToInventory op = new AdminSaveItemToInventory(this,
                    body,
                    inventoryId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminSaveItemToInventoryBuilder>(this);
                return op;
            }

            public Model.ApimodelsItemResp? Execute(
                ApimodelsSaveItemToInventoryReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminSaveItemToInventory op = Build(
                    body,
                    inventoryId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsItemResp<T1, T2>? Execute<T1, T2>(
                ApimodelsSaveItemToInventoryReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminSaveItemToInventory op = Build(
                    body,
                    inventoryId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminSaveItemToInventory(AdminSaveItemToInventoryBuilder builder,
            ApimodelsSaveItemToInventoryReq body,
            string inventoryId,
            string namespace_,
            string userId
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSaveItemToInventory(
            string inventoryId,
            string namespace_,
            string userId,
            Model.ApimodelsSaveItemToInventoryReq body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsItemResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsItemResp<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}