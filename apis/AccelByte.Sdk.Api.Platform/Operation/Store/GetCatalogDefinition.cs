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
    /// getCatalogDefinition
    ///
    /// This API is used to get catalog definition for import/export store by CSV
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : catalog definition
    /// </summary>
    public class GetCatalogDefinition : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCatalogDefinitionBuilder Builder { get => new GetCatalogDefinitionBuilder(); }

        public class GetCatalogDefinitionBuilder
            : OperationBuilder<GetCatalogDefinitionBuilder>
        {





            internal GetCatalogDefinitionBuilder() { }

            internal GetCatalogDefinitionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetCatalogDefinition Build(
                string namespace_,
                GetCatalogDefinitionCatalogType catalogType
            )
            {
                GetCatalogDefinition op = new GetCatalogDefinition(this,
                    namespace_,                    
                    catalogType                    
                );

                op.SetBaseFields<GetCatalogDefinitionBuilder>(this);
                return op;
            }

            public GetCatalogDefinition.Response Execute(
                string namespace_,
                string catalogType
            )
            {
                GetCatalogDefinition op = Build(
                    namespace_,
                    catalogType
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetCatalogDefinition.Response> ExecuteAsync(
                string namespace_,
                string catalogType
            )
            {
                GetCatalogDefinition op = Build(
                    namespace_,
                    catalogType
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

        private GetCatalogDefinition(GetCatalogDefinitionBuilder builder,
            string namespace_,
            GetCatalogDefinitionCatalogType catalogType
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (catalogType is not null) QueryParams["catalogType"] = catalogType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.CatalogDefinitionInfo>>
        {


            protected override string GetFullOperationId() => "Platform::Store::GetCatalogDefinition";
        }

        #endregion

        public GetCatalogDefinition(
            string namespace_,            
            GetCatalogDefinitionCatalogType catalogType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (catalogType is not null) QueryParams["catalogType"] = catalogType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/catalogDefinition";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetCatalogDefinition.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetCatalogDefinition.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.CatalogDefinitionInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class GetCatalogDefinitionCatalogType : StringEnum<GetCatalogDefinitionCatalogType>
    {
        public static readonly GetCatalogDefinitionCatalogType APP
            = new GetCatalogDefinitionCatalogType("APP");

        public static readonly GetCatalogDefinitionCatalogType CATEGORY
            = new GetCatalogDefinitionCatalogType("CATEGORY");

        public static readonly GetCatalogDefinitionCatalogType ITEM
            = new GetCatalogDefinitionCatalogType("ITEM");

        public static readonly GetCatalogDefinitionCatalogType SECTION
            = new GetCatalogDefinitionCatalogType("SECTION");

        public static readonly GetCatalogDefinitionCatalogType VIEW
            = new GetCatalogDefinitionCatalogType("VIEW");


        public static implicit operator GetCatalogDefinitionCatalogType(string value)
        {
            return NewValue(value);
        }

        public GetCatalogDefinitionCatalogType(string enumValue)
            : base(enumValue)
        {

        }
    }

}