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
    /// getEstimatedPrice
    ///
    /// This API is used to get estimated prices of a flexible pricing bundle
    /// </summary>
    public class GetEstimatedPrice : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEstimatedPriceBuilder Builder { get => new GetEstimatedPriceBuilder(); }

        public class GetEstimatedPriceBuilder
            : OperationBuilder<GetEstimatedPriceBuilder>
        {

            public string? Region { get; set; }

            public string? StoreId { get; set; }





            internal GetEstimatedPriceBuilder() { }

            internal GetEstimatedPriceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEstimatedPriceBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public GetEstimatedPriceBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public GetEstimatedPrice Build(
                string namespace_,
                string itemIds,
                string userId
            )
            {
                GetEstimatedPrice op = new GetEstimatedPrice(this,
                    namespace_,
                    itemIds,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.EstimatedPriceInfo? Execute(
                string namespace_,
                string itemIds,
                string userId
            )
            {
                GetEstimatedPrice op = Build(
                    namespace_,
                    itemIds,
                    userId
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

        private GetEstimatedPrice(GetEstimatedPriceBuilder builder,
            string namespace_,
            string itemIds,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StoreId is not null) QueryParams["storeId"] = builder.StoreId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEstimatedPrice(
            string namespace_,
            string? region,
            string? storeId,
            string itemIds,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (region is not null) QueryParams["region"] = region;
            if (storeId is not null) QueryParams["storeId"] = storeId;
            if (itemIds is not null) QueryParams["itemIds"] = itemIds;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/estimatedPrice";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EstimatedPriceInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EstimatedPriceInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EstimatedPriceInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}