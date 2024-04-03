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
    /// listCategoriesBasic
    ///
    /// This API is used to list all categories' basic info of a store ordered by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=2 (READ)
    ///   *  Returns : list of categories' paths
    /// </summary>
    public class ListCategoriesBasic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListCategoriesBasicBuilder Builder { get => new ListCategoriesBasicBuilder(); }

        public class ListCategoriesBasicBuilder
            : OperationBuilder<ListCategoriesBasicBuilder>
        {

            public string? StoreId { get; set; }





            internal ListCategoriesBasicBuilder() { }

            internal ListCategoriesBasicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListCategoriesBasicBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public ListCategoriesBasic Build(
                string namespace_
            )
            {
                ListCategoriesBasic op = new ListCategoriesBasic(this,
                    namespace_
                );

                op.SetBaseFields<ListCategoriesBasicBuilder>(this);
                return op;
            }

            public List<Model.BasicCategoryInfo>? Execute(
                string namespace_
            )
            {
                ListCategoriesBasic op = Build(
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
            public async Task<List<Model.BasicCategoryInfo>?> ExecuteAsync(
                string namespace_
            )
            {
                ListCategoriesBasic op = Build(
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

        private ListCategoriesBasic(ListCategoriesBasicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListCategoriesBasic(
            string namespace_,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/basic";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.BasicCategoryInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BasicCategoryInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BasicCategoryInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}