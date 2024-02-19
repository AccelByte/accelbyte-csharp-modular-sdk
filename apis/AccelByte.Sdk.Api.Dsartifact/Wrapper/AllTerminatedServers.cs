// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Api.Dsartifact.Wrapper
{
    public class AllTerminatedServers
    {
        private readonly IAccelByteSdk _sdk;

        public AllTerminatedServers(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListTerminatedServers.ListTerminatedServersBuilder ListTerminatedServersOp
        {
            get { return new Operation.ListTerminatedServers.ListTerminatedServersBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsListTerminatedServersResponse? ListTerminatedServers(ListTerminatedServers input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}