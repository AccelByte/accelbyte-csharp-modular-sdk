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
    public class Presence
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Presence(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Presence(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder UsersPresenceHandlerV1Op
        {
            get
            {
                var opBuilder = new Operation.UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UsersPresenceHandlerV2.UsersPresenceHandlerV2Builder UsersPresenceHandlerV2Op
        {
            get
            {
                var opBuilder = new Operation.UsersPresenceHandlerV2.UsersPresenceHandlerV2Builder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public UsersPresenceHandlerV1.Response UsersPresenceHandlerV1(UsersPresenceHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UsersPresenceHandlerV1.Response> UsersPresenceHandlerV1Async(UsersPresenceHandlerV1 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UsersPresenceHandlerV2.Response UsersPresenceHandlerV2(UsersPresenceHandlerV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UsersPresenceHandlerV2.Response> UsersPresenceHandlerV2Async(UsersPresenceHandlerV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}