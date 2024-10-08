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

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardDataV3
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public LeaderboardDataV3(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public LeaderboardDataV3(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetAllTimeLeaderboardRankingAdminV3.GetAllTimeLeaderboardRankingAdminV3Builder GetAllTimeLeaderboardRankingAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.GetAllTimeLeaderboardRankingAdminV3.GetAllTimeLeaderboardRankingAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetCurrentCycleLeaderboardRankingAdminV3.GetCurrentCycleLeaderboardRankingAdminV3Builder GetCurrentCycleLeaderboardRankingAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.GetCurrentCycleLeaderboardRankingAdminV3.GetCurrentCycleLeaderboardRankingAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteAllUserRankingByCycleIdAdminV3.DeleteAllUserRankingByCycleIdAdminV3Builder DeleteAllUserRankingByCycleIdAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.DeleteAllUserRankingByCycleIdAdminV3.DeleteAllUserRankingByCycleIdAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteUserRankingByCycleIdAdminV3.DeleteUserRankingByCycleIdAdminV3Builder DeleteUserRankingByCycleIdAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.DeleteUserRankingByCycleIdAdminV3.DeleteUserRankingByCycleIdAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteUserRankingByLeaderboardCodeAdminV3.DeleteUserRankingByLeaderboardCodeAdminV3Builder DeleteUserRankingByLeaderboardCodeAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.DeleteUserRankingByLeaderboardCodeAdminV3.DeleteUserRankingByLeaderboardCodeAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserRankingAdminV3.GetUserRankingAdminV3Builder GetUserRankingAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.GetUserRankingAdminV3.GetUserRankingAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteUserRankingAdminV3.DeleteUserRankingAdminV3Builder DeleteUserRankingAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.DeleteUserRankingAdminV3.DeleteUserRankingAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DeleteUserRankingsAdminV3.DeleteUserRankingsAdminV3Builder DeleteUserRankingsAdminV3Op
        {
            get
            {
                var opBuilder = new Operation.DeleteUserRankingsAdminV3.DeleteUserRankingsAdminV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetAllTimeLeaderboardRankingPublicV3.GetAllTimeLeaderboardRankingPublicV3Builder GetAllTimeLeaderboardRankingPublicV3Op
        {
            get
            {
                var opBuilder = new Operation.GetAllTimeLeaderboardRankingPublicV3.GetAllTimeLeaderboardRankingPublicV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetCurrentCycleLeaderboardRankingPublicV3.GetCurrentCycleLeaderboardRankingPublicV3Builder GetCurrentCycleLeaderboardRankingPublicV3Op
        {
            get
            {
                var opBuilder = new Operation.GetCurrentCycleLeaderboardRankingPublicV3.GetCurrentCycleLeaderboardRankingPublicV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public BulkGetUsersRankingPublicV3.BulkGetUsersRankingPublicV3Builder BulkGetUsersRankingPublicV3Op
        {
            get
            {
                var opBuilder = new Operation.BulkGetUsersRankingPublicV3.BulkGetUsersRankingPublicV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserRankingPublicV3.GetUserRankingPublicV3Builder GetUserRankingPublicV3Op
        {
            get
            {
                var opBuilder = new Operation.GetUserRankingPublicV3.GetUserRankingPublicV3Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingAdminV3(GetAllTimeLeaderboardRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetAllTimeLeaderboardRankingAdminV3Async(GetAllTimeLeaderboardRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentCycleLeaderboardRankingAdminV3(GetCurrentCycleLeaderboardRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetCurrentCycleLeaderboardRankingAdminV3Async(GetCurrentCycleLeaderboardRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteAllUserRankingByCycleIdAdminV3(DeleteAllUserRankingByCycleIdAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteAllUserRankingByCycleIdAdminV3Async(DeleteAllUserRankingByCycleIdAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingByCycleIdAdminV3(DeleteUserRankingByCycleIdAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingByCycleIdAdminV3Async(DeleteUserRankingByCycleIdAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingByLeaderboardCodeAdminV3(DeleteUserRankingByLeaderboardCodeAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingByLeaderboardCodeAdminV3Async(DeleteUserRankingByLeaderboardCodeAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponseV3? GetUserRankingAdminV3(GetUserRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUserRankingResponseV3?> GetUserRankingAdminV3Async(GetUserRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingAdminV3(DeleteUserRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingAdminV3Async(DeleteUserRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingsAdminV3(DeleteUserRankingsAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingsAdminV3Async(DeleteUserRankingsAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingPublicV3(GetAllTimeLeaderboardRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetAllTimeLeaderboardRankingPublicV3Async(GetAllTimeLeaderboardRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentCycleLeaderboardRankingPublicV3(GetCurrentCycleLeaderboardRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetCurrentCycleLeaderboardRankingPublicV3Async(GetCurrentCycleLeaderboardRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkUserRankingResponseV3? BulkGetUsersRankingPublicV3(BulkGetUsersRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkUserRankingResponseV3?> BulkGetUsersRankingPublicV3Async(BulkGetUsersRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponseV3? GetUserRankingPublicV3(GetUserRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUserRankingResponseV3?> GetUserRankingPublicV3Async(GetUserRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}