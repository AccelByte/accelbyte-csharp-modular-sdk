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
    public class Operations
    {
        private readonly IAccelByteSdk _sdk;

        public Operations(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public Func1.Func1Builder Func1Op
        {
            get { return new Operation.Func1.Func1Builder(_sdk); }
        }
        public BasicHealthCheck.BasicHealthCheckBuilder BasicHealthCheckOp
        {
            get { return new Operation.BasicHealthCheck.BasicHealthCheckBuilder(_sdk); }
        }
        #endregion
        
        public void Func1(Func1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void BasicHealthCheck(BasicHealthCheck input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}