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
    /// getItems
    ///
    /// This API is used to get items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items info
    /// </summary>
    public class GetItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemsBuilder Builder { get => new GetItemsBuilder(); }

        public class GetItemsBuilder
            : OperationBuilder<GetItemsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? StoreId { get; set; }





            internal GetItemsBuilder() { }

            internal GetItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetItemsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetItemsBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetItems Build(
                string namespace_,
                string itemIds
            )
            {
                GetItems op = new GetItems(this,
                    namespace_,
                    itemIds
                );

                op.SetBaseFields<GetItemsBuilder>(this);
                return op;
            }

            public List<Model.FullItemInfo>? Execute(
                string namespace_,
                string itemIds
            )
            {
                GetItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.FullItemInfo>?> ExecuteAsync(
                string namespace_,
                string itemIds
            )
            {
                GetItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.FullItemInfo<T1>>? Execute<T1>(
                string namespace_,
                string itemIds
            )
            {
                GetItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.FullItemInfo<T1>>?> ExecuteAsync<T1>(
                string namespace_,
                string itemIds
            )
            {
                GetItems op = Build(
                    namespace_,
                    itemIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetItems(GetItemsBuilder builder,
            string namespace_,
            string itemIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetItems(
            string namespace_,
            bool? activeOnly,
            string? storeId,
            string itemIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.FullItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.FullItemInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.FullItemInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.FullItemInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.FullItemInfo<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.FullItemInfo<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}