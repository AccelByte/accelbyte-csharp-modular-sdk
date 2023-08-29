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
    /// PublicBulkRemoveMyItems
    ///
    /// 
    /// Bulk remove user's own items.
    /// </summary>
    public class PublicBulkRemoveMyItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkRemoveMyItemsBuilder Builder { get => new PublicBulkRemoveMyItemsBuilder(); }

        public class PublicBulkRemoveMyItemsBuilder
            : OperationBuilder<PublicBulkRemoveMyItemsBuilder>
        {





            internal PublicBulkRemoveMyItemsBuilder() { }

            internal PublicBulkRemoveMyItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicBulkRemoveMyItems Build(
                ApimodelsBulkRemoveItemsReq body,
                string inventoryId,
                string namespace_
            )
            {
                PublicBulkRemoveMyItems op = new PublicBulkRemoveMyItems(this,
                    body,                    
                    inventoryId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ApimodelsUpdateItemResp>? Execute(
                ApimodelsBulkRemoveItemsReq body,
                string inventoryId,
                string namespace_
            )
            {
                PublicBulkRemoveMyItems op = Build(
                    body,
                    inventoryId,
                    namespace_
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

        private PublicBulkRemoveMyItems(PublicBulkRemoveMyItemsBuilder builder,
            ApimodelsBulkRemoveItemsReq body,
            string inventoryId,
            string namespace_
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicBulkRemoveMyItems(
            string inventoryId,            
            string namespace_,            
            Model.ApimodelsBulkRemoveItemsReq body            
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items";

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