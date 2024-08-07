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
    /// getUserSubscriptionBillingHistories
    ///
    /// Get user subscription billing histories.
    /// Other detail info:
    /// 
    ///   * Returns : paginated subscription billing history
    /// </summary>
    public class GetUserSubscriptionBillingHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserSubscriptionBillingHistoriesBuilder Builder { get => new GetUserSubscriptionBillingHistoriesBuilder(); }

        public class GetUserSubscriptionBillingHistoriesBuilder
            : OperationBuilder<GetUserSubscriptionBillingHistoriesBuilder>
        {

            public bool? ExcludeFree { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal GetUserSubscriptionBillingHistoriesBuilder() { }

            internal GetUserSubscriptionBillingHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserSubscriptionBillingHistoriesBuilder SetExcludeFree(bool _excludeFree)
            {
                ExcludeFree = _excludeFree;
                return this;
            }

            public GetUserSubscriptionBillingHistoriesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserSubscriptionBillingHistoriesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetUserSubscriptionBillingHistories Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                GetUserSubscriptionBillingHistories op = new GetUserSubscriptionBillingHistories(this,
                    namespace_,
                    subscriptionId,
                    userId
                );

                op.SetBaseFields<GetUserSubscriptionBillingHistoriesBuilder>(this);
                return op;
            }

            public Model.BillingHistoryPagingSlicedResult? Execute(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                GetUserSubscriptionBillingHistories op = Build(
                    namespace_,
                    subscriptionId,
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
            public async Task<Model.BillingHistoryPagingSlicedResult?> ExecuteAsync(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                GetUserSubscriptionBillingHistories op = Build(
                    namespace_,
                    subscriptionId,
                    userId
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

        private GetUserSubscriptionBillingHistories(GetUserSubscriptionBillingHistoriesBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;

            if (builder.ExcludeFree != null) QueryParams["excludeFree"] = Convert.ToString(builder.ExcludeFree)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserSubscriptionBillingHistories(
            string namespace_,
            string subscriptionId,
            string userId,
            bool? excludeFree,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;

            if (excludeFree != null) QueryParams["excludeFree"] = Convert.ToString(excludeFree)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.BillingHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BillingHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BillingHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}