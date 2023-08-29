// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Reward
    {
        private readonly IAccelByteSdk _sdk;

        public Reward(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryRewards.QueryRewardsBuilder QueryRewardsOp
        {
            get { return new Operation.QueryRewards.QueryRewardsBuilder(_sdk); }
        }
        public CreateReward.CreateRewardBuilder CreateRewardOp
        {
            get { return new Operation.CreateReward.CreateRewardBuilder(_sdk); }
        }
        public GetReward.GetRewardBuilder GetRewardOp
        {
            get { return new Operation.GetReward.GetRewardBuilder(_sdk); }
        }
        public DeleteReward.DeleteRewardBuilder DeleteRewardOp
        {
            get { return new Operation.DeleteReward.DeleteRewardBuilder(_sdk); }
        }
        public UpdateReward.UpdateRewardBuilder UpdateRewardOp
        {
            get { return new Operation.UpdateReward.UpdateRewardBuilder(_sdk); }
        }
        public PublicClaimUserReward.PublicClaimUserRewardBuilder PublicClaimUserRewardOp
        {
            get { return new Operation.PublicClaimUserReward.PublicClaimUserRewardBuilder(_sdk); }
        }
        public PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder PublicBulkClaimUserRewardsOp
        {
            get { return new Operation.PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder(_sdk); }
        }
        #endregion

        public List<Model.RewardInfo>? QueryRewards(QueryRewards input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? CreateReward(CreateReward input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? GetReward(GetReward input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteReward(DeleteReward input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RewardInfo? UpdateReward(UpdateReward input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableRewards? PublicClaimUserReward(PublicClaimUserReward input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ClaimableRewards<T1, T2>? PublicClaimUserReward<T1, T2>(PublicClaimUserReward input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClaimableRewards? PublicBulkClaimUserRewards(PublicBulkClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public Model.ClaimableRewards<T1, T2>? PublicBulkClaimUserRewards<T1, T2>(PublicBulkClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}