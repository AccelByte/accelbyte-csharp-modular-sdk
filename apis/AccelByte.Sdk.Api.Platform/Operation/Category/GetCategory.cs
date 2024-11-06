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
    /// getCategory
    ///
    /// This API is used to get category by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : category data
    /// </summary>
    public class GetCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCategoryBuilder Builder { get => new GetCategoryBuilder(); }

        public class GetCategoryBuilder
            : OperationBuilder<GetCategoryBuilder>
        {

            public string? StoreId { get; set; }





            internal GetCategoryBuilder() { }

            internal GetCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCategoryBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetCategory Build(
                string categoryPath,
                string namespace_
            )
            {
                GetCategory op = new GetCategory(this,
                    categoryPath,                    
                    namespace_                    
                );

                op.SetBaseFields<GetCategoryBuilder>(this);
                return op;
            }

            public GetCategory.Response Execute(
                string categoryPath,
                string namespace_
            )
            {
                GetCategory op = Build(
                    categoryPath,
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
            public async Task<GetCategory.Response> ExecuteAsync(
                string categoryPath,
                string namespace_
            )
            {
                GetCategory op = Build(
                    categoryPath,
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

        private GetCategory(GetCategoryBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FullCategoryInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Category::GetCategory";
        }

        #endregion

        public GetCategory(
            string categoryPath,            
            string namespace_,            
            string? storeId            
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetCategory.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetCategory.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload, ResponseJsonOptions);
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

}