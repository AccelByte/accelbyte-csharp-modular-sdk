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
    /// publicGetDescendantCategories
    ///
    /// This API is used to get descendant categories by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store category)
    ///   *  Returns : list of descendant categories data
    /// </summary>
    public class PublicGetDescendantCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetDescendantCategoriesBuilder Builder { get => new PublicGetDescendantCategoriesBuilder(); }

        public class PublicGetDescendantCategoriesBuilder
            : OperationBuilder<PublicGetDescendantCategoriesBuilder>
        {

            public string? Language { get; set; }

            public string? StoreId { get; set; }





            internal PublicGetDescendantCategoriesBuilder() { }

            internal PublicGetDescendantCategoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicGetDescendantCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetDescendantCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetDescendantCategories Build(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetDescendantCategories op = new PublicGetDescendantCategories(this,
                    categoryPath,
                    namespace_
                );

                op.SetBaseFields<PublicGetDescendantCategoriesBuilder>(this);
                return op;
            }

            public List<Model.CategoryInfo>? Execute(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetDescendantCategories op = Build(
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
            public async Task<List<Model.CategoryInfo>?> ExecuteAsync(
                string categoryPath,
                string namespace_
            )
            {
                PublicGetDescendantCategories op = Build(
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

        private PublicGetDescendantCategories(PublicGetDescendantCategoriesBuilder builder,
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

        public PublicGetDescendantCategories(
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

        public override string Path => "/platform/public/namespaces/{namespace}/categories/{categoryPath}/descendants";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

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