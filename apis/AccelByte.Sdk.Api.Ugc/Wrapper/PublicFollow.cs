// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicFollow
    {
        private readonly IAccelByteSdk _sdk;

        public PublicFollow(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetFollowedContent.GetFollowedContentBuilder GetFollowedContentOp
        {
            get { return new Operation.GetFollowedContent.GetFollowedContentBuilder(_sdk); }
        }
        public GetFollowedUsers.GetFollowedUsersBuilder GetFollowedUsersOp
        {
            get { return new Operation.GetFollowedUsers.GetFollowedUsersBuilder(_sdk); }
        }
        public UpdateUserFollowStatus.UpdateUserFollowStatusBuilder UpdateUserFollowStatusOp
        {
            get { return new Operation.UpdateUserFollowStatus.UpdateUserFollowStatusBuilder(_sdk); }
        }
        public GetPublicFollowers.GetPublicFollowersBuilder GetPublicFollowersOp
        {
            get { return new Operation.GetPublicFollowers.GetPublicFollowersBuilder(_sdk); }
        }
        public GetPublicFollowing.GetPublicFollowingBuilder GetPublicFollowingOp
        {
            get { return new Operation.GetPublicFollowing.GetPublicFollowingBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsPaginatedContentDownloadResponse? GetFollowedContent(GetFollowedContent input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetFollowedUsers(GetFollowedUsers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserFollowResponse? UpdateUserFollowStatus(UpdateUserFollowStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetPublicFollowers(GetPublicFollowers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetPublicFollowing(GetPublicFollowing input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}