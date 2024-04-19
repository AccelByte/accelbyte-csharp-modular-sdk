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

using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Api.Seasonpass.Wrapper
{
    public class Reward
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Reward(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Reward(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public QueryRewards.QueryRewardsBuilder QueryRewardsOp
        {
            get
            {
                var opBuilder = new Operation.QueryRewards.QueryRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreateReward.CreateRewardBuilder CreateRewardOp
        {
            get
            {
                var opBuilder = new Operation.CreateReward.CreateRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetReward.GetRewardBuilder GetRewardOp
        {
            get
            {
                var opBuilder = new Operation.GetReward.GetRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteReward.DeleteRewardBuilder DeleteRewardOp
        {
            get
            {
                var opBuilder = new Operation.DeleteReward.DeleteRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateReward.UpdateRewardBuilder UpdateRewardOp
        {
            get
            {
                var opBuilder = new Operation.UpdateReward.UpdateRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicClaimUserReward.PublicClaimUserRewardBuilder PublicClaimUserRewardOp
        {
            get
            {
                var opBuilder = new Operation.PublicClaimUserReward.PublicClaimUserRewardBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder PublicBulkClaimUserRewardsOp
        {
            get
            {
                var opBuilder = new Operation.PublicBulkClaimUserRewards.PublicBulkClaimUserRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
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
        public async Task<List<Model.RewardInfo>?> QueryRewardsAsync(QueryRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.RewardInfo?> CreateRewardAsync(CreateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.RewardInfo?> GetRewardAsync(GetReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task DeleteRewardAsync(DeleteReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.RewardInfo?> UpdateRewardAsync(UpdateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ClaimableRewards?> PublicClaimUserRewardAsync(PublicClaimUserReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ClaimableRewards<T1, T2>?> PublicClaimUserRewardAsync<T1, T2>(PublicClaimUserReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ClaimableRewards?> PublicBulkClaimUserRewardsAsync(PublicBulkClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ClaimableRewards<T1, T2>?> PublicBulkClaimUserRewardsAsync<T1, T2>(PublicBulkClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}