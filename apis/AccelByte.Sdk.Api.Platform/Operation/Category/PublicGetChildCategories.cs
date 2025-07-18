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
    /// publicGetChildCategories
    ///
    /// This API is used to get child categories by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Returns : list of child categories data
    /// </summary>
    public class PublicGetChildCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetChildCategoriesBuilder Builder { get => new PublicGetChildCategoriesBuilder(); }

        public class PublicGetChildCategoriesBuilder
            : OperationBuilder<PublicGetChildCategoriesBuilder>
        {

            public string? Language { get; set; }

            public string? StoreId { get; set; }





            internal PublicGetChildCategoriesBuilder() { }

            internal PublicGetChildCategoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetChildCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetChildCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetChildCategories Build(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetChildCategories op = new PublicGetChildCategories(this,
                    categoryPath,                    
                    namespace_                    
                );

                op.SetBaseFields<PublicGetChildCategoriesBuilder>(this);
                return op;
            }

            public PublicGetChildCategories.Response Execute(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetChildCategories op = Build(
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
            public async Task<PublicGetChildCategories.Response> ExecuteAsync(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetChildCategories op = Build(
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

        private PublicGetChildCategories(PublicGetChildCategoriesBuilder builder,
            string categoryPath,
            string namespace_
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            

            
            
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.CategoryInfo>>
        {


            protected override string GetFullOperationId() => "Platform::Category::PublicGetChildCategories";
        }

        #endregion

        public PublicGetChildCategories(
            string categoryPath,            
            string namespace_,            
            string? language,            
            string? storeId            
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (language is not null) QueryParams["language"] = language;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories/{categoryPath}/children";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetChildCategories.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetChildCategories.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.CategoryInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}