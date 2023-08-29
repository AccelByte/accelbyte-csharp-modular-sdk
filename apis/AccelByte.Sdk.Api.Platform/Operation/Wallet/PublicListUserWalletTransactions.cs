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
    /// publicListUserWalletTransactions
    ///
    /// List wallet transactions by currency code ordered by create time desc.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:WALLET", action=2 (READ)
    ///   *  Returns : currency transaction info
    /// </summary>
    public class PublicListUserWalletTransactions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListUserWalletTransactionsBuilder Builder { get => new PublicListUserWalletTransactionsBuilder(); }

        public class PublicListUserWalletTransactionsBuilder
            : OperationBuilder<PublicListUserWalletTransactionsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal PublicListUserWalletTransactionsBuilder() { }

            internal PublicListUserWalletTransactionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicListUserWalletTransactionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListUserWalletTransactionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicListUserWalletTransactions Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PublicListUserWalletTransactions op = new PublicListUserWalletTransactions(this,
                    currencyCode,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.WalletTransactionPagingSlicedResult? Execute(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PublicListUserWalletTransactions op = Build(
                    currencyCode,
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

        private PublicListUserWalletTransactions(PublicListUserWalletTransactionsBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListUserWalletTransactions(
            string currencyCode,            
            string namespace_,            
            string userId,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.WalletTransactionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}