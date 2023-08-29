// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Presence
    {
        private readonly IAccelByteSdk _sdk;

        public Presence(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder UsersPresenceHandlerV1Op
        {
            get { return new Operation.UsersPresenceHandlerV1.UsersPresenceHandlerV1Builder(_sdk); }
        }
        #endregion

        public Model.HandlersGetUsersPresenceResponse? UsersPresenceHandlerV1(UsersPresenceHandlerV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}