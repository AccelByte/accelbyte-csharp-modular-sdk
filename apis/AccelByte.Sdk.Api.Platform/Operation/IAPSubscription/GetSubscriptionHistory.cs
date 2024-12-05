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
    /// getSubscriptionHistory
    ///
    /// Get Subscription Transaction Update History
    /// </summary>
    public class GetSubscriptionHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSubscriptionHistoryBuilder Builder { get => new GetSubscriptionHistoryBuilder(); }

        public class GetSubscriptionHistoryBuilder
            : OperationBuilder<GetSubscriptionHistoryBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal GetSubscriptionHistoryBuilder() { }

            internal GetSubscriptionHistoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetSubscriptionHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetSubscriptionHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetSubscriptionHistory Build(
                string id,
                string namespace_,
                string userId
            )
            {
                GetSubscriptionHistory op = new GetSubscriptionHistory(this,
                    id,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetSubscriptionHistoryBuilder>(this);
                return op;
            }

            public GetSubscriptionHistory.Response Execute(
                string id,
                string namespace_,
                string userId
            )
            {
                GetSubscriptionHistory op = Build(
                    id,
                    namespace_,
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
            public async Task<GetSubscriptionHistory.Response> ExecuteAsync(
                string id,
                string namespace_,
                string userId
            )
            {
                GetSubscriptionHistory op = Build(
                    id,
                    namespace_,
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

        private GetSubscriptionHistory(GetSubscriptionHistoryBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ThirdPartySubscriptionTransactionHistoryPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::IAPSubscription::GetSubscriptionHistory";
        }

        #endregion

        public GetSubscriptionHistory(
            string id,
            string namespace_,
            string userId,
            int? limit,
            int? offset
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions/{id}/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetSubscriptionHistory.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetSubscriptionHistory.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ThirdPartySubscriptionTransactionHistoryPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}