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
    /// AdminListItems
    ///
    /// 
    /// Listing all items in an inventory.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY:ITEM [READ]
    /// </summary>
    public class AdminListItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListItemsBuilder Builder { get => new AdminListItemsBuilder(); }

        public class AdminListItemsBuilder
            : OperationBuilder<AdminListItemsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? QtyGte { get; set; }

            public AdminListItemsSortBy? SortBy { get; set; }

            public string? SourceItemId { get; set; }

            public string? Tags { get; set; }





            internal AdminListItemsBuilder() { }

            internal AdminListItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListItemsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListItemsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListItemsBuilder SetQtyGte(long _qtyGte)
            {
                QtyGte = _qtyGte;
                return this;
            }

            public AdminListItemsBuilder SetSortBy(AdminListItemsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListItemsBuilder SetSourceItemId(string _sourceItemId)
            {
                SourceItemId = _sourceItemId;
                return this;
            }

            public AdminListItemsBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListItems Build(
                string inventoryId,
                string namespace_
            )
            {
                AdminListItems op = new AdminListItems(this,
                    inventoryId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsListItemResp? Execute(
                string inventoryId,
                string namespace_
            )
            {
                AdminListItems op = Build(
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

        private AdminListItems(AdminListItemsBuilder builder,
            string inventoryId,
            string namespace_
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.QtyGte != null) QueryParams["qtyGte"] = Convert.ToString(builder.QtyGte)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.SourceItemId is not null) QueryParams["sourceItemId"] = builder.SourceItemId;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListItems(
            string inventoryId,
            string namespace_,
            long? limit,
            long? offset,
            long? qtyGte,
            AdminListItemsSortBy? sortBy,
            string? sourceItemId,
            string? tags
        )
        {
            PathParams["inventoryId"] = inventoryId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (qtyGte != null) QueryParams["qtyGte"] = Convert.ToString(qtyGte)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (sourceItemId is not null) QueryParams["sourceItemId"] = sourceItemId;
            if (tags is not null) QueryParams["tags"] = tags;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}/items";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsListItemResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListItemResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListItemResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListItemsSortBy : StringEnum<AdminListItemsSortBy>
    {
        public static readonly AdminListItemsSortBy CreatedAt
            = new AdminListItemsSortBy("createdAt");

        public static readonly AdminListItemsSortBy CreatedAtasc
            = new AdminListItemsSortBy("createdAt:asc");

        public static readonly AdminListItemsSortBy CreatedAtdesc
            = new AdminListItemsSortBy("createdAt:desc");

        public static readonly AdminListItemsSortBy Qty
            = new AdminListItemsSortBy("qty");

        public static readonly AdminListItemsSortBy Qtyasc
            = new AdminListItemsSortBy("qty:asc");

        public static readonly AdminListItemsSortBy Qtydesc
            = new AdminListItemsSortBy("qty:desc");

        public static readonly AdminListItemsSortBy UpdatedAt
            = new AdminListItemsSortBy("updatedAt");

        public static readonly AdminListItemsSortBy UpdatedAtasc
            = new AdminListItemsSortBy("updatedAt:asc");

        public static readonly AdminListItemsSortBy UpdatedAtdesc
            = new AdminListItemsSortBy("updatedAt:desc");


        public static implicit operator AdminListItemsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListItemsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}