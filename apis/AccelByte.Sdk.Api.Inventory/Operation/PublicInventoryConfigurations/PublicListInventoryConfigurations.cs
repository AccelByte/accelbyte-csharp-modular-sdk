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
    /// PublicListInventoryConfigurations
    ///
    /// 
    /// Listing all inventory configurations in a namespace.
    /// The response body will be in the form of standard pagination.
    /// </summary>
    public class PublicListInventoryConfigurations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListInventoryConfigurationsBuilder Builder { get => new PublicListInventoryConfigurationsBuilder(); }

        public class PublicListInventoryConfigurationsBuilder
            : OperationBuilder<PublicListInventoryConfigurationsBuilder>
        {

            public string? Code { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public PublicListInventoryConfigurationsSortBy? SortBy { get; set; }





            internal PublicListInventoryConfigurationsBuilder() { }

            internal PublicListInventoryConfigurationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListInventoryConfigurationsBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public PublicListInventoryConfigurationsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListInventoryConfigurationsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListInventoryConfigurationsBuilder SetSortBy(PublicListInventoryConfigurationsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListInventoryConfigurations Build(
                string namespace_
            )
            {
                PublicListInventoryConfigurations op = new PublicListInventoryConfigurations(this,
                    namespace_                    
                );

                op.SetBaseFields<PublicListInventoryConfigurationsBuilder>(this);
                return op;
            }

            public PublicListInventoryConfigurations.Response Execute(
                string namespace_
            )
            {
                PublicListInventoryConfigurations op = Build(
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
            public async Task<PublicListInventoryConfigurations.Response> ExecuteAsync(
                string namespace_
            )
            {
                PublicListInventoryConfigurations op = Build(
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

        private PublicListInventoryConfigurations(PublicListInventoryConfigurationsBuilder builder,
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


            protected override string GetFullOperationId() => "Inventory::PublicInventoryConfigurations::PublicListInventoryConfigurations";
        }

        #endregion

        public PublicListInventoryConfigurations(
            string namespace_,            
            string? code,            
            long? limit,            
            long? offset,            
            PublicListInventoryConfigurationsSortBy? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (code is not null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/public/namespaces/{namespace}/inventoryConfigurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicListInventoryConfigurations.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicListInventoryConfigurations.Response()
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

    public class PublicListInventoryConfigurationsSortBy : StringEnum<PublicListInventoryConfigurationsSortBy>
    {
        public static readonly PublicListInventoryConfigurationsSortBy Code
            = new PublicListInventoryConfigurationsSortBy("code");

        public static readonly PublicListInventoryConfigurationsSortBy Codeasc
            = new PublicListInventoryConfigurationsSortBy("code:asc");

        public static readonly PublicListInventoryConfigurationsSortBy Codedesc
            = new PublicListInventoryConfigurationsSortBy("code:desc");

        public static readonly PublicListInventoryConfigurationsSortBy CreatedAt
            = new PublicListInventoryConfigurationsSortBy("createdAt");

        public static readonly PublicListInventoryConfigurationsSortBy CreatedAtasc
            = new PublicListInventoryConfigurationsSortBy("createdAt:asc");

        public static readonly PublicListInventoryConfigurationsSortBy CreatedAtdesc
            = new PublicListInventoryConfigurationsSortBy("createdAt:desc");

        public static readonly PublicListInventoryConfigurationsSortBy UpdatedAt
            = new PublicListInventoryConfigurationsSortBy("updatedAt");

        public static readonly PublicListInventoryConfigurationsSortBy UpdatedAtasc
            = new PublicListInventoryConfigurationsSortBy("updatedAt:asc");

        public static readonly PublicListInventoryConfigurationsSortBy UpdatedAtdesc
            = new PublicListInventoryConfigurationsSortBy("updatedAt:desc");


        public static implicit operator PublicListInventoryConfigurationsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicListInventoryConfigurationsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}