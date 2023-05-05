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
    public class Config
    {
        private readonly IAccelByteSdk _sdk;

        public Config(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateConfig.CreateConfigBuilder CreateConfigOp
        {
            get { return new Operation.CreateConfig.CreateConfigBuilder(_sdk); }
        }
        public GetConfig1.GetConfig1Builder GetConfig1Op
        {
            get { return new Operation.GetConfig1.GetConfig1Builder(_sdk); }
        }
        public DeleteConfig1.DeleteConfig1Builder DeleteConfig1Op
        {
            get { return new Operation.DeleteConfig1.DeleteConfig1Builder(_sdk); }
        }
        public UpdateConfig1.UpdateConfig1Builder UpdateConfig1Op
        {
            get { return new Operation.UpdateConfig1.UpdateConfig1Builder(_sdk); }
        }
        public GetPublisherConfig.GetPublisherConfigBuilder GetPublisherConfigOp
        {
            get { return new Operation.GetPublisherConfig.GetPublisherConfigBuilder(_sdk); }
        }
        #endregion
        
        public Model.ConfigInfo? CreateConfig(CreateConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? GetConfig1(GetConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteConfig1(DeleteConfig1 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? UpdateConfig1(UpdateConfig1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ConfigInfo? GetPublisherConfig(GetPublisherConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}