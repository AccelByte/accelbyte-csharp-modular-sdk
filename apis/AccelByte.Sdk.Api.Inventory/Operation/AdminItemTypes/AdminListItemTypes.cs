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
    /// AdminListItemTypes
    ///
    /// 
    /// This endpoint will list all item types in a namespace.
    /// The response body will be in the form of standard pagination.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:ITEMTYPE [READ]
    /// </summary>
    public class AdminListItemTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListItemTypesBuilder Builder { get => new AdminListItemTypesBuilder(); }

        public class AdminListItemTypesBuilder
            : OperationBuilder<AdminListItemTypesBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminListItemTypesSortBy? SortBy { get; set; }





            internal AdminListItemTypesBuilder() { }

            internal AdminListItemTypesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListItemTypesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListItemTypesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListItemTypesBuilder SetSortBy(AdminListItemTypesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public AdminListItemTypes Build(
                string namespace_
            )
            {
                AdminListItemTypes op = new AdminListItemTypes(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminListItemTypesBuilder>(this);
                return op;
            }

            public AdminListItemTypes.Response Execute(
                string namespace_
            )
            {
                AdminListItemTypes op = Build(
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
            public async Task<AdminListItemTypes.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminListItemTypes op = Build(
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

        private AdminListItemTypes(AdminListItemTypesBuilder builder,
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
        public class Response : ApiResponse<Model.ApimodelsListItemTypesResp>
        {

            public ApimodelsErrorResponse? Error400 { get; set; } = null;

            public ApimodelsErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Inventory::AdminItemTypes::AdminListItemTypes";
        }

        #endregion

        public AdminListItemTypes(
            string namespace_,            
            long? limit,            
            long? offset,            
            AdminListItemTypesSortBy? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/itemtypes";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListItemTypes.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListItemTypes.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsListItemTypesResp>(payload, ResponseJsonOptions);
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

    public class AdminListItemTypesSortBy : StringEnum<AdminListItemTypesSortBy>
    {
        public static readonly AdminListItemTypesSortBy CreatedAt
            = new AdminListItemTypesSortBy("createdAt");

        public static readonly AdminListItemTypesSortBy CreatedAtasc
            = new AdminListItemTypesSortBy("createdAt:asc");

        public static readonly AdminListItemTypesSortBy CreatedAtdesc
            = new AdminListItemTypesSortBy("createdAt:desc");

        public static readonly AdminListItemTypesSortBy Name
            = new AdminListItemTypesSortBy("name");

        public static readonly AdminListItemTypesSortBy Nameasc
            = new AdminListItemTypesSortBy("name:asc");

        public static readonly AdminListItemTypesSortBy Namedesc
            = new AdminListItemTypesSortBy("name:desc");


        public static implicit operator AdminListItemTypesSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminListItemTypesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}