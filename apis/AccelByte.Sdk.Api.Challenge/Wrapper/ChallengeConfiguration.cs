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
    public class ChallengeConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        public ChallengeConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetChallenges.AdminGetChallengesBuilder AdminGetChallengesOp
        {
            get { return new Operation.AdminGetChallenges.AdminGetChallengesBuilder(_sdk); }
        }
        public AdminCreateChallenge.AdminCreateChallengeBuilder AdminCreateChallengeOp
        {
            get { return new Operation.AdminCreateChallenge.AdminCreateChallengeBuilder(_sdk); }
        }
        public AdminGetChallenge.AdminGetChallengeBuilder AdminGetChallengeOp
        {
            get { return new Operation.AdminGetChallenge.AdminGetChallengeBuilder(_sdk); }
        }
        public AdminUpdateChallenge.AdminUpdateChallengeBuilder AdminUpdateChallengeOp
        {
            get { return new Operation.AdminUpdateChallenge.AdminUpdateChallengeBuilder(_sdk); }
        }
        public AdminDeleteChallenge.AdminDeleteChallengeBuilder AdminDeleteChallengeOp
        {
            get { return new Operation.AdminDeleteChallenge.AdminDeleteChallengeBuilder(_sdk); }
        }
        public AdminGetPeriods.AdminGetPeriodsBuilder AdminGetPeriodsOp
        {
            get { return new Operation.AdminGetPeriods.AdminGetPeriodsBuilder(_sdk); }
        }
        public AdminRandomizeChallenge.AdminRandomizeChallengeBuilder AdminRandomizeChallengeOp
        {
            get { return new Operation.AdminRandomizeChallenge.AdminRandomizeChallengeBuilder(_sdk); }
        }
        public AdminDeleteTiedChallenge.AdminDeleteTiedChallengeBuilder AdminDeleteTiedChallengeOp
        {
            get { return new Operation.AdminDeleteTiedChallenge.AdminDeleteTiedChallengeBuilder(_sdk); }
        }
        #endregion

        public Model.ModelListChallengeResponse? AdminGetChallenges(AdminGetChallenges input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminCreateChallenge(AdminCreateChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminGetChallenge(AdminGetChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminUpdateChallenge(AdminUpdateChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteChallenge(AdminDeleteChallenge input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListPeriodsResponse? AdminGetPeriods(AdminGetPeriods input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelSchedule>? AdminRandomizeChallenge(AdminRandomizeChallenge input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteTiedChallenge(AdminDeleteTiedChallenge input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}