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
    /// AdminBulkUpdateMyItems
    ///
    /// 
    /// Bulk Updating user's own items.
    /// Tags will be auto-created.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [UPDATE]
    /// </summary>
    public class AdminBulkUpdateMyItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkUpdateMyItemsBuilder Builder { get => new AdminBulkUpdateMyItemsBuilder(); }

        public class AdminBulkUpdateMyItemsBuilder
            : OperationBuilder<AdminBulkUpdateMyItemsBuilder>
        {





            internal AdminBulkUpdateMyItemsBuilder() { }

            internal AdminBulkUpdateMyItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkUpdateMyItems Build(
                List<ApimodelsAdminUpdateItemReq> body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminBulkUpdateMyItems op = new AdminBulkUpdateMyItems(this,
                    body,
                    inventoryId,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminBulkUpdateMyItemsBuilder>(this);
                return op;
            }

            public List<Model.ApimodelsUpdateItemResp>? Execute(
                List<ApimodelsAdminUpdateItemReq> body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminBulkUpdateMyItems op = Build(
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
        }

        private AdminBulkUpdateMyItems(AdminBulkUpdateMyItemsBuilder builder,
            List<ApimodelsAdminUpdateItemReq> body,
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

        public AdminBulkUpdateMyItems(
            string inventoryId,
            string namespace_,
            string userId,
            List<Model.ApimodelsAdminUpdateItemReq> body
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ApimodelsUpdateItemResp>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsUpdateItemResp>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsUpdateItemResp>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}