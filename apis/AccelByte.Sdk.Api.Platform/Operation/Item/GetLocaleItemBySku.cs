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
    /// getLocaleItemBySku
    ///
    /// This API is used to get an item by sku in specific locale. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : item data
    /// </summary>
    public class GetLocaleItemBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLocaleItemBySkuBuilder Builder { get => new GetLocaleItemBySkuBuilder(); }

        public class GetLocaleItemBySkuBuilder
            : OperationBuilder<GetLocaleItemBySkuBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? Language { get; set; }

            public bool? PopulateBundle { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal GetLocaleItemBySkuBuilder() { }

            internal GetLocaleItemBySkuBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLocaleItemBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetPopulateBundle(bool _populateBundle)
            {
                PopulateBundle = _populateBundle;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public GetLocaleItemBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetLocaleItemBySku Build(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = new GetLocaleItemBySku(this,
                    namespace_,
                    sku
                );

                op.SetBaseFields<GetLocaleItemBySkuBuilder>(this);
                return op;
            }

            public GetLocaleItemBySku.Response Execute(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = Build(
                    namespace_,
                    sku
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetLocaleItemBySku.Response> ExecuteAsync(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = Build(
                    namespace_,
                    sku
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public GetLocaleItemBySku.Response<T1, T2> Execute<T1, T2>(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = Build(
                    namespace_,
                    sku
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetLocaleItemBySku.Response<T1, T2>> ExecuteAsync<T1, T2>(
                string namespace_,
                string sku
            )
            {
                GetLocaleItemBySku op = Build(
                    namespace_,
                    sku
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetLocaleItemBySku(GetLocaleItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.PopulateBundle != null) QueryParams["populateBundle"] = Convert.ToString(builder.PopulateBundle)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PopulatedItemInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::GetLocaleItemBySku";
        }

        public class Response<T1, T2> : ApiResponse<Model.PopulatedItemInfo<T1, T2>>
        {
            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::GetLocaleItemBySku";
        }
        #endregion

        public GetLocaleItemBySku(
            string namespace_,
            bool? activeOnly,
            string? language,
            bool? populateBundle,
            string? region,
            string? storeId,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language is not null) QueryParams["language"] = language;
            if (populateBundle != null) QueryParams["populateBundle"] = Convert.ToString(populateBundle)!;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (sku is not null) QueryParams["sku"] = sku;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/bySku/locale";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetLocaleItemBySku.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLocaleItemBySku.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PopulatedItemInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }

        public GetLocaleItemBySku.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLocaleItemBySku.Response<T1, T2>()
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
                response.Data = JsonSerializer.Deserialize<Model.PopulatedItemInfo<T1, T2>>(payload, ResponseJsonOptions);
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