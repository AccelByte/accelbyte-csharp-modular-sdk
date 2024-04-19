// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsartifact.Model;
using AccelByte.Sdk.Api.Dsartifact.Operation;

namespace AccelByte.Sdk.Api.Dsartifact.Wrapper
{
    public class DownloadServerArtifact
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public DownloadServerArtifact(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public DownloadServerArtifact(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public DownloadServerArtifacts.DownloadServerArtifactsBuilder DownloadServerArtifactsOp
        {
            get
            {
                var opBuilder = new Operation.DownloadServerArtifacts.DownloadServerArtifactsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CheckServerArtifact.CheckServerArtifactBuilder CheckServerArtifactOp
        {
            get
            {
                var opBuilder = new Operation.CheckServerArtifact.CheckServerArtifactBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public void DownloadServerArtifacts(DownloadServerArtifacts input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DownloadServerArtifactsAsync(DownloadServerArtifacts input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsArtifactFileStatus? CheckServerArtifact(CheckServerArtifact input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsArtifactFileStatus?> CheckServerArtifactAsync(CheckServerArtifact input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}