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

using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class PlayerReward
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public PlayerReward(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public PlayerReward(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminClaimUsersRewards.AdminClaimUsersRewardsBuilder AdminClaimUsersRewardsOp
        {
            get
            {
                var opBuilder = new Operation.AdminClaimUsersRewards.AdminClaimUsersRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminClaimUserRewardsByGoalCode.AdminClaimUserRewardsByGoalCodeBuilder AdminClaimUserRewardsByGoalCodeOp
        {
            get
            {
                var opBuilder = new Operation.AdminClaimUserRewardsByGoalCode.AdminClaimUserRewardsByGoalCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetUserRewards.AdminGetUserRewardsBuilder AdminGetUserRewardsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetUserRewards.AdminGetUserRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminClaimUserRewards.AdminClaimUserRewardsBuilder AdminClaimUserRewardsOp
        {
            get
            {
                var opBuilder = new Operation.AdminClaimUserRewards.AdminClaimUserRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicClaimUserRewardsByGoalCode.PublicClaimUserRewardsByGoalCodeBuilder PublicClaimUserRewardsByGoalCodeOp
        {
            get
            {
                var opBuilder = new Operation.PublicClaimUserRewardsByGoalCode.PublicClaimUserRewardsByGoalCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUserRewards.PublicGetUserRewardsBuilder PublicGetUserRewardsOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserRewards.PublicGetUserRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicClaimUserRewards.PublicClaimUserRewardsBuilder PublicClaimUserRewardsOp
        {
            get
            {
                var opBuilder = new Operation.PublicClaimUserRewards.PublicClaimUserRewardsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminClaimUsersRewards.Response AdminClaimUsersRewards(AdminClaimUsersRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminClaimUsersRewards.Response> AdminClaimUsersRewardsAsync(AdminClaimUsersRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminClaimUserRewardsByGoalCode.Response AdminClaimUserRewardsByGoalCode(AdminClaimUserRewardsByGoalCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminClaimUserRewardsByGoalCode.Response> AdminClaimUserRewardsByGoalCodeAsync(AdminClaimUserRewardsByGoalCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminGetUserRewards.Response AdminGetUserRewards(AdminGetUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminGetUserRewards.Response> AdminGetUserRewardsAsync(AdminGetUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminClaimUserRewards.Response AdminClaimUserRewards(AdminClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminClaimUserRewards.Response> AdminClaimUserRewardsAsync(AdminClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicClaimUserRewardsByGoalCode.Response PublicClaimUserRewardsByGoalCode(PublicClaimUserRewardsByGoalCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicClaimUserRewardsByGoalCode.Response> PublicClaimUserRewardsByGoalCodeAsync(PublicClaimUserRewardsByGoalCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetUserRewards.Response PublicGetUserRewards(PublicGetUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetUserRewards.Response> PublicGetUserRewardsAsync(PublicGetUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicClaimUserRewards.Response PublicClaimUserRewards(PublicClaimUserRewards input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicClaimUserRewards.Response> PublicClaimUserRewardsAsync(PublicClaimUserRewards input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}