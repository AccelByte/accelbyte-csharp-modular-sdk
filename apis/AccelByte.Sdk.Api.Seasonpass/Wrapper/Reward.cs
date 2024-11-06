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

        public QueryRewards.Response QueryRewards(QueryRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryRewards.Response> QueryRewardsAsync(QueryRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CreateReward.Response CreateReward(CreateReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreateReward.Response> CreateRewardAsync(CreateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetReward.Response GetReward(GetReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetReward.Response> GetRewardAsync(GetReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DeleteReward.Response DeleteReward(DeleteReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DeleteReward.Response> DeleteRewardAsync(DeleteReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateReward.Response UpdateReward(UpdateReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateReward.Response> UpdateRewardAsync(UpdateReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicClaimUserReward.Response PublicClaimUserReward(PublicClaimUserReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicClaimUserReward.Response> PublicClaimUserRewardAsync(PublicClaimUserReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicClaimUserReward.Response<T1, T2> PublicClaimUserReward<T1, T2>(PublicClaimUserReward input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicClaimUserReward.Response<T1, T2>> PublicClaimUserRewardAsync<T1, T2>(PublicClaimUserReward input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicBulkClaimUserRewards.Response PublicBulkClaimUserRewards(PublicBulkClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicBulkClaimUserRewards.Response> PublicBulkClaimUserRewardsAsync(PublicBulkClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public PublicBulkClaimUserRewards.Response<T1, T2> PublicBulkClaimUserRewards<T1, T2>(PublicBulkClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicBulkClaimUserRewards.Response<T1, T2>> PublicBulkClaimUserRewardsAsync<T1, T2>(PublicBulkClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}