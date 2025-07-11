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
    /// queryUserIAPOrders
    ///
    /// Query IAP orders.
    /// Other detail info:
    /// 
    ///   * Returns : paginated iap orders
    /// </summary>
    public class QueryUserIAPOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserIAPOrdersBuilder Builder { get => new QueryUserIAPOrdersBuilder(); }

        public class QueryUserIAPOrdersBuilder
            : OperationBuilder<QueryUserIAPOrdersBuilder>
        {

            public string? EndTime { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? ProductId { get; set; }

            public string? StartTime { get; set; }

            public QueryUserIAPOrdersStatus? Status { get; set; }

            public QueryUserIAPOrdersType? Type { get; set; }





            internal QueryUserIAPOrdersBuilder() { }

            internal QueryUserIAPOrdersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserIAPOrdersBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetProductId(string _productId)
            {
                ProductId = _productId;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetStatus(QueryUserIAPOrdersStatus _status)
            {
                Status = _status;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetType(QueryUserIAPOrdersType _type)
            {
                Type = _type;
                return this;
            }





            public QueryUserIAPOrders Build(
                string namespace_,
                string userId
            )
            {
                QueryUserIAPOrders op = new QueryUserIAPOrders(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<QueryUserIAPOrdersBuilder>(this);
                return op;
            }

            public QueryUserIAPOrders.Response Execute(
                string namespace_,
                string userId
            )
            {
                QueryUserIAPOrders op = Build(
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
            public async Task<QueryUserIAPOrders.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                QueryUserIAPOrders op = Build(
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

        private QueryUserIAPOrders(QueryUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EndTime is not null) QueryParams["endTime"] = builder.EndTime;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ProductId is not null) QueryParams["productId"] = builder.ProductId;
            if (builder.StartTime is not null) QueryParams["startTime"] = builder.StartTime;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Type is not null) QueryParams["type"] = builder.Type.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.IAPOrderPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::IAP::QueryUserIAPOrders";
        }

        #endregion

        public QueryUserIAPOrders(
            string namespace_,            
            string userId,            
            string? endTime,            
            int? limit,            
            int? offset,            
            string? productId,            
            string? startTime,            
            QueryUserIAPOrdersStatus? status,            
            QueryUserIAPOrdersType? type            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (endTime is not null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (productId is not null) QueryParams["productId"] = productId;
            if (startTime is not null) QueryParams["startTime"] = startTime;
            if (status is not null) QueryParams["status"] = status.Value;
            if (type is not null) QueryParams["type"] = type.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryUserIAPOrders.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryUserIAPOrders.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class QueryUserIAPOrdersStatus : StringEnum<QueryUserIAPOrdersStatus>
    {
        public static readonly QueryUserIAPOrdersStatus FAILED
            = new QueryUserIAPOrdersStatus("FAILED");

        public static readonly QueryUserIAPOrdersStatus FULFILLED
            = new QueryUserIAPOrdersStatus("FULFILLED");

        public static readonly QueryUserIAPOrdersStatus PARTIALREVOKED
            = new QueryUserIAPOrdersStatus("PARTIAL_REVOKED");

        public static readonly QueryUserIAPOrdersStatus REVOKED
            = new QueryUserIAPOrdersStatus("REVOKED");

        public static readonly QueryUserIAPOrdersStatus REVOKEFAILED
            = new QueryUserIAPOrdersStatus("REVOKE_FAILED");

        public static readonly QueryUserIAPOrdersStatus VERIFIED
            = new QueryUserIAPOrdersStatus("VERIFIED");


        public static implicit operator QueryUserIAPOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public QueryUserIAPOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryUserIAPOrdersType : StringEnum<QueryUserIAPOrdersType>
    {
        public static readonly QueryUserIAPOrdersType APPLE
            = new QueryUserIAPOrdersType("APPLE");

        public static readonly QueryUserIAPOrdersType EPICGAMES
            = new QueryUserIAPOrdersType("EPICGAMES");

        public static readonly QueryUserIAPOrdersType GOOGLE
            = new QueryUserIAPOrdersType("GOOGLE");

        public static readonly QueryUserIAPOrdersType OCULUS
            = new QueryUserIAPOrdersType("OCULUS");

        public static readonly QueryUserIAPOrdersType PLAYSTATION
            = new QueryUserIAPOrdersType("PLAYSTATION");

        public static readonly QueryUserIAPOrdersType STADIA
            = new QueryUserIAPOrdersType("STADIA");

        public static readonly QueryUserIAPOrdersType STEAM
            = new QueryUserIAPOrdersType("STEAM");

        public static readonly QueryUserIAPOrdersType TWITCH
            = new QueryUserIAPOrdersType("TWITCH");

        public static readonly QueryUserIAPOrdersType XBOX
            = new QueryUserIAPOrdersType("XBOX");


        public static implicit operator QueryUserIAPOrdersType(string value)
        {
            return NewValue(value);
        }

        public QueryUserIAPOrdersType(string enumValue)
            : base(enumValue)
        {

        }
    }

}