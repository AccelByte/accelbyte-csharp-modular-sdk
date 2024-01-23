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
    /// getItemByAppId
    ///
    /// This API is used to get the item by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the item with that appId
    /// </summary>
    public class GetItemByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemByAppIdBuilder Builder { get => new GetItemByAppIdBuilder(); }

        public class GetItemByAppIdBuilder
            : OperationBuilder<GetItemByAppIdBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? StoreId { get; set; }





            internal GetItemByAppIdBuilder() { }

            internal GetItemByAppIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetItemByAppIdBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetItemByAppIdBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetItemByAppId Build(
                string namespace_,
                string appId
            )
            {
                GetItemByAppId op = new GetItemByAppId(this,
                    namespace_,
                    appId
                );

                op.SetBaseFields<GetItemByAppIdBuilder>(this);
                return op;
            }

            public Model.FullItemInfo? Execute(
                string namespace_,
                string appId
            )
            {
                GetItemByAppId op = Build(
                    namespace_,
                    appId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.FullItemInfo<T1>? Execute<T1>(
                string namespace_,
                string appId
            )
            {
                GetItemByAppId op = Build(
                    namespace_,
                    appId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetItemByAppId(GetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetItemByAppId(
            string namespace_,
            bool? activeOnly,
            string? storeId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (appId is not null) QueryParams["appId"] = appId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

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