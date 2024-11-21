// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class IAMTests : BaseServiceTests
    {
        public IAMTests() : base(true) { }

        [Test]
        public void CreateUserV3Tests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();

            string user_name = ("csharpsdk_" + random.GenerateRandomId(8));
            string user_password = random.GenerateRandomPassword(10);
            string user_email = (user_name + "@dummy.com");
            string user_id;

            DisableRetry();

            #region Create a user (V3)
            ModelUserCreateRequestV3 newUser = new ModelUserCreateRequestV3()
            {
                AuthType = "EMAILPASSWD",
                EmailAddress = user_email,
                Password = user_password,
                DisplayName = "CSharp Server SDK Test",
                Country = "ID",
                DateOfBirth = "1995-01-10"
            };

            ModelUserCreateResponseV3 cuResp = _Sdk.GetIamApi().Users.PublicCreateUserV3Op
                .Execute(newUser, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(user_email, cuResp.EmailAddress);
            user_id = cuResp.UserId!;

            _Sdk.GetIamApi().Users.AdminDeleteUserInformationV3Op
                .Execute(_Sdk.Namespace, user_id)
                .EnsureSuccess();

            ResetPolicy();
        }

        [Test]
        public void IamServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Random random = new Random();

            string user_name = ("csharpsdk_" + random.GenerateRandomId(8));
            string user_password = random.GenerateRandomPassword(10);
            string user_email = (user_name + "@dummy.com");
            string user_id = "";

            #region Create a user
            AccountCreateUserRequestV4 newUser = new AccountCreateUserRequestV4()
            {
                AuthType = "EMAILPASSWD",
                EmailAddress = user_email,
                Password = user_password,
                DisplayName = "CSharp Server SDK Test",
                Username = user_name,
                Country = "ID",
                DateOfBirth = "1995-01-10"
            };

            AccountCreateUserResponseV4 cuResp = _Sdk.GetIamApi().UsersV4.PublicCreateUserV4Op
                .Execute(newUser, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(user_email, cuResp.EmailAddress);
            user_id = cuResp.UserId!;

            #region Get user data by user id
            ModelUserResponseV3 gUser = _Sdk.GetIamApi().Users.AdminGetUserByUserIdV3Op
                .Execute(_Sdk.Namespace, user_id)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("CSharp Server SDK Test", gUser.DisplayName);

            #region Update a user
            ModelUserUpdateRequestV3 updateUser = new ModelUserUpdateRequestV3()
            {
                DateOfBirth = "1996-01-10"
            };

            ModelUserResponseV3 uuResp = _Sdk.GetIamApi().UsersV4.AdminUpdateUserV4Op
                .Execute(updateUser, _Sdk.Namespace, user_id)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual("1996-01-10", uuResp.DateOfBirth?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            #region Delete a user
            _Sdk.GetIamApi().Users.AdminDeleteUserInformationV3Op
                .Execute(_Sdk.Namespace, user_id)
                .EnsureSuccess();
            #endregion

            //Finally, recheck if the data is truly deleted.
            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                DisableRetry();
                _ = _Sdk.GetIamApi().Users.AdminGetUserByUserIdV3Op
                    .Execute(_Sdk.Namespace, user_id)
                    .EnsureSuccess();
            });
        }
    }
}
