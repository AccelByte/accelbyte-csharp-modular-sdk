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
    public class LeaderboardConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        public LeaderboardConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetLeaderboardConfigurationsAdminV1.GetLeaderboardConfigurationsAdminV1Builder GetLeaderboardConfigurationsAdminV1Op
        {
            get { return new Operation.GetLeaderboardConfigurationsAdminV1.GetLeaderboardConfigurationsAdminV1Builder(_sdk); }
        }
        public CreateLeaderboardConfigurationAdminV1.CreateLeaderboardConfigurationAdminV1Builder CreateLeaderboardConfigurationAdminV1Op
        {
            get { return new Operation.CreateLeaderboardConfigurationAdminV1.CreateLeaderboardConfigurationAdminV1Builder(_sdk); }
        }
        public DeleteBulkLeaderboardConfigurationAdminV1.DeleteBulkLeaderboardConfigurationAdminV1Builder DeleteBulkLeaderboardConfigurationAdminV1Op
        {
            get { return new Operation.DeleteBulkLeaderboardConfigurationAdminV1.DeleteBulkLeaderboardConfigurationAdminV1Builder(_sdk); }
        }
        public GetLeaderboardConfigurationAdminV1.GetLeaderboardConfigurationAdminV1Builder GetLeaderboardConfigurationAdminV1Op
        {
            get { return new Operation.GetLeaderboardConfigurationAdminV1.GetLeaderboardConfigurationAdminV1Builder(_sdk); }
        }
        public UpdateLeaderboardConfigurationAdminV1.UpdateLeaderboardConfigurationAdminV1Builder UpdateLeaderboardConfigurationAdminV1Op
        {
            get { return new Operation.UpdateLeaderboardConfigurationAdminV1.UpdateLeaderboardConfigurationAdminV1Builder(_sdk); }
        }
        public DeleteLeaderboardConfigurationAdminV1.DeleteLeaderboardConfigurationAdminV1Builder DeleteLeaderboardConfigurationAdminV1Op
        {
            get { return new Operation.DeleteLeaderboardConfigurationAdminV1.DeleteLeaderboardConfigurationAdminV1Builder(_sdk); }
        }
        public HardDeleteLeaderboardAdminV1.HardDeleteLeaderboardAdminV1Builder HardDeleteLeaderboardAdminV1Op
        {
            get { return new Operation.HardDeleteLeaderboardAdminV1.HardDeleteLeaderboardAdminV1Builder(_sdk); }
        }
        public GetLeaderboardConfigurationsPublicV1.GetLeaderboardConfigurationsPublicV1Builder GetLeaderboardConfigurationsPublicV1Op
        {
            get { return new Operation.GetLeaderboardConfigurationsPublicV1.GetLeaderboardConfigurationsPublicV1Builder(_sdk); }
        }
        public CreateLeaderboardConfigurationPublicV1.CreateLeaderboardConfigurationPublicV1Builder CreateLeaderboardConfigurationPublicV1Op
        {
            get { return new Operation.CreateLeaderboardConfigurationPublicV1.CreateLeaderboardConfigurationPublicV1Builder(_sdk); }
        }
        public GetLeaderboardConfigurationsPublicV2.GetLeaderboardConfigurationsPublicV2Builder GetLeaderboardConfigurationsPublicV2Op
        {
            get { return new Operation.GetLeaderboardConfigurationsPublicV2.GetLeaderboardConfigurationsPublicV2Builder(_sdk); }
        }
        #endregion

        public Model.ModelsGetAllLeaderboardConfigsResp? GetLeaderboardConfigurationsAdminV1(GetLeaderboardConfigurationsAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllLeaderboardConfigsResp?> GetLeaderboardConfigurationsAdminV1Async(GetLeaderboardConfigurationsAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationAdminV1(CreateLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsLeaderboardConfigReq?> CreateLeaderboardConfigurationAdminV1Async(CreateLeaderboardConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDeleteBulkLeaderboardsResp? DeleteBulkLeaderboardConfigurationAdminV1(DeleteBulkLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsDeleteBulkLeaderboardsResp?> DeleteBulkLeaderboardConfigurationAdminV1Async(DeleteBulkLeaderboardConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardConfigResp? GetLeaderboardConfigurationAdminV1(GetLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardConfigResp?> GetLeaderboardConfigurationAdminV1Async(GetLeaderboardConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardConfigResp? UpdateLeaderboardConfigurationAdminV1(UpdateLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardConfigResp?> UpdateLeaderboardConfigurationAdminV1Async(UpdateLeaderboardConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteLeaderboardConfigurationAdminV1Async(DeleteLeaderboardConfigurationAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void HardDeleteLeaderboardAdminV1(HardDeleteLeaderboardAdminV1 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task HardDeleteLeaderboardAdminV1Async(HardDeleteLeaderboardAdminV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetAllLeaderboardConfigsPublicResp? GetLeaderboardConfigurationsPublicV1(GetLeaderboardConfigurationsPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetAllLeaderboardConfigsPublicResp?> GetLeaderboardConfigurationsPublicV1Async(GetLeaderboardConfigurationsPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationPublicV1(CreateLeaderboardConfigurationPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsLeaderboardConfigReq?> CreateLeaderboardConfigurationPublicV1Async(CreateLeaderboardConfigurationPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.V2GetAllLeaderboardConfigsPublicResp? GetLeaderboardConfigurationsPublicV2(GetLeaderboardConfigurationsPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.V2GetAllLeaderboardConfigsPublicResp?> GetLeaderboardConfigurationsPublicV2Async(GetLeaderboardConfigurationsPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}