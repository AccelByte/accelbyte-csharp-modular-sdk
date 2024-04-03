// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Fulfillment
    {
        private readonly IAccelByteSdk _sdk;

        public Fulfillment(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder QueryFulfillmentHistoriesOp
        {
            get { return new Operation.QueryFulfillmentHistories.QueryFulfillmentHistoriesBuilder(_sdk); }
        }
        public FulfillItem.FulfillItemBuilder FulfillItemOp
        {
            get { return new Operation.FulfillItem.FulfillItemBuilder(_sdk); }
        }
        public RedeemCode.RedeemCodeBuilder RedeemCodeOp
        {
            get { return new Operation.RedeemCode.RedeemCodeBuilder(_sdk); }
        }
        public PreCheckFulfillItem.PreCheckFulfillItemBuilder PreCheckFulfillItemOp
        {
            get { return new Operation.PreCheckFulfillItem.PreCheckFulfillItemBuilder(_sdk); }
        }
        public FulfillRewards.FulfillRewardsBuilder FulfillRewardsOp
        {
            get { return new Operation.FulfillRewards.FulfillRewardsBuilder(_sdk); }
        }
        public PublicRedeemCode.PublicRedeemCodeBuilder PublicRedeemCodeOp
        {
            get { return new Operation.PublicRedeemCode.PublicRedeemCodeBuilder(_sdk); }
        }
        public FulfillRewardsV2.FulfillRewardsV2Builder FulfillRewardsV2Op
        {
            get { return new Operation.FulfillRewardsV2.FulfillRewardsV2Builder(_sdk); }
        }
        #endregion

        public Model.FulfillmentHistoryPagingSlicedResult? QueryFulfillmentHistories(QueryFulfillmentHistories input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentHistoryPagingSlicedResult?> QueryFulfillmentHistoriesAsync(QueryFulfillmentHistories input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillItem(FulfillItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentResult?> FulfillItemAsync(FulfillItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? RedeemCode(RedeemCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentResult?> RedeemCodeAsync(RedeemCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.FulfillmentItem>? PreCheckFulfillItem(PreCheckFulfillItem input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.FulfillmentItem>?> PreCheckFulfillItemAsync(PreCheckFulfillItem input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void FulfillRewards(FulfillRewards input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task FulfillRewardsAsync(FulfillRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? PublicRedeemCode(PublicRedeemCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentResult?> PublicRedeemCodeAsync(PublicRedeemCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.FulfillmentResult? FulfillRewardsV2(FulfillRewardsV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.FulfillmentResult?> FulfillRewardsV2Async(FulfillRewardsV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}