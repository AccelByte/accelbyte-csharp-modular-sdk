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
    /// getLocaleItem
    ///
    /// This API is used to get an item in specific locale. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : item data
    /// </summary>
    public class GetLocaleItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLocaleItemBuilder Builder { get => new GetLocaleItemBuilder(); }

        public class GetLocaleItemBuilder
            : OperationBuilder<GetLocaleItemBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? Language { get; set; }

            public bool? PopulateBundle { get; set; }

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal GetLocaleItemBuilder() { }

            internal GetLocaleItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLocaleItemBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetLocaleItemBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public GetLocaleItemBuilder SetPopulateBundle(bool _populateBundle)
            {
                PopulateBundle = _populateBundle;
                return this;
            }

            public GetLocaleItemBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public GetLocaleItemBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetLocaleItem Build(
                string itemId,
                string namespace_
            )
            {
                GetLocaleItem op = new GetLocaleItem(this,
                    itemId,
                    namespace_
                );

                op.SetBaseFields<GetLocaleItemBuilder>(this);
                return op;
            }

            public Model.PopulatedItemInfo? Execute(
                string itemId,
                string namespace_
            )
            {
                GetLocaleItem op = Build(
                    itemId,
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

            public Model.PopulatedItemInfo<T1, T2>? Execute<T1, T2>(
                string itemId,
                string namespace_
            )
            {
                GetLocaleItem op = Build(
                    itemId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetLocaleItem(GetLocaleItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Language is not null) QueryParams["language"] = builder.Language;
            if (builder.PopulateBundle != null) QueryParams["populateBundle"] = Convert.ToString(builder.PopulateBundle)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLocaleItem(
            string itemId,
            string namespace_,
            bool? activeOnly,
            string? language,
            bool? populateBundle,
            string? region,
            string? storeId
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language is not null) QueryParams["language"] = language;
            if (populateBundle != null) QueryParams["populateBundle"] = Convert.ToString(populateBundle)!;
            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/locale";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PopulatedItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.PopulatedItemInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PopulatedItemInfo<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}