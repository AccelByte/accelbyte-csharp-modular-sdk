// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Authentication
{
    public class DefaultTokenValidator : TokenValidator, ITokenValidator
    {
        private Func<IAccelByteSdk, string, List<LocalPermissionItem>> _FetchFunction = ((sdk, roleId) =>
        {
            var response = sdk.GetIamApi().Roles.AdminGetRoleV4Op.Execute(roleId);
            if (response == null)
                throw new Exception("Null response");

            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in response.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            return permissions;
        });

        public bool Validate(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                bool foundMatchingPermission = false;
                if ((response.Permissions != null) && (response.Permissions.Count > 0))
                {
                    foreach (var p in response.Permissions)
                    {
                        if ((p.Resource != null) && (p.Action != null))
                        {
                            if (IsResourceAllowed(p.Resource, permission))
                            {
                                if (PermissionAction.Has(p.Action.Value, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;

                        var permissions = GetRolePermission(sdk, r.RoleId, _FetchFunction);
                        foreach (var p in permissions)
                        {
                            if (IsResourceAllowed(p.Resource, permission))
                            {
                                if (PermissionAction.Has(p.Action, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }

                        if (foundMatchingPermission)
                            break;
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public bool Validate(IAccelByteSdk sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
                OauthmodelTokenResponseV3? response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                if (response == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                    pParams.Add("namespace", aNamespace);
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((response.Permissions != null) && (response.Permissions.Count > 0))
                {
                    foreach (var p in response.Permissions)
                    {
                        if ((p.Resource != null) && (p.Action != null))
                        {
                            string aPermission = p.Resource;
                            if (pParams.Count > 0)
                                aPermission = ReplacePlaceholder(p.Resource, pParams);

                            if (IsResourceAllowed(aPermission, permission))
                            {
                                if (PermissionAction.Has(p.Action.Value, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;

                        var permissions = GetRolePermission(sdk, r.RoleId, _FetchFunction);
                        foreach (var p in permissions)
                        {
                            string aPermission = p.Resource;
                            if (pParams.Count > 0)
                                aPermission = ReplacePlaceholder(p.Resource, pParams);

                            if (IsResourceAllowed(aPermission, permission))
                            {
                                if (PermissionAction.Has(p.Action, action))
                                {
                                    foundMatchingPermission = true;
                                    break;
                                }
                            }
                        }

                        if (foundMatchingPermission)
                            break;
                    }
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }
    }
}
