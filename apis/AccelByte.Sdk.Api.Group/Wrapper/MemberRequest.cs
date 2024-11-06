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

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class MemberRequest
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public MemberRequest(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public MemberRequest(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder GetGroupJoinRequestPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupJoinRequestPublicV1.GetGroupJoinRequestPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder GetGroupInvitationRequestPublicV1Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupInvitationRequestPublicV1.GetGroupInvitationRequestPublicV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGroupInviteRequestPublicV2.GetGroupInviteRequestPublicV2Builder GetGroupInviteRequestPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupInviteRequestPublicV2.GetGroupInviteRequestPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetGroupJoinRequestPublicV2.GetGroupJoinRequestPublicV2Builder GetGroupJoinRequestPublicV2Op
        {
            get
            {
                var opBuilder = new Operation.GetGroupJoinRequestPublicV2.GetGroupJoinRequestPublicV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public GetMyGroupJoinRequestV2.GetMyGroupJoinRequestV2Builder GetMyGroupJoinRequestV2Op
        {
            get
            {
                var opBuilder = new Operation.GetMyGroupJoinRequestV2.GetMyGroupJoinRequestV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public GetGroupJoinRequestPublicV1.Response GetGroupJoinRequestPublicV1(GetGroupJoinRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGroupJoinRequestPublicV1.Response> GetGroupJoinRequestPublicV1Async(GetGroupJoinRequestPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGroupInvitationRequestPublicV1.Response GetGroupInvitationRequestPublicV1(GetGroupInvitationRequestPublicV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGroupInvitationRequestPublicV1.Response> GetGroupInvitationRequestPublicV1Async(GetGroupInvitationRequestPublicV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGroupInviteRequestPublicV2.Response GetGroupInviteRequestPublicV2(GetGroupInviteRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGroupInviteRequestPublicV2.Response> GetGroupInviteRequestPublicV2Async(GetGroupInviteRequestPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetGroupJoinRequestPublicV2.Response GetGroupJoinRequestPublicV2(GetGroupJoinRequestPublicV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetGroupJoinRequestPublicV2.Response> GetGroupJoinRequestPublicV2Async(GetGroupJoinRequestPublicV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public GetMyGroupJoinRequestV2.Response GetMyGroupJoinRequestV2(GetMyGroupJoinRequestV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetMyGroupJoinRequestV2.Response> GetMyGroupJoinRequestV2Async(GetMyGroupJoinRequestV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}