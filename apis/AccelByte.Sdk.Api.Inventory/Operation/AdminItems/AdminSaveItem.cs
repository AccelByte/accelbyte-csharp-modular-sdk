// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminSaveItem
    ///
    /// 
    /// Saving an item.
    /// The item will be saved in user's inventory,
    /// If it doesn't exist it'll be created.
    /// 
    /// If the item already exists, its qty will be increased,
    /// so no new item with same sourceItemId will be created
    /// 
    /// Tags will be auto-created.
    /// ItemType will be auto-created.
    /// 
    /// For Ecommerce item, this fields will be override by ecommerce configuration
    /// (slotUsed, serverCustomAttributes, customAttributes, type)
    /// 
    /// For Ecommerce items, the quantity saved is dynamically adjusted based on an item's useCount configured in Store.
    /// When saving items, the quantity specified for each item will be multiplied by the useCount.
    /// i.e. If the store item is configured with a useCount of 5
    /// and the quantity of a particular item is set to 2 during saving, it will be stored as 10.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [CREATE]
    /// </summary>
    public class AdminSaveItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSaveItemBuilder Builder { get => new AdminSaveItemBuilder(); }

        public class AdminSaveItemBuilder
            : OperationBuilder<AdminSaveItemBuilder>
        {





            internal AdminSaveItemBuilder() { }

            internal AdminSaveItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminSaveItem Build(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = new AdminSaveItem(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminSaveItemBuilder>(this);
                return op;
            }

            public Model.ApimodelsItemResp? Execute(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = Build(
                    body,
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
            public async Task<Model.ApimodelsItemResp?> ExecuteAsync(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsItemResp<T1, T2, T3>? Execute<T1, T2, T3>(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApimodelsItemResp<T1, T2, T3>?> ExecuteAsync<T1, T2, T3>(
                ApimodelsSaveItemReq body,
                string namespace_,
                string userId
            )
            {
                AdminSaveItem op = Build(
                    body,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2, T3>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminSaveItem(AdminSaveItemBuilder builder,
            ApimodelsSaveItemReq body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSaveItem(
            string namespace_,
            string userId,
            Model.ApimodelsSaveItemReq body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items";

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

        public Model.ApimodelsItemResp<T1, T2, T3>? ParseResponse<T1, T2, T3>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsItemResp<T1, T2, T3>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}