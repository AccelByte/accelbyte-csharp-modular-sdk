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
    /// getBulkItemIdBySkus
    ///
    /// This API is used to get an list of itemId by list of sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : item data
    /// </summary>
    public class GetBulkItemIdBySkus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBulkItemIdBySkusBuilder Builder { get => new GetBulkItemIdBySkusBuilder(); }

        public class GetBulkItemIdBySkusBuilder
            : OperationBuilder<GetBulkItemIdBySkusBuilder>
        {

            public List<string>? Sku { get; set; }

            public string? StoreId { get; set; }





            internal GetBulkItemIdBySkusBuilder() { }

            internal GetBulkItemIdBySkusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetBulkItemIdBySkusBuilder SetSku(List<string> _sku)
            {
                Sku = _sku;
                return this;
            }

            public GetBulkItemIdBySkusBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetBulkItemIdBySkus Build(
                string namespace_
            )
            {
                GetBulkItemIdBySkus op = new GetBulkItemIdBySkus(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ItemId>? Execute(
                string namespace_
            )
            {
                GetBulkItemIdBySkus op = Build(
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

        private GetBulkItemIdBySkus(GetBulkItemIdBySkusBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Sku is not null) QueryParams["sku"] = builder.Sku;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;



            CollectionFormatMap["sku"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetBulkItemIdBySkus(
            string namespace_,
            List<string>? sku,
            string? storeId
        )
        {
            PathParams["namespace"] = namespace_;

            if (sku is not null) QueryParams["sku"] = sku;
            if (storeId is not null) QueryParams["storeId"] = storeId;



            CollectionFormatMap["sku"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/itemId/bySkus";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ItemId>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemId>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemId>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}