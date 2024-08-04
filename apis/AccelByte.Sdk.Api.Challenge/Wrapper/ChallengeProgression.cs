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

using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class ChallengeProgression
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public ChallengeProgression(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public ChallengeProgression(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminEvaluateProgress.AdminEvaluateProgressBuilder AdminEvaluateProgressOp
        {
            get
            {
                var opBuilder = new Operation.AdminEvaluateProgress.AdminEvaluateProgressBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public EvaluateMyProgress.EvaluateMyProgressBuilder EvaluateMyProgressOp
        {
            get
            {
                var opBuilder = new Operation.EvaluateMyProgress.EvaluateMyProgressBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetUserProgression.PublicGetUserProgressionBuilder PublicGetUserProgressionOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetUserProgression.PublicGetUserProgressionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetPastUserProgression.PublicGetPastUserProgressionBuilder PublicGetPastUserProgressionOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetPastUserProgression.PublicGetPastUserProgressionBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        #endregion

        public void AdminEvaluateProgress(AdminEvaluateProgress input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task AdminEvaluateProgressAsync(AdminEvaluateProgress input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void EvaluateMyProgress(EvaluateMyProgress input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task EvaluateMyProgressAsync(EvaluateMyProgress input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserProgressionResponse? PublicGetUserProgression(PublicGetUserProgression input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelUserProgressionResponse?> PublicGetUserProgressionAsync(PublicGetUserProgression input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserProgressionResponse? PublicGetPastUserProgression(PublicGetPastUserProgression input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelUserProgressionResponse?> PublicGetPastUserProgressionAsync(PublicGetPastUserProgression input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}