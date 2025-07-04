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
    /// queryUserThirdPartySubscriptionTransactions
    ///
    /// Admin query user subscription transactions, default sort by startAt timeOther detail info:
    ///   * Returns :
    /// </summary>
    public class QueryUserThirdPartySubscriptionTransactions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserThirdPartySubscriptionTransactionsBuilder Builder { get => new QueryUserThirdPartySubscriptionTransactionsBuilder(); }

        public class QueryUserThirdPartySubscriptionTransactionsBuilder
            : OperationBuilder<QueryUserThirdPartySubscriptionTransactionsBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public string? GroupId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryUserThirdPartySubscriptionTransactionsPlatform? Platform { get; set; }

            public string? ProductId { get; set; }





            internal QueryUserThirdPartySubscriptionTransactionsBuilder() { }

            internal QueryUserThirdPartySubscriptionTransactionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public QueryUserThirdPartySubscriptionTransactionsBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public QueryUserThirdPartySubscriptionTransactionsBuilder SetGroupId(string _groupId)
            {
                GroupId = _groupId;
                return this;
            }

            public QueryUserThirdPartySubscriptionTransactionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserThirdPartySubscriptionTransactionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserThirdPartySubscriptionTransactionsBuilder SetPlatform(QueryUserThirdPartySubscriptionTransactionsPlatform _platform)
            {
                Platform = _platform;
                return this;
            }

            public QueryUserThirdPartySubscriptionTransactionsBuilder SetProductId(string _productId)
            {
                ProductId = _productId;
                return this;
            }





            public QueryUserThirdPartySubscriptionTransactions Build(
                string namespace_,
                string userId
            )
            {
                QueryUserThirdPartySubscriptionTransactions op = new QueryUserThirdPartySubscriptionTransactions(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<QueryUserThirdPartySubscriptionTransactionsBuilder>(this);
                return op;
            }

            public QueryUserThirdPartySubscriptionTransactions.Response Execute(
                string namespace_,
                string userId
            )
            {
                QueryUserThirdPartySubscriptionTransactions op = Build(
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
            public async Task<QueryUserThirdPartySubscriptionTransactions.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                QueryUserThirdPartySubscriptionTransactions op = Build(
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

        private QueryUserThirdPartySubscriptionTransactions(QueryUserThirdPartySubscriptionTransactionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.GroupId is not null) QueryParams["groupId"] = builder.GroupId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform.Value;
            if (builder.ProductId is not null) QueryParams["productId"] = builder.ProductId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ThirdPartySubscriptionTransactionPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::IAPSubscription::QueryUserThirdPartySubscriptionTransactions";
        }

        #endregion

        public QueryUserThirdPartySubscriptionTransactions(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string? groupId,            
            int? limit,            
            int? offset,            
            QueryUserThirdPartySubscriptionTransactionsPlatform? platform,            
            string? productId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (groupId is not null) QueryParams["groupId"] = groupId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platform is not null) QueryParams["platform"] = platform.Value;
            if (productId is not null) QueryParams["productId"] = productId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryUserThirdPartySubscriptionTransactions.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryUserThirdPartySubscriptionTransactions.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ThirdPartySubscriptionTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class QueryUserThirdPartySubscriptionTransactionsPlatform : StringEnum<QueryUserThirdPartySubscriptionTransactionsPlatform>
    {
        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform APPLE
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("APPLE");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform EPICGAMES
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("EPICGAMES");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform GOOGLE
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("GOOGLE");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform OCULUS
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("OCULUS");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform PLAYSTATION
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("PLAYSTATION");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform STADIA
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("STADIA");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform STEAM
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("STEAM");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform TWITCH
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("TWITCH");

        public static readonly QueryUserThirdPartySubscriptionTransactionsPlatform XBOX
            = new QueryUserThirdPartySubscriptionTransactionsPlatform("XBOX");


        public static implicit operator QueryUserThirdPartySubscriptionTransactionsPlatform(string value)
        {
            return NewValue(value);
        }

        public QueryUserThirdPartySubscriptionTransactionsPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}