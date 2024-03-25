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
    public class ChallengeList
    {
        private readonly IAccelByteSdk _sdk;

        public ChallengeList(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetChallenges.GetChallengesBuilder GetChallengesOp
        {
            get { return new Operation.GetChallenges.GetChallengesBuilder(_sdk); }
        }
        public PublicGetScheduledGoals.PublicGetScheduledGoalsBuilder PublicGetScheduledGoalsOp
        {
            get { return new Operation.PublicGetScheduledGoals.PublicGetScheduledGoalsBuilder(_sdk); }
        }
        #endregion

        public Model.ModelListChallengeResponse? GetChallenges(GetChallenges input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetGoalsResponse? PublicGetScheduledGoals(PublicGetScheduledGoals input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}