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
    /// searchItems
    ///
    /// This API is used to search items by keyword in title, description and long description within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of items
    /// </summary>
    public class SearchItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchItemsBuilder Builder { get => new SearchItemsBuilder(); }

        public class SearchItemsBuilder
            : OperationBuilder<SearchItemsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public SearchItemsItemType? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? StoreId { get; set; }





            internal SearchItemsBuilder() { }

            internal SearchItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SearchItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public SearchItemsBuilder SetItemType(SearchItemsItemType _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public SearchItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public SearchItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public SearchItemsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public SearchItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public SearchItems Build(
                string namespace_,
                string keyword,
                string language
            )
            {
                SearchItems op = new SearchItems(this,
                    namespace_,                    
                    keyword,                    
                    language                    
                );

                op.SetBaseFields<SearchItemsBuilder>(this);
                return op;
            }

            public SearchItems.Response Execute(
                string namespace_,
                string keyword,
                string language
            )
            {
                SearchItems op = Build(
                    namespace_,
                    keyword,
                    language
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<SearchItems.Response> ExecuteAsync(
                string namespace_,
                string keyword,
                string language
            )
            {
                SearchItems op = Build(
                    namespace_,
                    keyword,
                    language
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private SearchItems(SearchItemsBuilder builder,
            string namespace_,
            string keyword,
            string language
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType.Value;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (language is not null) QueryParams["language"] = language;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FullItemPagingSlicedResult>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::SearchItems";
        }

        #endregion

        public SearchItems(
            string namespace_,            
            bool? activeOnly,            
            SearchItemsItemType? itemType,            
            int? limit,            
            int? offset,            
            string? sortBy,            
            string? storeId,            
            string keyword,            
            string language            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (itemType is not null) QueryParams["itemType"] = itemType.Value;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (language is not null) QueryParams["language"] = language;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public SearchItems.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SearchItems.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

    public class SearchItemsItemType : StringEnum<SearchItemsItemType>
    {
        public static readonly SearchItemsItemType APP
            = new SearchItemsItemType("APP");

        public static readonly SearchItemsItemType BUNDLE
            = new SearchItemsItemType("BUNDLE");

        public static readonly SearchItemsItemType CODE
            = new SearchItemsItemType("CODE");

        public static readonly SearchItemsItemType COINS
            = new SearchItemsItemType("COINS");

        public static readonly SearchItemsItemType EXTENSION
            = new SearchItemsItemType("EXTENSION");

        public static readonly SearchItemsItemType INGAMEITEM
            = new SearchItemsItemType("INGAMEITEM");

        public static readonly SearchItemsItemType LOOTBOX
            = new SearchItemsItemType("LOOTBOX");

        public static readonly SearchItemsItemType MEDIA
            = new SearchItemsItemType("MEDIA");

        public static readonly SearchItemsItemType OPTIONBOX
            = new SearchItemsItemType("OPTIONBOX");

        public static readonly SearchItemsItemType SEASON
            = new SearchItemsItemType("SEASON");

        public static readonly SearchItemsItemType SUBSCRIPTION
            = new SearchItemsItemType("SUBSCRIPTION");


        public static implicit operator SearchItemsItemType(string value)
        {
            return NewValue(value);
        }

        public SearchItemsItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

}