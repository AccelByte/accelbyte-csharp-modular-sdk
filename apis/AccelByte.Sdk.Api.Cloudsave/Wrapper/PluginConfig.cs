// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

namespace AccelByte.Sdk.Api.Cloudsave.Wrapper
{
    public class PluginConfig
    {
        private readonly IAccelByteSdk _sdk;

        public PluginConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetPluginConfig.GetPluginConfigBuilder GetPluginConfigOp
        {
            get { return new Operation.GetPluginConfig.GetPluginConfigBuilder(_sdk); }
        }
        public CreatePluginConfig.CreatePluginConfigBuilder CreatePluginConfigOp
        {
            get { return new Operation.CreatePluginConfig.CreatePluginConfigBuilder(_sdk); }
        }
        public DeletePluginConfig.DeletePluginConfigBuilder DeletePluginConfigOp
        {
            get { return new Operation.DeletePluginConfig.DeletePluginConfigBuilder(_sdk); }
        }
        public UpdatePluginConfig.UpdatePluginConfigBuilder UpdatePluginConfigOp
        {
            get { return new Operation.UpdatePluginConfig.UpdatePluginConfigBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsPluginResponse? GetPluginConfig(GetPluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPluginResponse? CreatePluginConfig(CreatePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePluginConfig(DeletePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPluginResponse? UpdatePluginConfig(UpdatePluginConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}