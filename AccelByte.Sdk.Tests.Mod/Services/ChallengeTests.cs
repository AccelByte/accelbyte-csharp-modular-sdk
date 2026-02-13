// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Tests.Mod.Scenario;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class ChallengeTests : BaseServiceTests
    {
        public ChallengeTests() : base(false, IntegrationTestConfigRepository.Challenge) { }

        [Test]
        public void UserRewardTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ITestPlayer player1 = new NewTestPlayer(_Sdk, true);
            player1.Run((sdk, player) =>
            {
                #region Get user rewards
                var userRewards = sdk.GetChallengeApi().PlayerReward.PublicGetUserRewardsOp
                    .SetOffset(0)
                    .SetLimit(10)
                    .Execute(sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                Assert.IsNotNull(userRewards);
            });
            player1.Logout();
        }

        [Test]
        public void ChallengeAndGoalTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();

            string challengeCode = $"csharp-{random.GenerateRandomId(6)}-challenge";
            string challengeName = "CSharp Challenge Test";
            string goalCode = $"csharp-{random.GenerateRandomId(6)}-goal";
            string goalName = $"CSharp Goal Test";

            #region Create a new challenge
            var newChallenge = _Sdk.GetChallengeApi().ChallengeConfiguration.AdminCreateChallengeOp
                .Execute(new ModelCreateChallengeRequest()
                {
                    Code = challengeCode,
                    Description = "",
                    Name = challengeName,
                    AssignmentRule = ModelCreateChallengeRequestAssignmentRule.FIXED,
                    GoalsVisibility = ModelCreateChallengeRequestGoalsVisibility.SHOWALL,
                    Rotation = ModelCreateChallengeRequestRotation.DAILY,
                    StartDate = DateTime.Now.AddDays(1)
                }, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(challengeName, newChallenge.Name);

            try
            {
                #region Get challenge
                var challengeData = _Sdk.GetChallengeApi().ChallengeConfiguration.AdminGetChallengeOp
                    .Execute(challengeCode, _Sdk.Namespace).EnsureSuccess();
                #endregion
                Assert.AreEqual(challengeName, challengeData.Name);

                #region Update a challenge
                var updatedChallenge = _Sdk.GetChallengeApi().ChallengeConfiguration.AdminUpdateChallengeOp
                    .Execute(new ModelUpdateChallengeRequest()
                    {
                        Name = $"{challengeName} UPDATED"
                    }, challengeCode, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                Assert.AreEqual($"{challengeName} UPDATED", updatedChallenge.Name);

                #region Create a goal
                var newGoalResp = _Sdk.GetChallengeApi().GoalConfiguration.AdminCreateGoalOp
                    .Execute(new ModelCreateGoalRequest()
                    {
                        Code = goalCode,
                        Name = goalName,
                        Description = "",
                        Schedule = new ModelGoalScheduleRequest()
                        {
                            StartTime = DateTime.Now.AddDays(1),
                            Order = 1
                        },
                        RequirementGroups = new List<ModelRequirement>()
                        {
                        new ModelRequirement()
                        {
                            Operator = ModelRequirementOperator.AND,
                            Predicates = new List<ModelPredicate>()
                            {
                                new ModelPredicate()
                                {
                                    ParameterType = ModelPredicateParameterType.USERACCOUNT,
                                    ParameterName = "userAccountVerified",
                                    Matcher = ModelPredicateMatcher.EQUAL,
                                    TargetValue = 1
                                }
                            }
                        }
                        }
                    }, challengeCode, _Sdk.Namespace);
                #endregion
                Assert.IsTrue(newGoalResp.IsSuccess);

                #region Delete a goal
                var delResp = _Sdk.GetChallengeApi().GoalConfiguration.AdminDeleteGoalOp
                    .Execute(challengeCode, goalCode, _Sdk.Namespace);
                #endregion
                Assert.IsTrue(delResp.IsSuccess);
            }
            finally
            {
                #region Delete a challenge
                _Sdk.GetChallengeApi().ChallengeConfiguration.AdminDeleteChallengeOp
                    .Execute(challengeCode, _Sdk.Namespace);
                #endregion
            }
        }
    }
}
