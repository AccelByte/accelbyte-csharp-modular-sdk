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
    /// getRootCategories
    ///
    /// This API is used to get root categories.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=2 (READ)
    ///   *  Returns : root category data
    /// </summary>
    public class GetRootCategories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRootCategoriesBuilder Builder { get => new GetRootCategoriesBuilder(); }

        public class GetRootCategoriesBuilder
            : OperationBuilder<GetRootCategoriesBuilder>
        {

            public string? StoreId { get; set; }





            internal GetRootCategoriesBuilder() { }

            internal GetRootCategoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetRootCategoriesBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetRootCategories Build(
                string namespace_
            )
            {
                GetRootCategories op = new GetRootCategories(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.FullCategoryInfo>? Execute(
                string namespace_
            )
            {
                GetRootCategories op = Build(
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

        private GetRootCategories(GetRootCategoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRootCategories(
            string namespace_,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.FullCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.FullCategoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.FullCategoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}