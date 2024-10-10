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
    public class ChallengeConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public ChallengeConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public ChallengeConfiguration(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public AdminGetChallenges.AdminGetChallengesBuilder AdminGetChallengesOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetChallenges.AdminGetChallengesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminCreateChallenge.AdminCreateChallengeBuilder AdminCreateChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminCreateChallenge.AdminCreateChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetActiveChallenges.AdminGetActiveChallengesBuilder AdminGetActiveChallengesOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetActiveChallenges.AdminGetActiveChallengesBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetChallenge.AdminGetChallengeBuilder AdminGetChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetChallenge.AdminGetChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateChallenge.AdminUpdateChallengeBuilder AdminUpdateChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateChallenge.AdminUpdateChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteChallenge.AdminDeleteChallengeBuilder AdminDeleteChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteChallenge.AdminDeleteChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminGetPeriods.AdminGetPeriodsBuilder AdminGetPeriodsOp
        {
            get
            {
                var opBuilder = new Operation.AdminGetPeriods.AdminGetPeriodsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminRandomizeChallenge.AdminRandomizeChallengeBuilder AdminRandomizeChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminRandomizeChallenge.AdminRandomizeChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminDeleteTiedChallenge.AdminDeleteTiedChallengeBuilder AdminDeleteTiedChallengeOp
        {
            get
            {
                var opBuilder = new Operation.AdminDeleteTiedChallenge.AdminDeleteTiedChallengeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public AdminUpdateTiedChallengeSchedule.AdminUpdateTiedChallengeScheduleBuilder AdminUpdateTiedChallengeScheduleOp
        {
            get
            {
                var opBuilder = new Operation.AdminUpdateTiedChallengeSchedule.AdminUpdateTiedChallengeScheduleBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
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
        public async Task<Model.ModelListChallengeResponse?> AdminGetChallengesAsync(AdminGetChallenges input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelChallengeResponse?> AdminCreateChallengeAsync(AdminCreateChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListChallengeResponse? AdminGetActiveChallenges(AdminGetActiveChallenges input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelListChallengeResponse?> AdminGetActiveChallengesAsync(AdminGetActiveChallenges input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelChallengeResponse?> AdminGetChallengeAsync(AdminGetChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelChallengeResponse?> AdminUpdateChallengeAsync(AdminUpdateChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task AdminDeleteChallengeAsync(AdminDeleteChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.ModelListPeriodsResponse?> AdminGetPeriodsAsync(AdminGetPeriods input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<List<Model.ModelSchedule>?> AdminRandomizeChallengeAsync(AdminRandomizeChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task AdminDeleteTiedChallengeAsync(AdminDeleteTiedChallenge input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelChallengeResponse? AdminUpdateTiedChallengeSchedule(AdminUpdateTiedChallengeSchedule input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelChallengeResponse?> AdminUpdateTiedChallengeScheduleAsync(AdminUpdateTiedChallengeSchedule input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}