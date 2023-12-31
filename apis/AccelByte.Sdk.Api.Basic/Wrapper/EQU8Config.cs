// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class EQU8Config
    {
        private readonly IAccelByteSdk _sdk;

        public EQU8Config(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetConfig.GetConfigBuilder GetConfigOp
        {
            get { return new Operation.GetConfig.GetConfigBuilder(_sdk); }
        }
        public DeleteConfig.DeleteConfigBuilder DeleteConfigOp
        {
            get { return new Operation.DeleteConfig.DeleteConfigBuilder(_sdk); }
        }
        public UpdateConfig.UpdateConfigBuilder UpdateConfigOp
        {
            get { return new Operation.UpdateConfig.UpdateConfigBuilder(_sdk); }
        }
        #endregion

        public Model.Equ8Config? GetConfig(GetConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig(DeleteConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Equ8Config? UpdateConfig(UpdateConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}