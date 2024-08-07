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
    /// getTradeHistoryByTransactionId
    ///
    /// This API is used to fetch a specific trade history using transaction ID
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : trade history based on transaction ID
    /// </summary>
    public class GetTradeHistoryByTransactionId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetTradeHistoryByTransactionIdBuilder Builder { get => new GetTradeHistoryByTransactionIdBuilder(); }

        public class GetTradeHistoryByTransactionIdBuilder
            : OperationBuilder<GetTradeHistoryByTransactionIdBuilder>
        {





            internal GetTradeHistoryByTransactionIdBuilder() { }

            internal GetTradeHistoryByTransactionIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetTradeHistoryByTransactionId Build(
                string namespace_,
                string transactionId
            )
            {
                GetTradeHistoryByTransactionId op = new GetTradeHistoryByTransactionId(this,
                    namespace_,
                    transactionId
                );

                op.SetBaseFields<GetTradeHistoryByTransactionIdBuilder>(this);
                return op;
            }

            public Model.TradeChainActionHistoryInfo? Execute(
                string namespace_,
                string transactionId
            )
            {
                GetTradeHistoryByTransactionId op = Build(
                    namespace_,
                    transactionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TradeChainActionHistoryInfo?> ExecuteAsync(
                string namespace_,
                string transactionId
            )
            {
                GetTradeHistoryByTransactionId op = Build(
                    namespace_,
                    transactionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.TradeChainActionHistoryInfo<T1>? Execute<T1>(
                string namespace_,
                string transactionId
            )
            {
                GetTradeHistoryByTransactionId op = Build(
                    namespace_,
                    transactionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.TradeChainActionHistoryInfo<T1>?> ExecuteAsync<T1>(
                string namespace_,
                string transactionId
            )
            {
                GetTradeHistoryByTransactionId op = Build(
                    namespace_,
                    transactionId
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

        private GetTradeHistoryByTransactionId(GetTradeHistoryByTransactionIdBuilder builder,
            string namespace_,
            string transactionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetTradeHistoryByTransactionId(
            string namespace_,
            string transactionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/trade/{transactionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.TradeChainActionHistoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.TradeChainActionHistoryInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TradeChainActionHistoryInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}