// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class Admin
    {
        private readonly IAccelByteSdk _sdk;

        public Admin(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetServerLogs.GetServerLogsBuilder GetServerLogsOp
        {
            get { return new Operation.GetServerLogs.GetServerLogsBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsServerLogs? GetServerLogs(GetServerLogs input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}