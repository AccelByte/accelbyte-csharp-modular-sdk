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
    /// downloadCategories
    ///
    /// This API is used to download store's structured categories.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store content)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store content)
    ///   *  Returns : structured categories
    /// </summary>
    public class DownloadCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadCategoriesBuilder Builder { get => new DownloadCategoriesBuilder(); }

        public class DownloadCategoriesBuilder
            : OperationBuilder<DownloadCategoriesBuilder>
        {

            public string? Language { get; set; }

            public string? StoreId { get; set; }





            internal DownloadCategoriesBuilder() { }

            internal DownloadCategoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DownloadCategoriesBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public DownloadCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public DownloadCategories Build(
                string namespace_
            )
            {
                DownloadCategories op = new DownloadCategories(this,
                    namespace_
                );

                op.SetBaseFields<DownloadCategoriesBuilder>(this);
                return op;
            }

            public List<Model.HierarchicalCategoryInfo>? Execute(
                string namespace_
            )
            {
                DownloadCategories op = Build(
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
            public async Task<List<Model.HierarchicalCategoryInfo>?> ExecuteAsync(
                string namespace_
            )
            {
                DownloadCategories op = Build(
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

        private DownloadCategories(DownloadCategoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






        }
        #endregion

        public DownloadCategories(
            string namespace_,
            string? language,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (language is not null) QueryParams["language"] = language;
            if (storeId is not null) QueryParams["storeId"] = storeId;






        }

        public override string Path => "/platform/public/namespaces/{namespace}/categories/download";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.HierarchicalCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.HierarchicalCategoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.HierarchicalCategoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}