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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// countOfPurchasedItem
    ///
    /// This API is used to get the count of purchased item which is the order target.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : Item purchased count
    /// </summary>
    public class CountOfPurchasedItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CountOfPurchasedItemBuilder Builder { get => new CountOfPurchasedItemBuilder(); }

        public class CountOfPurchasedItemBuilder
            : OperationBuilder<CountOfPurchasedItemBuilder>
        {





            internal CountOfPurchasedItemBuilder() { }

            internal CountOfPurchasedItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CountOfPurchasedItem Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                CountOfPurchasedItem op = new CountOfPurchasedItem(this,
                    namespace_,                    
                    userId,                    
                    itemId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.PurchasedItemCount? Execute(
                string namespace_,
                string userId,
                string itemId
            )
            {
                CountOfPurchasedItem op = Build(
                    namespace_,
                    userId,
                    itemId
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

        private CountOfPurchasedItem(CountOfPurchasedItemBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId is not null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CountOfPurchasedItem(
            string namespace_,            
            string userId,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId is not null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/countOfItem";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.PurchasedItemCount? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PurchasedItemCount>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PurchasedItemCount>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}