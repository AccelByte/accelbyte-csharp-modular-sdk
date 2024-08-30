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
    /// queryItemsV2
    ///
    /// This API is used to query items by criteria within a store.
    /// 
    /// The behaviour for itemStatus query parameter:
    /// * TRUE: Show only ACTIVE items
    /// * FALSE: Show only INACTIVE items
    /// * Not provided: show both ACTIVE and INACTIVE items
    /// Other detail info:
    /// 
    ///   * Returns : the list of items
    /// </summary>
    public class QueryItemsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryItemsV2Builder Builder { get => new QueryItemsV2Builder(); }

        public class QueryItemsV2Builder
            : OperationBuilder<QueryItemsV2Builder>
        {

            public QueryItemsV2AppType? AppType { get; set; }

            public string? AvailableDate { get; set; }

            public string? BaseAppId { get; set; }

            public string? CategoryPath { get; set; }

            public string? Features { get; set; }

            public bool? IncludeSubCategoryItem { get; set; }

            public string? ItemName { get; set; }

            public QueryItemsV2ItemStatus? ItemStatus { get; set; }

            public List<QueryItemsV2ItemType>? ItemType { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? Region { get; set; }

            public bool? SectionExclusive { get; set; }

            public List<QueryItemsV2SortBy>? SortBy { get; set; }

            public string? StoreId { get; set; }

            public string? Tags { get; set; }

            public string? TargetNamespace { get; set; }

            public bool? WithTotal { get; set; }





            internal QueryItemsV2Builder() { }

            internal QueryItemsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryItemsV2Builder SetAppType(QueryItemsV2AppType _appType)
            {
                AppType = _appType;
                return this;
            }

            public QueryItemsV2Builder SetAvailableDate(string _availableDate)
            {
                AvailableDate = _availableDate;
                return this;
            }

            public QueryItemsV2Builder SetBaseAppId(string _baseAppId)
            {
                BaseAppId = _baseAppId;
                return this;
            }

            public QueryItemsV2Builder SetCategoryPath(string _categoryPath)
            {
                CategoryPath = _categoryPath;
                return this;
            }

            public QueryItemsV2Builder SetFeatures(string _features)
            {
                Features = _features;
                return this;
            }

            public QueryItemsV2Builder SetIncludeSubCategoryItem(bool _includeSubCategoryItem)
            {
                IncludeSubCategoryItem = _includeSubCategoryItem;
                return this;
            }

            public QueryItemsV2Builder SetItemName(string _itemName)
            {
                ItemName = _itemName;
                return this;
            }

            public QueryItemsV2Builder SetItemStatus(QueryItemsV2ItemStatus _itemStatus)
            {
                ItemStatus = _itemStatus;
                return this;
            }

            public QueryItemsV2Builder SetItemType(List<QueryItemsV2ItemType> _itemType)
            {
                ItemType = _itemType;
                return this;
            }

            public QueryItemsV2Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryItemsV2Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryItemsV2Builder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public QueryItemsV2Builder SetSectionExclusive(bool _sectionExclusive)
            {
                SectionExclusive = _sectionExclusive;
                return this;
            }

            public QueryItemsV2Builder SetSortBy(List<QueryItemsV2SortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryItemsV2Builder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }

            public QueryItemsV2Builder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }

            public QueryItemsV2Builder SetTargetNamespace(string _targetNamespace)
            {
                TargetNamespace = _targetNamespace;
                return this;
            }

            public QueryItemsV2Builder SetWithTotal(bool _withTotal)
            {
                WithTotal = _withTotal;
                return this;
            }





            public QueryItemsV2 Build(
                string namespace_
            )
            {
                QueryItemsV2 op = new QueryItemsV2(this,
                    namespace_                    
                );

                op.SetBaseFields<QueryItemsV2Builder>(this);
                return op;
            }

            public Model.FullItemPagingResult? Execute(
                string namespace_
            )
            {
                QueryItemsV2 op = Build(
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
            public async Task<Model.FullItemPagingResult?> ExecuteAsync(
                string namespace_
            )
            {
                QueryItemsV2 op = Build(
                    namespace_
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

        private QueryItemsV2(QueryItemsV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.AppType is not null) QueryParams["appType"] = builder.AppType.Value;
            if (builder.AvailableDate is not null) QueryParams["availableDate"] = builder.AvailableDate;
            if (builder.BaseAppId is not null) QueryParams["baseAppId"] = builder.BaseAppId;
            if (builder.CategoryPath is not null) QueryParams["categoryPath"] = builder.CategoryPath;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            if (builder.IncludeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(builder.IncludeSubCategoryItem)!;
            if (builder.ItemName is not null) QueryParams["itemName"] = builder.ItemName;
            if (builder.ItemStatus is not null) QueryParams["itemStatus"] = builder.ItemStatus.Value;
            if (builder.ItemType is not null) QueryParams["itemType"] = builder.ItemType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.SectionExclusive != null) QueryParams["sectionExclusive"] = Convert.ToString(builder.SectionExclusive)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.TargetNamespace is not null) QueryParams["targetNamespace"] = builder.TargetNamespace;
            if (builder.WithTotal != null) QueryParams["withTotal"] = Convert.ToString(builder.WithTotal)!;
            

            
            CollectionFormatMap["itemType"] = "multi";
            CollectionFormatMap["sortBy"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryItemsV2(
            string namespace_,            
            QueryItemsV2AppType? appType,            
            string? availableDate,            
            string? baseAppId,            
            string? categoryPath,            
            string? features,            
            bool? includeSubCategoryItem,            
            string? itemName,            
            QueryItemsV2ItemStatus? itemStatus,            
            List<QueryItemsV2ItemType>? itemType,            
            int? limit,            
            int? offset,            
            string? region,            
            bool? sectionExclusive,            
            List<QueryItemsV2SortBy>? sortBy,            
            string? storeId,            
            string? tags,            
            string? targetNamespace,            
            bool? withTotal            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (appType is not null) QueryParams["appType"] = appType.Value;
            if (availableDate is not null) QueryParams["availableDate"] = availableDate;
            if (baseAppId is not null) QueryParams["baseAppId"] = baseAppId;
            if (categoryPath is not null) QueryParams["categoryPath"] = categoryPath;
            if (features is not null) QueryParams["features"] = features;
            if (includeSubCategoryItem != null) QueryParams["includeSubCategoryItem"] = Convert.ToString(includeSubCategoryItem)!;
            if (itemName is not null) QueryParams["itemName"] = itemName;
            if (itemStatus is not null) QueryParams["itemStatus"] = itemStatus.Value;
            if (itemType is not null) QueryParams["itemType"] = itemType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region is not null) QueryParams["region"] = region;
            if (sectionExclusive != null) QueryParams["sectionExclusive"] = Convert.ToString(sectionExclusive)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (tags is not null) QueryParams["tags"] = tags;
            if (targetNamespace is not null) QueryParams["targetNamespace"] = targetNamespace;
            if (withTotal != null) QueryParams["withTotal"] = Convert.ToString(withTotal)!;
            

            
            CollectionFormatMap["itemType"] = "multi";
            CollectionFormatMap["sortBy"] = "csv";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/items/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.FullItemPagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryItemsV2AppType : StringEnum<QueryItemsV2AppType>
    {
        public static readonly QueryItemsV2AppType DEMO
            = new QueryItemsV2AppType("DEMO");

        public static readonly QueryItemsV2AppType DLC
            = new QueryItemsV2AppType("DLC");

        public static readonly QueryItemsV2AppType GAME
            = new QueryItemsV2AppType("GAME");

        public static readonly QueryItemsV2AppType SOFTWARE
            = new QueryItemsV2AppType("SOFTWARE");


        public static implicit operator QueryItemsV2AppType(string value)
        {
            return NewValue(value);
        }

        public QueryItemsV2AppType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItemsV2ItemStatus : StringEnum<QueryItemsV2ItemStatus>
    {
        public static readonly QueryItemsV2ItemStatus ACTIVE
            = new QueryItemsV2ItemStatus("ACTIVE");

        public static readonly QueryItemsV2ItemStatus INACTIVE
            = new QueryItemsV2ItemStatus("INACTIVE");


        public static implicit operator QueryItemsV2ItemStatus(string value)
        {
            return NewValue(value);
        }

        public QueryItemsV2ItemStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItemsV2ItemType : StringEnum<QueryItemsV2ItemType>
    {
        public static readonly QueryItemsV2ItemType APP
            = new QueryItemsV2ItemType("APP");

        public static readonly QueryItemsV2ItemType BUNDLE
            = new QueryItemsV2ItemType("BUNDLE");

        public static readonly QueryItemsV2ItemType CODE
            = new QueryItemsV2ItemType("CODE");

        public static readonly QueryItemsV2ItemType COINS
            = new QueryItemsV2ItemType("COINS");

        public static readonly QueryItemsV2ItemType EXTENSION
            = new QueryItemsV2ItemType("EXTENSION");

        public static readonly QueryItemsV2ItemType INGAMEITEM
            = new QueryItemsV2ItemType("INGAMEITEM");

        public static readonly QueryItemsV2ItemType LOOTBOX
            = new QueryItemsV2ItemType("LOOTBOX");

        public static readonly QueryItemsV2ItemType MEDIA
            = new QueryItemsV2ItemType("MEDIA");

        public static readonly QueryItemsV2ItemType OPTIONBOX
            = new QueryItemsV2ItemType("OPTIONBOX");

        public static readonly QueryItemsV2ItemType SEASON
            = new QueryItemsV2ItemType("SEASON");

        public static readonly QueryItemsV2ItemType SUBSCRIPTION
            = new QueryItemsV2ItemType("SUBSCRIPTION");


        public static implicit operator QueryItemsV2ItemType(string value)
        {
            return NewValue(value);
        }

        public QueryItemsV2ItemType(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryItemsV2SortBy : StringEnum<QueryItemsV2SortBy>
    {
        public static readonly QueryItemsV2SortBy Name
            = new QueryItemsV2SortBy("name");

        public static readonly QueryItemsV2SortBy Nameasc
            = new QueryItemsV2SortBy("name:asc");

        public static readonly QueryItemsV2SortBy Namedesc
            = new QueryItemsV2SortBy("name:desc");

        public static readonly QueryItemsV2SortBy CreatedAt
            = new QueryItemsV2SortBy("createdAt");

        public static readonly QueryItemsV2SortBy CreatedAtasc
            = new QueryItemsV2SortBy("createdAt:asc");

        public static readonly QueryItemsV2SortBy CreatedAtdesc
            = new QueryItemsV2SortBy("createdAt:desc");

        public static readonly QueryItemsV2SortBy UpdatedAt
            = new QueryItemsV2SortBy("updatedAt");

        public static readonly QueryItemsV2SortBy UpdatedAtasc
            = new QueryItemsV2SortBy("updatedAt:asc");

        public static readonly QueryItemsV2SortBy UpdatedAtdesc
            = new QueryItemsV2SortBy("updatedAt:desc");

        public static readonly QueryItemsV2SortBy DisplayOrder
            = new QueryItemsV2SortBy("displayOrder");

        public static readonly QueryItemsV2SortBy DisplayOrderasc
            = new QueryItemsV2SortBy("displayOrder:asc");

        public static readonly QueryItemsV2SortBy DisplayOrderdesc
            = new QueryItemsV2SortBy("displayOrder:desc");


        public static implicit operator QueryItemsV2SortBy(string value)
        {
            return NewValue(value);
        }

        public QueryItemsV2SortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}