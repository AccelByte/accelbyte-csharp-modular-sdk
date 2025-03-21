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

        public GetUserFriendsUpdated.Response GetUserFriendsUpdated(GetUserFriendsUpdated input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserFriendsUpdated.Response> GetUserFriendsUpdatedAsync(GetUserFriendsUpdated input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserIncomingFriends.Response GetUserIncomingFriends(GetUserIncomingFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserIncomingFriends.Response> GetUserIncomingFriendsAsync(GetUserIncomingFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserIncomingFriendsWithTime.Response GetUserIncomingFriendsWithTime(GetUserIncomingFriendsWithTime input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserIncomingFriendsWithTime.Response> GetUserIncomingFriendsWithTimeAsync(GetUserIncomingFriendsWithTime input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserOutgoingFriends.Response GetUserOutgoingFriends(GetUserOutgoingFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserOutgoingFriends.Response> GetUserOutgoingFriendsAsync(GetUserOutgoingFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserOutgoingFriendsWithTime.Response GetUserOutgoingFriendsWithTime(GetUserOutgoingFriendsWithTime input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserOutgoingFriendsWithTime.Response> GetUserOutgoingFriendsWithTimeAsync(GetUserOutgoingFriendsWithTime input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetUserFriendsWithPlatform.Response GetUserFriendsWithPlatform(GetUserFriendsWithPlatform input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserFriendsWithPlatform.Response> GetUserFriendsWithPlatformAsync(GetUserFriendsWithPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserRequestFriend.Response UserRequestFriend(UserRequestFriend input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserRequestFriend.Response> UserRequestFriendAsync(UserRequestFriend input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserAcceptFriendRequest.Response UserAcceptFriendRequest(UserAcceptFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserAcceptFriendRequest.Response> UserAcceptFriendRequestAsync(UserAcceptFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserCancelFriendRequest.Response UserCancelFriendRequest(UserCancelFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserCancelFriendRequest.Response> UserCancelFriendRequestAsync(UserCancelFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserRejectFriendRequest.Response UserRejectFriendRequest(UserRejectFriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserRejectFriendRequest.Response> UserRejectFriendRequestAsync(UserRejectFriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserGetFriendshipStatus.Response UserGetFriendshipStatus(UserGetFriendshipStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserGetFriendshipStatus.Response> UserGetFriendshipStatusAsync(UserGetFriendshipStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UserUnfriendRequest.Response UserUnfriendRequest(UserUnfriendRequest input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UserUnfriendRequest.Response> UserUnfriendRequestAsync(UserUnfriendRequest input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AddFriendsWithoutConfirmation.Response AddFriendsWithoutConfirmation(AddFriendsWithoutConfirmation input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AddFriendsWithoutConfirmation.Response> AddFriendsWithoutConfirmationAsync(AddFriendsWithoutConfirmation input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public BulkDeleteFriends.Response BulkDeleteFriends(BulkDeleteFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkDeleteFriends.Response> BulkDeleteFriendsAsync(BulkDeleteFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public SyncNativeFriends.Response SyncNativeFriends(SyncNativeFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<SyncNativeFriends.Response> SyncNativeFriendsAsync(SyncNativeFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetListOfFriends.Response GetListOfFriends(GetListOfFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetListOfFriends.Response> GetListOfFriendsAsync(GetListOfFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetIncomingFriendRequests.Response GetIncomingFriendRequests(GetIncomingFriendRequests input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetIncomingFriendRequests.Response> GetIncomingFriendRequestsAsync(GetIncomingFriendRequests input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminListFriendsOfFriends.Response AdminListFriendsOfFriends(AdminListFriendsOfFriends input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminListFriendsOfFriends.Response> AdminListFriendsOfFriendsAsync(AdminListFriendsOfFriends input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetOutgoingFriendRequests.Response GetOutgoingFriendRequests(GetOutgoingFriendRequests input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetOutgoingFriendRequests.Response> GetOutgoingFriendRequestsAsync(GetOutgoingFriendRequests input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}