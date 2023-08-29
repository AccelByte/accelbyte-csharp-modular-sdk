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
    /// createCategory
    ///
    /// This API is used to create category.
    /// 
    /// A category is a path separated by "/". A category also has localized display names. Example:
    /// 
    /// 
    ///     {
    /// 
    ///         "categoryPath": "/games",
    /// 
    ///         "localizationDisplayNames": {"en" : "Games"}
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=1 (CREATE)
    ///   *  Returns : created category data
    /// </summary>
    public class CreateCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateCategoryBuilder Builder { get => new CreateCategoryBuilder(); }

        public class CreateCategoryBuilder
            : OperationBuilder<CreateCategoryBuilder>
        {


            public Model.CategoryCreate? Body { get; set; }




            internal CreateCategoryBuilder() { }

            internal CreateCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateCategoryBuilder SetBody(Model.CategoryCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateCategory Build(
                string namespace_,
                string storeId
            )
            {
                CreateCategory op = new CreateCategory(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.FullCategoryInfo? Execute(
                string namespace_,
                string storeId
            )
            {
                CreateCategory op = Build(
                    namespace_,
                    storeId
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

        private CreateCategory(CreateCategoryBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateCategory(
            string namespace_,            
            string storeId,            
            Model.CategoryCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.FullCategoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}