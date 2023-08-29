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
    /// publicGetItemBySku
    ///
    /// This API is used to get the item by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the item with sku
    /// </summary>
    public class PublicGetItemBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemBySkuBuilder Builder { get => new PublicGetItemBySkuBuilder(); }

        public class PublicGetItemBySkuBuilder
            : OperationBuilder<PublicGetItemBySkuBuilder>
        {

            public string? Language { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal PublicGetItemBySkuBuilder() { }

            internal PublicGetItemBySkuBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetItemBySkuBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetItemBySkuBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetItemBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetItemBySku Build(
                string namespace_,
                string sku
            )
            {
                PublicGetItemBySku op = new PublicGetItemBySku(this,
                    namespace_,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ItemInfo? Execute(
                string namespace_,
                string sku
            )
            {
                PublicGetItemBySku op = Build(
                    namespace_,
                    sku
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public Model.ItemInfo<T1, T2>? Execute<T1, T2>(
                string namespace_,
                string sku
            )
            {
                PublicGetItemBySku op = Build(
                    namespace_,
                    sku
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

        private PublicGetItemBySku(PublicGetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetItemBySku(
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language is not null) QueryParams["language"] = language;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (sku is not null) QueryParams["sku"] = sku;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public Model.ItemInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}