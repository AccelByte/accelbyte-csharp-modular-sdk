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
using System.Diagnostics;
using System.Threading;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class IAMTests : BaseServiceTests
    {
        public IAMTests() : base(true) { }

        protected int FindAndCheckResourceActionFromRole(IAccelByteSdk sdk, string roleId, string resourceToCheck)
        {
            var permissions = sdk.GetIamApi().OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                    .Execute(sdk.Namespace, roleId)
                    .EnsureSuccess();
            if (permissions == null)
                throw new Exception("Role's permissions object is null");

            int resultAction = -1;
            foreach (var permission in permissions!.Permissions!)
            {
                if (permission.Resource! == resourceToCheck)
                {
                    resultAction = permission.Action!.Value;
                    break;
                }
            }

            return resultAction;
        }

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
            ApiResponseException? hrx = Assert.Throws<ApiResponseException>(() =>
            {
                DisableRetry();
                _ = _Sdk.GetIamApi().Users.AdminGetUserByUserIdV3Op
                    .Execute(_Sdk.Namespace, user_id)
                    .EnsureSuccess();
            });
        }

        [Test]
        public void RoleOverrideTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string roleIdentityToUpdate = "USER";
            string resourceToCheck = "NAMESPACE:{namespace}:PROFILE";
            int actionToCheck = 7;
            int updatedActionToCheck = 2;
            int checkCount = 20;
            int checkInterval = 1000;

            DisableRetry();

            var roles = _Sdk.GetIamApi().Roles.AdminGetRolesV4Op
                .SetAdminRole(false)
                .Execute()
                .EnsureSuccess();
            Assert.IsNotNull(roles);

            string userRoleId = "";
            foreach (var role in roles!.Data!)
            {
                if (role.RoleName!.ToUpper() == roleIdentityToUpdate)
                {
                    userRoleId = role.RoleId!;
                    break;
                }
            }

            Assert.AreNotEqual("", userRoleId);
            try
            {
                int oAction = FindAndCheckResourceActionFromRole(_Sdk, userRoleId, resourceToCheck);
                Assert.AreEqual(actionToCheck, oAction);

                //Do role override
                var updateResponse = _Sdk.GetIamApi().OverrideRoleConfigV3.AdminUpdateRoleOverrideConfigV3Op
                    .Execute(new ModelRoleOverrideUpdateRequest()
                    {
                        Exclusions = [
                            new AccountcommonOverrideRolePermission()
                            {
                                Resource = resourceToCheck,
                                Actions = [1, 4]
                            }
                        ]
                    }, _Sdk.Namespace, roleIdentityToUpdate)
                    .EnsureSuccess();
                Assert.IsNotNull(updateResponse);

                //Activate role override
                var activateResponse = _Sdk.GetIamApi().OverrideRoleConfigV3.AdminChangeRoleOverrideConfigStatusV3Op
                    .Execute(new ModelRoleOverrideStatsUpdateRequest()
                    {
                        Active = true
                    }, _Sdk.Namespace, roleIdentityToUpdate)
                    .EnsureSuccess();
                Assert.IsNotNull(activateResponse);
                if (activateResponse != null)
                    Assert.IsTrue(activateResponse.Active!);

                try
                {
                    bool uValid = false;
                    int currentCount = 0;
                    while (currentCount < checkCount)
                    {
                        Debug.WriteLine($"Checking updated permissions [{currentCount + 1}]");
                        int uAction = FindAndCheckResourceActionFromRole(_Sdk, userRoleId, resourceToCheck);
                        if (uAction == updatedActionToCheck)
                        {
                            uValid = true;
                            break;
                        }

                        currentCount++;
                        Thread.Sleep(checkInterval);
                    }

                    Assert.IsTrue(uValid);
                }
                finally
                {
                    //Deactivate role override
                    _Sdk.GetIamApi().OverrideRoleConfigV3.AdminChangeRoleOverrideConfigStatusV3Op
                        .Execute(new ModelRoleOverrideStatsUpdateRequest()
                        {
                            Active = false
                        }, _Sdk.Namespace, roleIdentityToUpdate)
                        .EnsureSuccess();
                }
            }
            finally
            {
                ResetPolicy();
            }
        }
    }
}
