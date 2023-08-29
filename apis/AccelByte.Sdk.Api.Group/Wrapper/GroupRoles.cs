// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Api.Group.Wrapper
{
    public class GroupRoles
    {
        private readonly IAccelByteSdk _sdk;

        public GroupRoles(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder GetMemberRolesListAdminV1Op
        {
            get { return new Operation.GetMemberRolesListAdminV1.GetMemberRolesListAdminV1Builder(_sdk); }
        }
        public CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder CreateMemberRoleAdminV1Op
        {
            get { return new Operation.CreateMemberRoleAdminV1.CreateMemberRoleAdminV1Builder(_sdk); }
        }
        public GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder GetSingleMemberRoleAdminV1Op
        {
            get { return new Operation.GetSingleMemberRoleAdminV1.GetSingleMemberRoleAdminV1Builder(_sdk); }
        }
        public DeleteMemberRoleAdminV1.DeleteMemberRoleAdminV1Builder DeleteMemberRoleAdminV1Op
        {
            get { return new Operation.DeleteMemberRoleAdminV1.DeleteMemberRoleAdminV1Builder(_sdk); }
        }
        public UpdateMemberRoleAdminV1.UpdateMemberRoleAdminV1Builder UpdateMemberRoleAdminV1Op
        {
            get { return new Operation.UpdateMemberRoleAdminV1.UpdateMemberRoleAdminV1Builder(_sdk); }
        }
        public UpdateMemberRolePermissionAdminV1.UpdateMemberRolePermissionAdminV1Builder UpdateMemberRolePermissionAdminV1Op
        {
            get { return new Operation.UpdateMemberRolePermissionAdminV1.UpdateMemberRolePermissionAdminV1Builder(_sdk); }
        }
        public GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder GetMemberRolesListPublicV1Op
        {
            get { return new Operation.GetMemberRolesListPublicV1.GetMemberRolesListPublicV1Builder(_sdk); }
        }
        public UpdateMemberRolePublicV1.UpdateMemberRolePublicV1Builder UpdateMemberRolePublicV1Op
        {
            get { return new Operation.UpdateMemberRolePublicV1.UpdateMemberRolePublicV1Builder(_sdk); }
        }
        public DeleteMemberRolePublicV1.DeleteMemberRolePublicV1Builder DeleteMemberRolePublicV1Op
        {
            get { return new Operation.DeleteMemberRolePublicV1.DeleteMemberRolePublicV1Builder(_sdk); }
        }
        public GetMemberRolesListPublicV2.GetMemberRolesListPublicV2Builder GetMemberRolesListPublicV2Op
        {
            get { return new Operation.GetMemberRolesListPublicV2.GetMemberRolesListPublicV2Builder(_sdk); }
        }
        public UpdateMemberRolePublicV2.UpdateMemberRolePublicV2Builder UpdateMemberRolePublicV2Op
        {
            get { return new Operation.UpdateMemberRolePublicV2.UpdateMemberRolePublicV2Builder(_sdk); }
        }
        public DeleteMemberRolePublicV2.DeleteMemberRolePublicV2Builder DeleteMemberRolePublicV2Op
        {
            get { return new Operation.DeleteMemberRolePublicV2.DeleteMemberRolePublicV2Builder(_sdk); }
        }
        #endregion

        public Model.ModelsGetMemberRolesListResponseV1? GetMemberRolesListAdminV1(GetMemberRolesListAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRoleResponseV1? CreateMemberRoleAdminV1(CreateMemberRoleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRoleResponseV1? GetSingleMemberRoleAdminV1(GetSingleMemberRoleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMemberRoleAdminV1(DeleteMemberRoleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRoleResponseV1? UpdateMemberRoleAdminV1(UpdateMemberRoleAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsMemberRoleResponseV1? UpdateMemberRolePermissionAdminV1(UpdateMemberRolePermissionAdminV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRolesListResponseV1? GetMemberRolesListPublicV1(GetMemberRolesListPublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserGroupInformationResponseV1? UpdateMemberRolePublicV1(UpdateMemberRolePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMemberRolePublicV1(DeleteMemberRolePublicV1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetMemberRolesListResponseV1? GetMemberRolesListPublicV2(GetMemberRolesListPublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserGroupInformationResponseV1? UpdateMemberRolePublicV2(UpdateMemberRolePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteMemberRolePublicV2(DeleteMemberRolePublicV2 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}