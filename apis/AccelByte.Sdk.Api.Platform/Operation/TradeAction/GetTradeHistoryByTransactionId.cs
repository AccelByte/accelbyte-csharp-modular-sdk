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
    /// getTradeHistoryByTransactionId
    ///
    /// This API is used to fetch a specific trade history using transaction ID
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:TRADE, action=2 (REDA)
    ///   *  Returns : trade history based on transaction ID
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
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
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
                op.ParseResponse(
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

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            //do nothing since response code is "default".
        }
    }

}