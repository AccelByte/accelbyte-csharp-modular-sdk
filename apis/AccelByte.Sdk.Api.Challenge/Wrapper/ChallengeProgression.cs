// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Api.Challenge.Wrapper
{
    public class ChallengeProgression
    {
        private readonly IAccelByteSdk _sdk;

        public ChallengeProgression(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminEvaluateProgress.AdminEvaluateProgressBuilder AdminEvaluateProgressOp
        {
            get { return new Operation.AdminEvaluateProgress.AdminEvaluateProgressBuilder(_sdk); }
        }
        public EvaluateMyProgress.EvaluateMyProgressBuilder EvaluateMyProgressOp
        {
            get { return new Operation.EvaluateMyProgress.EvaluateMyProgressBuilder(_sdk); }
        }
        public PublicGetUserProgression.PublicGetUserProgressionBuilder PublicGetUserProgressionOp
        {
            get { return new Operation.PublicGetUserProgression.PublicGetUserProgressionBuilder(_sdk); }
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
        public void EvaluateMyProgress(EvaluateMyProgress input)
        {
            var response = _sdk.RunRequest(input);

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
    }
}