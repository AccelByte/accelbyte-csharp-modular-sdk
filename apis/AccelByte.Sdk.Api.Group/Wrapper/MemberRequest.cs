// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class MemberRequest
    {
        private readonly IAccelByteSdk _sdk;

        public MemberRequest(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder GetGroupJoinRequestPublicV1Op
        {
            get { return new Operation.GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder(_sdk); }
        }
        public GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder GetGroupInvitationRequestPublicV1Op
        {
            get { return new Operation.GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder(_sdk); }
        }
        public GetGroupInviteRequestPublicV2.GetGroupInviteRequestPublicV2Builder GetGroupInviteRequestPublicV2Op
        {
            get { return new Operation.GetGroupInviteRequestPublicV2.GetGroupInviteRequestPublicV2Builder(_sdk); }
        }
        public GetGroupJoinRequestPublicV2.GetGroupJoinRequestPublicV2Builder GetGroupJoinRequestPublicV2Op
        {
            get { return new Operation.GetGroupJoinRequestPublicV2.GetGroupJoinRequestPublicV2Builder(_sdk); }
        }
        public GetMyGroupJoinRequestV2.GetMyGroupJoinRequestV2Builder GetMyGroupJoinRequestV2Op
        {
            get { return new Operation.GetMyGroupJoinRequestV2.GetMyGroupJoinRequestV2Builder(_sdk); }
        }
        #endregion

        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupInviteRequestPublicV2(GetGroupInviteRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetGroupJoinRequestPublicV2(GetGroupJoinRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRequestsListResponseV1? GetMyGroupJoinRequestV2(GetMyGroupJoinRequestV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}