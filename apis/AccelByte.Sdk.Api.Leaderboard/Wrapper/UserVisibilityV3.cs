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
    public class UserVisibilityV3
    {
        private readonly IAccelByteSdk _sdk;

        public UserVisibilityV3(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetHiddenUsersV3.GetHiddenUsersV3Builder GetHiddenUsersV3Op
        {
            get { return new Operation.GetHiddenUsersV3.GetHiddenUsersV3Builder(_sdk); }
        }
        public GetUserVisibilityStatusV3.GetUserVisibilityStatusV3Builder GetUserVisibilityStatusV3Op
        {
            get { return new Operation.GetUserVisibilityStatusV3.GetUserVisibilityStatusV3Builder(_sdk); }
        }
        public SetUserLeaderboardVisibilityV3.SetUserLeaderboardVisibilityV3Builder SetUserLeaderboardVisibilityV3Op
        {
            get { return new Operation.SetUserLeaderboardVisibilityV3.SetUserLeaderboardVisibilityV3Builder(_sdk); }
        }
        public SetUserVisibilityV3.SetUserVisibilityV3Builder SetUserVisibilityV3Op
        {
            get { return new Operation.SetUserVisibilityV3.SetUserVisibilityV3Builder(_sdk); }
        }
        #endregion

        public Model.ModelsGetHiddenUserResponse? GetHiddenUsersV3(GetHiddenUsersV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetHiddenUserResponse?> GetHiddenUsersV3Async(GetHiddenUsersV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? GetUserVisibilityStatusV3(GetUserVisibilityStatusV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> GetUserVisibilityStatusV3Async(GetUserVisibilityStatusV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserLeaderboardVisibilityV3(SetUserLeaderboardVisibilityV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> SetUserLeaderboardVisibilityV3Async(SetUserLeaderboardVisibilityV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserVisibilityV3(SetUserVisibilityV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> SetUserVisibilityV3Async(SetUserVisibilityV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}