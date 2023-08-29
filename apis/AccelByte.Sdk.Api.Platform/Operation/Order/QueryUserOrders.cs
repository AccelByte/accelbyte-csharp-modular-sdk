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
    /// queryUserOrders
    ///
    /// Query user orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : get order
    /// </summary>
    public class QueryUserOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserOrdersBuilder Builder { get => new QueryUserOrdersBuilder(); }

        public class QueryUserOrdersBuilder
            : OperationBuilder<QueryUserOrdersBuilder>
        {

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryUserOrdersStatus? Status { get; set; }





            internal QueryUserOrdersBuilder() { }

            internal QueryUserOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserOrdersBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QueryUserOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserOrdersBuilder SetStatus(QueryUserOrdersStatus _status)
            {
                Status = _status;
                return this;
            }





            public QueryUserOrders Build(
                string namespace_,
                string userId
            )
            {
                QueryUserOrders op = new QueryUserOrders(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.OrderPagingSlicedResult? Execute(
                string namespace_,
                string userId
            )
            {
                QueryUserOrders op = Build(
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
        }

        private QueryUserOrders(QueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserOrders(
            string namespace_,            
            string userId,            
            string? itemId,            
            int? limit,            
            int? offset,            
            QueryUserOrdersStatus? status            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.OrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryUserOrdersStatus : StringEnum<QueryUserOrdersStatus>
    {
        public static readonly QueryUserOrdersStatus CHARGEBACK
            = new QueryUserOrdersStatus("CHARGEBACK");

        public static readonly QueryUserOrdersStatus CHARGEBACKREVERSED
            = new QueryUserOrdersStatus("CHARGEBACK_REVERSED");

        public static readonly QueryUserOrdersStatus CHARGED
            = new QueryUserOrdersStatus("CHARGED");

        public static readonly QueryUserOrdersStatus CLOSED
            = new QueryUserOrdersStatus("CLOSED");

        public static readonly QueryUserOrdersStatus DELETED
            = new QueryUserOrdersStatus("DELETED");

        public static readonly QueryUserOrdersStatus FULFILLED
            = new QueryUserOrdersStatus("FULFILLED");

        public static readonly QueryUserOrdersStatus FULFILLFAILED
            = new QueryUserOrdersStatus("FULFILL_FAILED");

        public static readonly QueryUserOrdersStatus INIT
            = new QueryUserOrdersStatus("INIT");

        public static readonly QueryUserOrdersStatus REFUNDED
            = new QueryUserOrdersStatus("REFUNDED");

        public static readonly QueryUserOrdersStatus REFUNDING
            = new QueryUserOrdersStatus("REFUNDING");

        public static readonly QueryUserOrdersStatus REFUNDFAILED
            = new QueryUserOrdersStatus("REFUND_FAILED");


        public static implicit operator QueryUserOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public QueryUserOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}