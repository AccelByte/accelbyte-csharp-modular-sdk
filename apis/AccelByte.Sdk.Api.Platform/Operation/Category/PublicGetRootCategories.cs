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
    /// publicGetRootCategories
    ///
    /// This API is used to get root categories.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Returns : root category data
    /// </summary>
    public class PublicGetRootCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetRootCategoriesBuilder Builder { get => new PublicGetRootCategoriesBuilder(); }

        public class PublicGetRootCategoriesBuilder
            : OperationBuilder<PublicGetRootCategoriesBuilder>
        {

            public string? Language { get; set; }

            public string? StoreId { get; set; }





            internal PublicGetRootCategoriesBuilder() { }

            internal PublicGetRootCategoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetRootCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetRootCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetRootCategories Build(
                string namespace_
            )
            {
                PublicGetRootCategories op = new PublicGetRootCategories(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.CategoryInfo>? Execute(
                string namespace_
            )
            {
                PublicGetRootCategories op = Build(
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

        private PublicGetRootCategories(PublicGetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            

            
            
            

        }
        #endregion

        public PublicGetRootCategories(
            string namespace_,            
            string? language,            
            string? storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language is not null) QueryParams["language"] = language;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.CategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CategoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CategoryInfo>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}