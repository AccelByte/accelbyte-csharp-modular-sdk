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
    /// AdminListInventories
    ///
    /// 
    /// Listing all inventories in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:USER:{userId}:INVENTORY [READ]
    /// </summary>
    public class AdminListInventories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListInventoriesBuilder Builder { get => new AdminListInventoriesBuilder(); }

        public class AdminListInventoriesBuilder
            : OperationBuilder<AdminListInventoriesBuilder>
        {

            public string? InventoryConfigurationCode { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListInventoriesSortBy? SortBy { get; set; }

            public string? UserId { get; set; }





            internal AdminListInventoriesBuilder() { }

            internal AdminListInventoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListInventoriesBuilder SetInventoryConfigurationCode(string _inventoryConfigurationCode)
            {
                InventoryConfigurationCode = _inventoryConfigurationCode;
                return this;
            }

            public AdminListInventoriesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListInventoriesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListInventoriesBuilder SetSortBy(AdminListInventoriesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListInventoriesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminListInventories Build(
                string namespace_
            )
            {
                AdminListInventories op = new AdminListInventories(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsListInventoryResp? Execute(
                string namespace_
            )
            {
                AdminListInventories op = Build(
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

        private AdminListInventories(AdminListInventoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.InventoryConfigurationCode is not null) QueryParams["inventoryConfigurationCode"] = builder.InventoryConfigurationCode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListInventories(
            string namespace_,
            string? inventoryConfigurationCode,
            long? limit,
            long? offset,
            AdminListInventoriesSortBy? sortBy,
            string? userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (inventoryConfigurationCode is not null) QueryParams["inventoryConfigurationCode"] = inventoryConfigurationCode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsListInventoryResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListInventoryResp>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsListInventoryResp>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminListInventoriesSortBy : StringEnum<AdminListInventoriesSortBy>
    {
        public static readonly AdminListInventoriesSortBy CreatedAt
            = new AdminListInventoriesSortBy("createdAt");

        public static readonly AdminListInventoriesSortBy CreatedAtasc
            = new AdminListInventoriesSortBy("createdAt:asc");

        public static readonly AdminListInventoriesSortBy CreatedAtdesc
            = new AdminListInventoriesSortBy("createdAt:desc");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCode
            = new AdminListInventoriesSortBy("inventoryConfigurationCode");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCodeasc
            = new AdminListInventoriesSortBy("inventoryConfigurationCode:asc");

        public static readonly AdminListInventoriesSortBy InventoryConfigurationCodedesc
            = new AdminListInventoriesSortBy("inventoryConfigurationCode:desc");

        public static readonly AdminListInventoriesSortBy UpdatedAt
            = new AdminListInventoriesSortBy("updatedAt");

        public static readonly AdminListInventoriesSortBy UpdatedAtasc
            = new AdminListInventoriesSortBy("updatedAt:asc");

        public static readonly AdminListInventoriesSortBy UpdatedAtdesc
            = new AdminListInventoriesSortBy("updatedAt:desc");


        public static implicit operator AdminListInventoriesSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListInventoriesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}