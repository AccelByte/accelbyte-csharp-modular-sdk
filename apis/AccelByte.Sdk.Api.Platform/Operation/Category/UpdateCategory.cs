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
    /// updateCategory
    ///
    /// This API is used to update category.
    /// 
    /// The category update data is a category object, example as:
    /// 
    /// 
    ///     {
    /// 
    ///         "storeId": "store-id",
    /// 
    ///         "localizationDisplayNames": {"en" : "Games"}
    /// 
    ///     }
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the updated category data
    /// </summary>
    public class UpdateCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCategoryBuilder Builder { get => new UpdateCategoryBuilder(); }

        public class UpdateCategoryBuilder
            : OperationBuilder<UpdateCategoryBuilder>
        {





            internal UpdateCategoryBuilder() { }

            internal UpdateCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateCategory Build(
                CategoryUpdate body,
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                UpdateCategory op = new UpdateCategory(this,
                    body,                    
                    categoryPath,                    
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<UpdateCategoryBuilder>(this);
                return op;
            }

            public Model.FullCategoryInfo? Execute(
                CategoryUpdate body,
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                UpdateCategory op = Build(
                    body,
                    categoryPath,
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
            public async Task<Model.FullCategoryInfo?> ExecuteAsync(
                CategoryUpdate body,
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                UpdateCategory op = Build(
                    body,
                    categoryPath,
                    namespace_,
                    storeId
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

        private UpdateCategory(UpdateCategoryBuilder builder,
            CategoryUpdate body,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCategory(
            string categoryPath,            
            string namespace_,            
            string storeId,            
            Model.CategoryUpdate body            
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Put;

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