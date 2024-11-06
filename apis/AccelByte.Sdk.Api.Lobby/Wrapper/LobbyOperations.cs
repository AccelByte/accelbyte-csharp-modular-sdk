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
    public class LobbyOperations
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public LobbyOperations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public LobbyOperations(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminUpdatePartyAttributesV1.AdminUpdatePartyAttributesV1Builder AdminUpdatePartyAttributesV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminUpdatePartyAttributesV1.AdminUpdatePartyAttributesV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminJoinPartyV1.AdminJoinPartyV1Builder AdminJoinPartyV1Op
        {
            get
            {
                var opBuilder = new Operation.AdminJoinPartyV1.AdminJoinPartyV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetMessages.PublicGetMessagesBuilder PublicGetMessagesOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetMessages.PublicGetMessagesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public AdminUpdatePartyAttributesV1.Response AdminUpdatePartyAttributesV1(AdminUpdatePartyAttributesV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdatePartyAttributesV1.Response> AdminUpdatePartyAttributesV1Async(AdminUpdatePartyAttributesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }

        public AdminUpdatePartyAttributesV1.Response<T1> AdminUpdatePartyAttributesV1<T1>(AdminUpdatePartyAttributesV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminUpdatePartyAttributesV1.Response<T1>> AdminUpdatePartyAttributesV1Async<T1>(AdminUpdatePartyAttributesV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public AdminJoinPartyV1.Response AdminJoinPartyV1(AdminJoinPartyV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<AdminJoinPartyV1.Response> AdminJoinPartyV1Async(AdminJoinPartyV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetMessages.Response PublicGetMessages(PublicGetMessages input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetMessages.Response> PublicGetMessagesAsync(PublicGetMessages input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}