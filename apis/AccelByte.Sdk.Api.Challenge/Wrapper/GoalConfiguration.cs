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
    public class GoalConfiguration
    {
        private readonly IAccelByteSdk _sdk;

        public GoalConfiguration(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminGetGoals.AdminGetGoalsBuilder AdminGetGoalsOp
        {
            get { return new Operation.AdminGetGoals.AdminGetGoalsBuilder(_sdk); }
        }
        public AdminCreateGoal.AdminCreateGoalBuilder AdminCreateGoalOp
        {
            get { return new Operation.AdminCreateGoal.AdminCreateGoalBuilder(_sdk); }
        }
        public AdminGetGoal.AdminGetGoalBuilder AdminGetGoalOp
        {
            get { return new Operation.AdminGetGoal.AdminGetGoalBuilder(_sdk); }
        }
        public AdminUpdateGoals.AdminUpdateGoalsBuilder AdminUpdateGoalsOp
        {
            get { return new Operation.AdminUpdateGoals.AdminUpdateGoalsBuilder(_sdk); }
        }
        public AdminDeleteGoal.AdminDeleteGoalBuilder AdminDeleteGoalOp
        {
            get { return new Operation.AdminDeleteGoal.AdminDeleteGoalBuilder(_sdk); }
        }
        #endregion

        public Model.ModelGetGoalsResponse? AdminGetGoals(AdminGetGoals input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminCreateGoal(AdminCreateGoal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminGetGoal(AdminGetGoal input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGoalResponse? AdminUpdateGoals(AdminUpdateGoals input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteGoal(AdminDeleteGoal input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}