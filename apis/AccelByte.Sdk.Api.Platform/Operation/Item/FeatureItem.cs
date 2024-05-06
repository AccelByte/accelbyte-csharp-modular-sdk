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
    /// featureItem
    ///
    /// Add a feature to an item.
    /// Other detail info:
    /// 
    ///   * Returns : updated item
    /// </summary>
    public class FeatureItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FeatureItemBuilder Builder { get => new FeatureItemBuilder(); }

        public class FeatureItemBuilder
            : OperationBuilder<FeatureItemBuilder>
        {





            internal FeatureItemBuilder() { }

            internal FeatureItemBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FeatureItem Build(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                FeatureItem op = new FeatureItem(this,
                    feature,
                    itemId,
                    namespace_,
                    storeId
                );

                op.SetBaseFields<FeatureItemBuilder>(this);
                return op;
            }

            public Model.FullItemInfo? Execute(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                FeatureItem op = Build(
                    feature,
                    itemId,
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
            public async Task<Model.FullItemInfo?> ExecuteAsync(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                FeatureItem op = Build(
                    feature,
                    itemId,
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

            public Model.FullItemInfo<T1>? Execute<T1>(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                FeatureItem op = Build(
                    feature,
                    itemId,
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.FullItemInfo<T1>?> ExecuteAsync<T1>(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                FeatureItem op = Build(
                    feature,
                    itemId,
                    namespace_,
                    storeId
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

        private FeatureItem(FeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FeatureItem(
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.FullItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.FullItemInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}