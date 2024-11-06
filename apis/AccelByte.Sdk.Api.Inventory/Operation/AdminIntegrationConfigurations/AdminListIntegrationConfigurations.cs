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
    /// AdminListIntegrationConfigurations
    ///
    /// 
    /// Listing all integration configurations in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:INTEGRATIONCONFIGURATION [READ]
    /// </summary>
    public class AdminListIntegrationConfigurations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListIntegrationConfigurationsBuilder Builder { get => new AdminListIntegrationConfigurationsBuilder(); }

        public class AdminListIntegrationConfigurationsBuilder
            : OperationBuilder<AdminListIntegrationConfigurationsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListIntegrationConfigurationsSortBy? SortBy { get; set; }





            internal AdminListIntegrationConfigurationsBuilder() { }

            internal AdminListIntegrationConfigurationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListIntegrationConfigurationsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListIntegrationConfigurationsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListIntegrationConfigurationsBuilder SetSortBy(AdminListIntegrationConfigurationsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListIntegrationConfigurations Build(
                string namespace_
            )
            {
                AdminListIntegrationConfigurations op = new AdminListIntegrationConfigurations(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminListIntegrationConfigurationsBuilder>(this);
                return op;
            }

            public AdminListIntegrationConfigurations.Response Execute(
                string namespace_
            )
            {
                AdminListIntegrationConfigurations op = Build(
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
            public async Task<AdminListIntegrationConfigurations.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminListIntegrationConfigurations op = Build(
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

        private AdminListIntegrationConfigurations(AdminListIntegrationConfigurationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsListIntegrationConfigurationsResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminIntegrationConfigurations::AdminListIntegrationConfigurations";
        }

        #endregion

        public AdminListIntegrationConfigurations(
            string namespace_,            
            long? limit,            
            long? offset,            
            AdminListIntegrationConfigurationsSortBy? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListIntegrationConfigurations.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListIntegrationConfigurations.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsListIntegrationConfigurationsResp>(payload, ResponseJsonOptions);
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

    public class AdminListIntegrationConfigurationsSortBy : StringEnum<AdminListIntegrationConfigurationsSortBy>
    {
        public static readonly AdminListIntegrationConfigurationsSortBy CreatedAt
            = new AdminListIntegrationConfigurationsSortBy("createdAt");

        public static readonly AdminListIntegrationConfigurationsSortBy CreatedAtasc
            = new AdminListIntegrationConfigurationsSortBy("createdAt:asc");

        public static readonly AdminListIntegrationConfigurationsSortBy CreatedAtdesc
            = new AdminListIntegrationConfigurationsSortBy("createdAt:desc");


        public static implicit operator AdminListIntegrationConfigurationsSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListIntegrationConfigurationsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}