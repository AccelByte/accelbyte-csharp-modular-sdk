// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Api.Qosm.Wrapper
{
    public class Server
    {
        private readonly IAccelByteSdk _sdk;

        public Server(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Heartbeat.HeartbeatBuilder HeartbeatOp
        {
            get { return new Operation.Heartbeat.HeartbeatBuilder(_sdk); }
        }
        #endregion

        public void Heartbeat(Heartbeat input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}