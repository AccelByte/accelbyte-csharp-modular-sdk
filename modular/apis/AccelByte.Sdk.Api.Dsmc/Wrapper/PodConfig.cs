// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class PodConfig
    {
        private readonly IAccelByteSdk _sdk;

        public PodConfig(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetLowestInstanceSpec.GetLowestInstanceSpecBuilder GetLowestInstanceSpecOp
        {
            get { return new Operation.GetLowestInstanceSpec.GetLowestInstanceSpecBuilder(_sdk); }
        }
        public GetAllPodConfig.GetAllPodConfigBuilder GetAllPodConfigOp
        {
            get { return new Operation.GetAllPodConfig.GetAllPodConfigBuilder(_sdk); }
        }
        public GetPodConfig.GetPodConfigBuilder GetPodConfigOp
        {
            get { return new Operation.GetPodConfig.GetPodConfigBuilder(_sdk); }
        }
        public CreatePodConfig.CreatePodConfigBuilder CreatePodConfigOp
        {
            get { return new Operation.CreatePodConfig.CreatePodConfigBuilder(_sdk); }
        }
        public DeletePodConfig.DeletePodConfigBuilder DeletePodConfigOp
        {
            get { return new Operation.DeletePodConfig.DeletePodConfigBuilder(_sdk); }
        }
        public UpdatePodConfig.UpdatePodConfigBuilder UpdatePodConfigOp
        {
            get { return new Operation.UpdatePodConfig.UpdatePodConfigBuilder(_sdk); }
        }
        #endregion
        
        public Model.ModelsInstanceSpec? GetLowestInstanceSpec(GetLowestInstanceSpec input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListPodConfigResponse? GetAllPodConfig(GetAllPodConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? GetPodConfig(GetPodConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? CreatePodConfig(CreatePodConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeletePodConfig(DeletePodConfig input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPodConfigRecord? UpdatePodConfig(UpdatePodConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}