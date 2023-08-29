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
    /// AdminBulkRemoveItems
    ///
    /// 
    /// Bulk remove user's own items'.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [DELETE]
    /// </summary>
    public class AdminBulkRemoveItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkRemoveItemsBuilder Builder { get => new AdminBulkRemoveItemsBuilder(); }

        public class AdminBulkRemoveItemsBuilder
            : OperationBuilder<AdminBulkRemoveItemsBuilder>
        {





            internal AdminBulkRemoveItemsBuilder() { }

            internal AdminBulkRemoveItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkRemoveItems Build(
                ApimodelsBulkRemoveItemsReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminBulkRemoveItems op = new AdminBulkRemoveItems(this,
                    body,                    
                    inventoryId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ApimodelsUpdateItemResp>? Execute(
                ApimodelsBulkRemoveItemsReq body,
                string inventoryId,
                string namespace_,
                string userId
            )
            {
                AdminBulkRemoveItems op = Build(
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

        private AdminBulkRemoveItems(AdminBulkRemoveItemsBuilder builder,
            ApimodelsBulkRemoveItemsReq body,
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

        public AdminBulkRemoveItems(
            string inventoryId,            
            string namespace_,            
            string userId,            
            Model.ApimodelsBulkRemoveItemsReq body            
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items";

        public override HttpMethod Method => HttpMethod.Delete;

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