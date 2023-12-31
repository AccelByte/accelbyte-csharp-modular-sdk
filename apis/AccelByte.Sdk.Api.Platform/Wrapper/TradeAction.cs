// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class TradeAction
    {
        private readonly IAccelByteSdk _sdk;

        public TradeAction(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Commit.CommitBuilder CommitOp
        {
            get { return new Operation.Commit.CommitBuilder(_sdk); }
        }
        public GetTradeHistoryByCriteria.GetTradeHistoryByCriteriaBuilder GetTradeHistoryByCriteriaOp
        {
            get { return new Operation.GetTradeHistoryByCriteria.GetTradeHistoryByCriteriaBuilder(_sdk); }
        }
        public GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder GetTradeHistoryByTransactionIdOp
        {
            get { return new Operation.GetTradeHistoryByTransactionId.GetTradeHistoryByTransactionIdBuilder(_sdk); }
        }
        #endregion

        public Model.TradeChainActionHistoryInfo? Commit(Commit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.TradeChainActionHistoryInfo<T1>? Commit<T1>(Commit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TradeActionPagingSlicedResult? GetTradeHistoryByCriteria(GetTradeHistoryByCriteria input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TradeChainActionHistoryInfo? GetTradeHistoryByTransactionId(GetTradeHistoryByTransactionId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.TradeChainActionHistoryInfo<T1>? GetTradeHistoryByTransactionId<T1>(GetTradeHistoryByTransactionId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}