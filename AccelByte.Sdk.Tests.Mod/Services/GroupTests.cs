// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Group.Model;

using AccelByte.Sdk.Tests.Mod.Model;
using AccelByte.Sdk.Api.Group;
using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class GroupTests : BaseServiceTests
    {
        public GroupTests() : base(true, IntegrationTestConfigRepository.Group) { }

        [Test]
        public void GroupServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            string initialConfigCode = "initialConfigurationCode";
            string configuration_code = $"csExtendSdkConfigCode";
            string groupName = "CSharp Extend SDK Test Group";
            string defaultAdminRoleId = "";
            string defaultMemberRoleId = "";

            var gConfigCheck = _Sdk.GetGroupApi().Configuration.GetGroupConfigurationAdminV1Op
                .Execute(initialConfigCode, _Sdk.Namespace);
            if (gConfigCheck.IsSuccess && gConfigCheck.Data != null)
            {
                //Initial config exists. Grab the role identifiers.
                defaultAdminRoleId = gConfigCheck.Data.GroupAdminRoleId!;
                defaultMemberRoleId = gConfigCheck.Data.GroupMemberRoleId!;
            }
            else
            {
                if (gConfigCheck.Error != GroupErrors.Error73131)
                    gConfigCheck.Error.ThrowException();

                //It means no initial configuration yet. But we need it for the default role id and admin role id.
                //So we just have to initiate it.
                ModelsCreateGroupConfigurationResponseV1 iConfigResp = _Sdk.GetGroupApi().Configuration.InitiateGroupConfigurationAdminV1Op
                    .Execute(_Sdk.Namespace)
                    .EnsureSuccess();

                defaultAdminRoleId = iConfigResp!.GroupAdminRoleId!;
                defaultMemberRoleId = iConfigResp!.GroupMemberRoleId!;
            }

            #region Create group configuration
            ModelsCreateGroupConfigurationRequestV1 gcRequest = new ModelsCreateGroupConfigurationRequestV1()
            {
                ConfigurationCode = configuration_code,
                Description = "CSharp SDK Test Configuration Group",
                GroupMaxMember = 50,
                Name = "CSharp SDK Test Configuration Group",
                GroupAdminRoleId = defaultAdminRoleId,
                GroupMemberRoleId = defaultMemberRoleId
            };

            var createResponse = _Sdk.GetGroupApi().Configuration.CreateGroupConfigurationAdminV1Op
                .Execute(gcRequest, _Sdk.Namespace);
            #endregion
            if (!createResponse.IsSuccess)
            {
                if (createResponse.Error != GroupErrors.Error73130)
                    createResponse.Error.ThrowException();
            }

            string group_id = "";
            try
            {
                //Look if current user is joined in any group
                //this is for fallback routine in case user is belong to any group before this test is executed.
                var groupInfoResponse = _Sdk.GetGroupApi().GroupMember.GetUserGroupInformationPublicV2Op
                   .SetOffset(0)
                   .SetLimit(10)
                   .Execute(_Sdk.Namespace);
                if (groupInfoResponse.IsSuccess && groupInfoResponse.Data != null)
                {
                    foreach (var info in groupInfoResponse.Data.Data!)
                    {
                        _Sdk.GetGroupApi().GroupMember.LeaveGroupPublicV2Op
                            .Execute(info.GroupId!, _Sdk.Namespace)
                            .EnsureSuccess();
                    }
                }
                else if (!groupInfoResponse.IsSuccess)
                {
                    //skip user does not belong to any group
                    if (groupInfoResponse.Error != GroupErrors.Error73034)
                        groupInfoResponse.Error.ThrowException();
                }

                #region Create a group
                ModelsPublicCreateNewGroupRequestV1 createGroup = new ModelsPublicCreateNewGroupRequestV1()
                {
                    GroupName = groupName,
                    GroupType = "PUBLIC",
                    GroupDescription = "Yeah, anyone is welcome here.",
                    GroupMaxMember = 100,
                    GroupRegion = "us",
                    ConfigurationCode = configuration_code
                };

                ModelsGroupResponseV1 cGroup = _Sdk.GetGroupApi().Group.CreateNewGroupPublicV1Op
                    .Execute(createGroup, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion

                Assert.AreEqual(groupName, cGroup.GroupName);
                group_id = cGroup.GroupId!;

                Wait();

                #region Get single group
                ModelsGroupResponseV1 gGroup = _Sdk.GetGroupApi().Group.GetSingleGroupPublicV1Op
                    .Execute(group_id, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion                
                Assert.AreEqual(groupName, gGroup.GroupName);

                #region Update a group
                ModelsUpdateGroupRequestV1 updateGroup = new ModelsUpdateGroupRequestV1()
                {
                    GroupDescription = "Updated description."
                };

                ModelsGroupResponseV1 uGroup = _Sdk.GetGroupApi().Group.UpdateSingleGroupV1Op
                    .Execute(updateGroup, group_id, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
                Assert.AreEqual("Updated description.", uGroup.GroupDescription);
            }
            finally
            {
                if (group_id != "")
                {
                    #region Delete a group
                    _Sdk.GetGroupApi().Group.DeleteGroupPublicV1Op
                        .Execute(group_id, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion

                    Wait();

                    //Finally, recheck if the data is truly deleted.
                    ApiResponseException? hrx = Assert.Throws<ApiResponseException>(() =>
                    {
                        DisableRetry();
                        _ = _Sdk.GetGroupApi().Group.GetSingleGroupPublicV1Op
                            .Execute(group_id, _Sdk.Namespace)
                            .EnsureSuccess();
                    });
                }

                #region Delete group configuration
                _Sdk.GetGroupApi().Configuration.DeleteGroupConfigurationV1Op
                    .Execute(configuration_code, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion
            }
        }
    }
}
