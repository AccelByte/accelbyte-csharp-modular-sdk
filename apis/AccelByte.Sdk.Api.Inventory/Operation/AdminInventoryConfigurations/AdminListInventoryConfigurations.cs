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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminListInventoryConfigurations
    ///
    /// 
    /// Listing all inventory configurations in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:CONFIGURATION [READ]
    /// </summary>
    public class AdminListInventoryConfigurations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListInventoryConfigurationsBuilder Builder { get => new AdminListInventoryConfigurationsBuilder(); }

        public class AdminListInventoryConfigurationsBuilder
            : OperationBuilder<AdminListInventoryConfigurationsBuilder>
        {

            public string? Code { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListInventoryConfigurationsSortBy? SortBy { get; set; }





            internal AdminListInventoryConfigurationsBuilder() { }

            internal AdminListInventoryConfigurationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListInventoryConfigurationsBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListInventoryConfigurationsBuilder SetSortBy(AdminListInventoryConfigurationsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListInventoryConfigurations Build(
                string namespace_
            )
            {
                AdminListInventoryConfigurations op = new AdminListInventoryConfigurations(this,
                    namespace_
                );

                op.SetBaseFields<AdminListInventoryConfigurationsBuilder>(this);
                return op;
            }

            public AdminListInventoryConfigurations.Response Execute(
                string namespace_
            )
            {
                AdminListInventoryConfigurations op = Build(
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
            public async Task<AdminListInventoryConfigurations.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminListInventoryConfigurations op = Build(
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

        private AdminListInventoryConfigurations(AdminListInventoryConfigurationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsListInventoryConfigurationsResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminInventoryConfigurations::AdminListInventoryConfigurations";
        }

        #endregion

        public AdminListInventoryConfigurations(
            string namespace_,
            string? code,
            long? limit,
            long? offset,
            AdminListInventoryConfigurationsSortBy? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminListInventoryConfigurations.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListInventoryConfigurations.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsListInventoryConfigurationsResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ApimodelsErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class AdminListInventoryConfigurationsSortBy : StringEnum<AdminListInventoryConfigurationsSortBy>
    {
        public static readonly AdminListInventoryConfigurationsSortBy Code
            = new AdminListInventoryConfigurationsSortBy("code");

        public static readonly AdminListInventoryConfigurationsSortBy Codeasc
            = new AdminListInventoryConfigurationsSortBy("code:asc");

        public static readonly AdminListInventoryConfigurationsSortBy Codedesc
            = new AdminListInventoryConfigurationsSortBy("code:desc");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAt
            = new AdminListInventoryConfigurationsSortBy("createdAt");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAtasc
            = new AdminListInventoryConfigurationsSortBy("createdAt:asc");

        public static readonly AdminListInventoryConfigurationsSortBy CreatedAtdesc
            = new AdminListInventoryConfigurationsSortBy("createdAt:desc");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAt
            = new AdminListInventoryConfigurationsSortBy("updatedAt");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAtasc
            = new AdminListInventoryConfigurationsSortBy("updatedAt:asc");

        public static readonly AdminListInventoryConfigurationsSortBy UpdatedAtdesc
            = new AdminListInventoryConfigurationsSortBy("updatedAt:desc");


        public static implicit operator AdminListInventoryConfigurationsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListInventoryConfigurationsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}