// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardConfiguration
    {
        private readonly AccelByteSDK _sdk;

        public LeaderboardConfiguration(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetLeaderboardConfigurationsAdminV1.GetLeaderboardConfigurationsAdminV1Builder GetLeaderboardConfigurationsAdminV1Op
        {
            get { return Operation.GetLeaderboardConfigurationsAdminV1.Builder.SetWrapperObject(this); }
        }
        public CreateLeaderboardConfigurationAdminV1.CreateLeaderboardConfigurationAdminV1Builder CreateLeaderboardConfigurationAdminV1Op
        {
            get { return Operation.CreateLeaderboardConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteBulkLeaderboardConfigurationAdminV1.DeleteBulkLeaderboardConfigurationAdminV1Builder DeleteBulkLeaderboardConfigurationAdminV1Op
        {
            get { return Operation.DeleteBulkLeaderboardConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetLeaderboardConfigurationAdminV1.GetLeaderboardConfigurationAdminV1Builder GetLeaderboardConfigurationAdminV1Op
        {
            get { return Operation.GetLeaderboardConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public UpdateLeaderboardConfigurationAdminV1.UpdateLeaderboardConfigurationAdminV1Builder UpdateLeaderboardConfigurationAdminV1Op
        {
            get { return Operation.UpdateLeaderboardConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public DeleteLeaderboardConfigurationAdminV1.DeleteLeaderboardConfigurationAdminV1Builder DeleteLeaderboardConfigurationAdminV1Op
        {
            get { return Operation.DeleteLeaderboardConfigurationAdminV1.Builder.SetWrapperObject(this); }
        }
        public GetLeaderboardConfigurationsPublicV1.GetLeaderboardConfigurationsPublicV1Builder GetLeaderboardConfigurationsPublicV1Op
        {
            get { return Operation.GetLeaderboardConfigurationsPublicV1.Builder.SetWrapperObject(this); }
        }
        public CreateLeaderboardConfigurationPublicV1.CreateLeaderboardConfigurationPublicV1Builder CreateLeaderboardConfigurationPublicV1Op
        {
            get { return Operation.CreateLeaderboardConfigurationPublicV1.Builder.SetWrapperObject(this); }
        }
        public GetLeaderboardConfigurationsPublicV2.GetLeaderboardConfigurationsPublicV2Builder GetLeaderboardConfigurationsPublicV2Op
        {
            get { return Operation.GetLeaderboardConfigurationsPublicV2.Builder.SetWrapperObject(this); }
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
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationAdminV1(CreateLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

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
        public Model.ModelsGetLeaderboardConfigResp? GetLeaderboardConfigurationAdminV1(GetLeaderboardConfigurationAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

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
        public void DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1 input) {
            var response = _sdk.RunRequest(input);

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
        public Model.ModelsLeaderboardConfigReq? CreateLeaderboardConfigurationPublicV1(CreateLeaderboardConfigurationPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

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
    }
}