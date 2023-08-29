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
    /// AdminConsumeUserItem
    ///
    /// 
    /// Consume user's own item
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [UPDATE]
    /// </summary>
    public class AdminConsumeUserItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminConsumeUserItemBuilder Builder { get => new AdminConsumeUserItemBuilder(); }

        public class AdminConsumeUserItemBuilder
            : OperationBuilder<AdminConsumeUserItemBuilder>
        {





            internal AdminConsumeUserItemBuilder() { }

            internal AdminConsumeUserItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminConsumeUserItem Build(
                ApimodelsConsumeItemReq body,
                string inventoryId,
                string itemId,
                string namespace_,
                string userId
            )
            {
                AdminConsumeUserItem op = new AdminConsumeUserItem(this,
                    body,                    
                    inventoryId,                    
                    itemId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsItemResp? Execute(
                ApimodelsConsumeItemReq body,
                string inventoryId,
                string itemId,
                string namespace_,
                string userId
            )
            {
                AdminConsumeUserItem op = Build(
                    body,
                    inventoryId,
                    itemId,
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
                ApimodelsConsumeItemReq body,
                string inventoryId,
                string itemId,
                string namespace_,
                string userId
            )
            {
                AdminConsumeUserItem op = Build(
                    body,
                    inventoryId,
                    itemId,
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

        private AdminConsumeUserItem(AdminConsumeUserItemBuilder builder,
            ApimodelsConsumeItemReq body,
            string inventoryId,
            string itemId,
            string namespace_,
            string userId
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminConsumeUserItem(
            string inventoryId,            
            string itemId,            
            string namespace_,            
            string userId,            
            Model.ApimodelsConsumeItemReq body            
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items/{itemId}/consume";

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