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

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Friends
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Friends(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Friends(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetUserFriendsUpdated.GetUserFriendsUpdatedBuilder GetUserFriendsUpdatedOp
        {
            get
            {
                var opBuilder = new Operation.GetUserFriendsUpdated.GetUserFriendsUpdatedBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserIncomingFriends.GetUserIncomingFriendsBuilder GetUserIncomingFriendsOp
        {
            get
            {
                var opBuilder = new Operation.GetUserIncomingFriends.GetUserIncomingFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserIncomingFriendsWithTime.GetUserIncomingFriendsWithTimeBuilder GetUserIncomingFriendsWithTimeOp
        {
            get
            {
                var opBuilder = new Operation.GetUserIncomingFriendsWithTime.GetUserIncomingFriendsWithTimeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserOutgoingFriends.GetUserOutgoingFriendsBuilder GetUserOutgoingFriendsOp
        {
            get
            {
                var opBuilder = new Operation.GetUserOutgoingFriends.GetUserOutgoingFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserOutgoingFriendsWithTime.GetUserOutgoingFriendsWithTimeBuilder GetUserOutgoingFriendsWithTimeOp
        {
            get
            {
                var opBuilder = new Operation.GetUserOutgoingFriendsWithTime.GetUserOutgoingFriendsWithTimeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetUserFriendsWithPlatform.GetUserFriendsWithPlatformBuilder GetUserFriendsWithPlatformOp
        {
            get
            {
                var opBuilder = new Operation.GetUserFriendsWithPlatform.GetUserFriendsWithPlatformBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserRequestFriend.UserRequestFriendBuilder UserRequestFriendOp
        {
            get
            {
                var opBuilder = new Operation.UserRequestFriend.UserRequestFriendBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserAcceptFriendRequest.UserAcceptFriendRequestBuilder UserAcceptFriendRequestOp
        {
            get
            {
                var opBuilder = new Operation.UserAcceptFriendRequest.UserAcceptFriendRequestBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserCancelFriendRequest.UserCancelFriendRequestBuilder UserCancelFriendRequestOp
        {
            get
            {
                var opBuilder = new Operation.UserCancelFriendRequest.UserCancelFriendRequestBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserRejectFriendRequest.UserRejectFriendRequestBuilder UserRejectFriendRequestOp
        {
            get
            {
                var opBuilder = new Operation.UserRejectFriendRequest.UserRejectFriendRequestBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserGetFriendshipStatus.UserGetFriendshipStatusBuilder UserGetFriendshipStatusOp
        {
            get
            {
                var opBuilder = new Operation.UserGetFriendshipStatus.UserGetFriendshipStatusBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UserUnfriendRequest.UserUnfriendRequestBuilder UserUnfriendRequestOp
        {
            get
            {
                var opBuilder = new Operation.UserUnfriendRequest.UserUnfriendRequestBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AddFriendsWithoutConfirmation.AddFriendsWithoutConfirmationBuilder AddFriendsWithoutConfirmationOp
        {
            get
            {
                var opBuilder = new Operation.AddFriendsWithoutConfirmation.AddFriendsWithoutConfirmationBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public BulkDeleteFriends.BulkDeleteFriendsBuilder BulkDeleteFriendsOp
        {
            get
            {
                var opBuilder = new Operation.BulkDeleteFriends.BulkDeleteFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public SyncNativeFriends.SyncNativeFriendsBuilder SyncNativeFriendsOp
        {
            get
            {
                var opBuilder = new Operation.SyncNativeFriends.SyncNativeFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetListOfFriends.GetListOfFriendsBuilder GetListOfFriendsOp
        {
            get
            {
                var opBuilder = new Operation.GetListOfFriends.GetListOfFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetIncomingFriendRequests.GetIncomingFriendRequestsBuilder GetIncomingFriendRequestsOp
        {
            get
            {
                var opBuilder = new Operation.GetIncomingFriendRequests.GetIncomingFriendRequestsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminListFriendsOfFriends.AdminListFriendsOfFriendsBuilder AdminListFriendsOfFriendsOp
        {
            get
            {
                var opBuilder = new Operation.AdminListFriendsOfFriends.AdminListFriendsOfFriendsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetOutgoingFriendRequests.GetOutgoingFriendRequestsBuilder GetOutgoingFriendRequestsOp
        {
            get
            {
                var opBuilder = new Operation.GetOutgoingFriendRequests.GetOutgoingFriendRequestsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public List<Model.ModelGetUserFriendsResponse>? GetUserFriendsUpdated(GetUserFriendsUpdated input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelGetUserFriendsResponse>?> GetUserFriendsUpdatedAsync(GetUserFriendsUpdated input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserIncomingFriendsResponse>? GetUserIncomingFriends(GetUserIncomingFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelGetUserIncomingFriendsResponse>?> GetUserIncomingFriendsAsync(GetUserIncomingFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelLoadIncomingFriendsWithTimeResponse>? GetUserIncomingFriendsWithTime(GetUserIncomingFriendsWithTime input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelLoadIncomingFriendsWithTimeResponse>?> GetUserIncomingFriendsWithTimeAsync(GetUserIncomingFriendsWithTime input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserOutgoingFriendsResponse>? GetUserOutgoingFriends(GetUserOutgoingFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelGetUserOutgoingFriendsResponse>?> GetUserOutgoingFriendsAsync(GetUserOutgoingFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelLoadOutgoingFriendsWithTimeResponse>? GetUserOutgoingFriendsWithTime(GetUserOutgoingFriendsWithTime input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelLoadOutgoingFriendsWithTimeResponse>?> GetUserOutgoingFriendsWithTimeAsync(GetUserOutgoingFriendsWithTime input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListBulkUserPlatformsResponse? GetUserFriendsWithPlatform(GetUserFriendsWithPlatform input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListBulkUserPlatformsResponse?> GetUserFriendsWithPlatformAsync(GetUserFriendsWithPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UserRequestFriend(UserRequestFriend input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UserRequestFriendAsync(UserRequestFriend input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UserAcceptFriendRequest(UserAcceptFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UserAcceptFriendRequestAsync(UserAcceptFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UserCancelFriendRequest(UserCancelFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UserCancelFriendRequestAsync(UserCancelFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UserRejectFriendRequest(UserRejectFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UserRejectFriendRequestAsync(UserRejectFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserGetFriendshipStatusResponse? UserGetFriendshipStatus(UserGetFriendshipStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelUserGetFriendshipStatusResponse?> UserGetFriendshipStatusAsync(UserGetFriendshipStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void UserUnfriendRequest(UserUnfriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task UserUnfriendRequestAsync(UserUnfriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AddFriendsWithoutConfirmation(AddFriendsWithoutConfirmation input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AddFriendsWithoutConfirmationAsync(AddFriendsWithoutConfirmation input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBulkFriendsResponse? BulkDeleteFriends(BulkDeleteFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelBulkFriendsResponse?> BulkDeleteFriendsAsync(BulkDeleteFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelNativeFriendSyncResponse>? SyncNativeFriends(SyncNativeFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.ModelNativeFriendSyncResponse>?> SyncNativeFriendsAsync(SyncNativeFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetFriendsResponse? GetListOfFriends(GetListOfFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelGetFriendsResponse?> GetListOfFriendsAsync(GetListOfFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLoadIncomingFriendsWithTimeResponse? GetIncomingFriendRequests(GetIncomingFriendRequests input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelLoadIncomingFriendsWithTimeResponse?> GetIncomingFriendRequestsAsync(GetIncomingFriendRequests input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelFriendshipConnectionResponse? AdminListFriendsOfFriends(AdminListFriendsOfFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelFriendshipConnectionResponse?> AdminListFriendsOfFriendsAsync(AdminListFriendsOfFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLoadOutgoingFriendsWithTimeResponse? GetOutgoingFriendRequests(GetOutgoingFriendRequests input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelLoadOutgoingFriendsWithTimeResponse?> GetOutgoingFriendRequestsAsync(GetOutgoingFriendRequests input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}