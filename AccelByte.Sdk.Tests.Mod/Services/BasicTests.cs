// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class BasicTests : BaseServiceTests
    {
        public BasicTests() : base(true, IntegrationTestConfigRepository.Basic) { }

        [Test]
        public void BasicServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            //Get user's own profile info, will throw an exception if profile does not exists which is expected.
            var check = _Sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp
                .Execute(_Sdk.Namespace);
            if (check.IsSuccess)
            {
                //But if the profile do actually exists, just delete it.

                var profileData = check.EnsureSuccess();
                _Sdk.GetBasicApi().UserProfile.DeleteUserProfileOp
                    .Execute(_Sdk.Namespace, profileData.UserId!);
            }
            else
            {
                //if the error is not profile not found, then fail
                if (check.Error != BasicErrors.Error11440)
                    Assert.Fail(check.Error.Message);
            }

            #region Create user's own profile info
            UserProfilePrivateCreate createProfile = new UserProfilePrivateCreate()
            {
                FirstName = "Integration Test",
                LastName = "CSharp Extend SDK",
                DateOfBirth = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Language = "en"
            };

            UserProfilePrivateInfo cInfo = _Sdk.GetBasicApi().UserProfile.CreateMyProfileOp
                .SetBody(createProfile)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(cInfo.FirstName, "Integration Test");

            #region Get user's own profile info
            UserProfilePrivateInfo ownResp = _Sdk.GetBasicApi().UserProfile.GetMyProfileInfoOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(ownResp.LastName!, "CSharp Extend SDK");
            string userId = ownResp.UserId!;

            #region Update user's own profile info
            UserProfileUpdate updateProfile = new UserProfileUpdate()
            {
                TimeZone = "Asia/Jakarta"
            };

            UserProfilePrivateInfo updResp = _Sdk.GetBasicApi().UserProfile.UpdateMyProfileOp
                .SetBody(updateProfile)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(updResp.TimeZone, "Asia/Jakarta");

            #region Delete user's own profile info
            var delResp = _Sdk.GetBasicApi().UserProfile.DeleteUserProfileOp
                .Execute(_Sdk.Namespace, userId);
            #endregion
            Assert.IsTrue(delResp.IsSuccess);
        }
    }
}
