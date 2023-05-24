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
    /// queryUncategorizedItems
    ///
    /// This API is used to query uncategorized items within a store.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of uncategorized items
    /// </summary>
    public class QueryUncategorizedItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUncategorizedItemsBuilder Builder { get => new QueryUncategorizedItemsBuilder(); }

        public class QueryUncategorizedItemsBuilder
            : OperationBuilder<QueryUncategorizedItemsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public List<QueryUncategorizedItemsSortBy>? SortBy { get; set; }

            public string? StoreId { get; set; }





            internal QueryUncategorizedItemsBuilder() { }

            internal QueryUncategorizedItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUncategorizedItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetSortBy(List<QueryUncategorizedItemsSortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryUncategorizedItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public QueryUncategorizedItems Build(
                string namespace_
            )
            {
                QueryUncategorizedItems op = new QueryUncategorizedItems(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.FullItemPagingSlicedResult? Execute(
                string namespace_
            )
            {
                QueryUncategorizedItems op = Build(
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

        private QueryUncategorizedItems(QueryUncategorizedItemsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUncategorizedItems(
            string namespace_,
            bool? activeOnly,
            int? limit,
            int? offset,
            List<QueryUncategorizedItemsSortBy>? sortBy,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (storeId is not null) QueryParams["storeId"] = storeId;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/uncategorized";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.FullItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemPagingSlicedResult>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryUncategorizedItemsSortBy : StringEnum<QueryUncategorizedItemsSortBy>
    {
        public static readonly QueryUncategorizedItemsSortBy Name
            = new QueryUncategorizedItemsSortBy("name");

        public static readonly QueryUncategorizedItemsSortBy Nameasc
            = new QueryUncategorizedItemsSortBy("name:asc");

        public static readonly QueryUncategorizedItemsSortBy Namedesc
            = new QueryUncategorizedItemsSortBy("name:desc");

        public static readonly QueryUncategorizedItemsSortBy CreatedAt
            = new QueryUncategorizedItemsSortBy("createdAt");

        public static readonly QueryUncategorizedItemsSortBy CreatedAtasc
            = new QueryUncategorizedItemsSortBy("createdAt:asc");

        public static readonly QueryUncategorizedItemsSortBy CreatedAtdesc
            = new QueryUncategorizedItemsSortBy("createdAt:desc");

        public static readonly QueryUncategorizedItemsSortBy UpdatedAt
            = new QueryUncategorizedItemsSortBy("updatedAt");

        public static readonly QueryUncategorizedItemsSortBy UpdatedAtasc
            = new QueryUncategorizedItemsSortBy("updatedAt:asc");

        public static readonly QueryUncategorizedItemsSortBy UpdatedAtdesc
            = new QueryUncategorizedItemsSortBy("updatedAt:desc");

        public static readonly QueryUncategorizedItemsSortBy DisplayOrder
            = new QueryUncategorizedItemsSortBy("displayOrder");

        public static readonly QueryUncategorizedItemsSortBy DisplayOrderasc
            = new QueryUncategorizedItemsSortBy("displayOrder:asc");

        public static readonly QueryUncategorizedItemsSortBy DisplayOrderdesc
            = new QueryUncategorizedItemsSortBy("displayOrder:desc");


        public static implicit operator QueryUncategorizedItemsSortBy(string value)
        {
            return NewValue(value);
        }

        public QueryUncategorizedItemsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}