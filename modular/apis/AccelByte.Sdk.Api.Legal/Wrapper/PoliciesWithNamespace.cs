// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class PoliciesWithNamespace
    {
        private readonly IAccelByteSdk _sdk;

        public PoliciesWithNamespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public UpdatePolicy1.UpdatePolicy1Builder UpdatePolicy1Op
        {
            get { return new Operation.UpdatePolicy1.UpdatePolicy1Builder(_sdk); }
        }
        public SetDefaultPolicy3.SetDefaultPolicy3Builder SetDefaultPolicy3Op
        {
            get { return new Operation.SetDefaultPolicy3.SetDefaultPolicy3Builder(_sdk); }
        }
        #endregion
        
        public void UpdatePolicy1(UpdatePolicy1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SetDefaultPolicy3(SetDefaultPolicy3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}