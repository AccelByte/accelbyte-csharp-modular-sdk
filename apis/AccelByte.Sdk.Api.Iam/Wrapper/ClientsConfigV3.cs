// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class ClientsConfigV3
    {
        private readonly IAccelByteSdk _sdk;

        public ClientsConfigV3(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminListClientAvailablePermissions.AdminListClientAvailablePermissionsBuilder AdminListClientAvailablePermissionsOp
        {
            get { return new Operation.AdminListClientAvailablePermissions.AdminListClientAvailablePermissionsBuilder(_sdk); }
        }
        public AdminUpdateAvailablePermissionsByModule.AdminUpdateAvailablePermissionsByModuleBuilder AdminUpdateAvailablePermissionsByModuleOp
        {
            get { return new Operation.AdminUpdateAvailablePermissionsByModule.AdminUpdateAvailablePermissionsByModuleBuilder(_sdk); }
        }
        public AdminDeleteConfigPermissionsByGroup.AdminDeleteConfigPermissionsByGroupBuilder AdminDeleteConfigPermissionsByGroupOp
        {
            get { return new Operation.AdminDeleteConfigPermissionsByGroup.AdminDeleteConfigPermissionsByGroupBuilder(_sdk); }
        }
        public AdminListClientTemplates.AdminListClientTemplatesBuilder AdminListClientTemplatesOp
        {
            get { return new Operation.AdminListClientTemplates.AdminListClientTemplatesBuilder(_sdk); }
        }
        #endregion

        public Model.ClientmodelListClientPermissionSet? AdminListClientAvailablePermissions(AdminListClientAvailablePermissions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateAvailablePermissionsByModule(AdminUpdateAvailablePermissionsByModule input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteConfigPermissionsByGroup(AdminDeleteConfigPermissionsByGroup input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ClientmodelListTemplatesResponse? AdminListClientTemplates(AdminListClientTemplates input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}