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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// bulkGetLocaleItems
    ///
    /// This API is used to bulk get locale items. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of items info
    /// </summary>
    public class BulkGetLocaleItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkGetLocaleItemsBuilder Builder { get => new BulkGetLocaleItemsBuilder(); }

        public class BulkGetLocaleItemsBuilder
            : OperationBuilder<BulkGetLocaleItemsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? Language { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal BulkGetLocaleItemsBuilder() { }

            internal BulkGetLocaleItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public BulkGetLocaleItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public BulkGetLocaleItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public BulkGetLocaleItems Build(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = new BulkGetLocaleItems(this,
                    namespace_,                    
                    itemIds                    
                );

                op.SetBaseFields<BulkGetLocaleItemsBuilder>(this);
                return op;
            }

            public List<Model.ItemInfo>? Execute(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ItemInfo>?> ExecuteAsync(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.ItemInfo<T1, T2>>? Execute<T1, T2>(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.ItemInfo<T1, T2>>?> ExecuteAsync<T1, T2>(
                string namespace_,
                string itemIds
            )
            {
                BulkGetLocaleItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private BulkGetLocaleItems(BulkGetLocaleItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkGetLocaleItems(
            string namespace_,            
            bool? activeOnly,            
            string? language,            
            string? region,            
            string? storeId,            
            string itemIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language is not null) QueryParams["language"] = language;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/locale/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ItemInfo<T1, T2>>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo<T1, T2>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo<T1, T2>>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}