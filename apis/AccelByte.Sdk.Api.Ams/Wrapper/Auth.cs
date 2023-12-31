// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Api.Ams.Wrapper
{
    public class Auth
    {
        private readonly IAccelByteSdk _sdk;

        public Auth(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AuthCheck.AuthCheckBuilder AuthCheckOp
        {
            get { return new Operation.AuthCheck.AuthCheckBuilder(_sdk); }
        }
        #endregion

        public void AuthCheck(AuthCheck input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}