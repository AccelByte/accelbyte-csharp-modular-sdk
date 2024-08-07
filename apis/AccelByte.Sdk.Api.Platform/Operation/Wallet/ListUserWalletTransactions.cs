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
    /// listUserWalletTransactions
    ///
    /// List user wallet transactions ordered by create time desc.
    /// Other detail info:
    /// 
    ///   * Returns : wallet transaction info
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class ListUserWalletTransactions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListUserWalletTransactionsBuilder Builder { get => new ListUserWalletTransactionsBuilder(); }

        public class ListUserWalletTransactionsBuilder
            : OperationBuilder<ListUserWalletTransactionsBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal ListUserWalletTransactionsBuilder() { }

            internal ListUserWalletTransactionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListUserWalletTransactionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListUserWalletTransactionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public ListUserWalletTransactions Build(
                string namespace_,
                string userId,
                string walletId
            )
            {
                ListUserWalletTransactions op = new ListUserWalletTransactions(this,
                    namespace_,
                    userId,
                    walletId
                );

                op.SetBaseFields<ListUserWalletTransactionsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.DetailedWalletTransactionPagingSlicedResult? Execute(
                string namespace_,
                string userId,
                string walletId
            )
            {
                ListUserWalletTransactions op = Build(
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.DetailedWalletTransactionPagingSlicedResult?> ExecuteAsync(
                string namespace_,
                string userId,
                string walletId
            )
            {
                ListUserWalletTransactions op = Build(
                    namespace_,
                    userId,
                    walletId
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

        private ListUserWalletTransactions(ListUserWalletTransactionsBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListUserWalletTransactions(
            string namespace_,
            string userId,
            string walletId,
            int? limit,
            int? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/transactions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.DetailedWalletTransactionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DetailedWalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DetailedWalletTransactionPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}