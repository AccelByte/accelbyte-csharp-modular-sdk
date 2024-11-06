// Copyright (c) 2023-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Security;

namespace AccelByte.Sdk.Authentication
{
    public class DefaultTokenValidator : TokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        private Func<IAccelByteSdk, string, List<LocalPermissionItem>> _FetchFunction = ((sdk, roleId) =>
        {
            var response = sdk.GetIamApi().Roles.AdminGetRoleV4Op.Execute(roleId).Ok();

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

        private Func<IAccelByteSdk, string, Task<List<LocalPermissionItem>>> _FetchFunctionAsync = (async (sdk, roleId) =>
        {
            var response = await sdk.GetIamApi().Roles.AdminGetRoleV4Op.ExecuteAsync(roleId);
            var responseData = response.Ok();

            List<LocalPermissionItem> permissions = new List<LocalPermissionItem>();
            foreach (var item in responseData.Permissions!)
            {
                permissions.Add(new LocalPermissionItem()
                {
                    Resource = item.Resource!,
                    Action = item.Action!.Value
                });
            }

            return permissions;
        });

        private Func<IAccelByteSdk, string, LocalNamespaceContext> _NamespaceFetchFunction = ((sdk, aNamespace) =>
        {
            var response = sdk.GetBasicApi().Namespace.GetNamespaceContextOp.Execute(aNamespace).Ok();

            var context = new LocalNamespaceContext();
            if (response.Namespace != null)
                context.Namespace = response.Namespace;

            string sourceType = response.Type!.Value;
            if (sourceType == NamespaceContextType.Publisher.Value)
                context.Type = NamespaceType.Publisher;
            else if (sourceType == NamespaceContextType.Studio.Value)
                context.Type = NamespaceType.Studio;
            else if (sourceType == NamespaceContextType.Game.Value)
                context.Type = NamespaceType.Game;

            if (response.PublisherNamespace != null)
                context.PublisherNamespace = response.PublisherNamespace;

            if (response.StudioNamespace != null)
                context.StudioNamespace = response.StudioNamespace;

            return context;
        });

        private Func<IAccelByteSdk, string, Task<LocalNamespaceContext>> _NamespaceFetchFunctionAsync = (async (sdk, aNamespace) =>
        {
            var response = await sdk.GetBasicApi().Namespace.GetNamespaceContextOp.ExecuteAsync(aNamespace);
            var responseData = response.Ok();

            var context = new LocalNamespaceContext();
            if (responseData.Namespace != null)
                context.Namespace = responseData.Namespace;

            string sourceType = responseData.Type!.Value;
            if (sourceType == NamespaceContextType.Publisher.Value)
                context.Type = NamespaceType.Publisher;
            else if (sourceType == NamespaceContextType.Studio.Value)
                context.Type = NamespaceType.Studio;
            else if (sourceType == NamespaceContextType.Game.Value)
                context.Type = NamespaceType.Game;

            if (responseData.PublisherNamespace != null)
                context.PublisherNamespace = responseData.PublisherNamespace;

            if (responseData.StudioNamespace != null)
                context.StudioNamespace = responseData.StudioNamespace;

            return context;
        });

        public bool Validate(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
                var response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
                    throw new Exception("Server did not response to token validation request");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken)
        {
            try
            {
                var response = await sdk.GetIamApi().OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
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
                var response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
                    throw new Exception("Server did not response to token validation request");

                bool foundMatchingPermission = false;
                if ((response.Data.Permissions != null) && (response.Data.Permissions.Count > 0))
                {
                    foreach (var p in response.Data.Permissions)
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

                if (!foundMatchingPermission)
                {
                    if ((response.Data.NamespaceRoles != null) && (response.Data.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in response.Data.NamespaceRoles)
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
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken, string permission, int action)
        {
            try
            {
                var response = await sdk.GetIamApi().OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
                    throw new Exception("Server did not response to token validation request");

                bool foundMatchingPermission = false;
                if ((response.Data.Permissions != null) && (response.Data.Permissions.Count > 0))
                {
                    foreach (var p in response.Data.Permissions)
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

                if (!foundMatchingPermission)
                {
                    if ((response.Data.NamespaceRoles != null) && (response.Data.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in response.Data.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId, _FetchFunctionAsync);
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
                var response = sdk.GetIamApi().OAuth20.VerifyTokenV3Op.Execute(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    GetNamespaceContext(sdk, aNamespace, _NamespaceFetchFunction);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((response.Data.Permissions != null) && (response.Data.Permissions.Count > 0))
                {
                    foreach (var p in response.Data.Permissions)
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

                if (!foundMatchingPermission)
                {
                    if ((response.Data.NamespaceRoles != null) && (response.Data.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in response.Data.NamespaceRoles)
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
                }

                return foundMatchingPermission;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> ValidateAsync(IAccelByteSdk sdk, string accessToken, string permission, int action, string? aNamespace, string? userId)
        {
            try
            {
                var response = await sdk.GetIamApi().OAuth20.VerifyTokenV3Op.ExecuteAsync(accessToken);
                response.ThrowExceptionIfError();

                if (response.Data == null)
                    throw new Exception("Server did not response to token validation request");

                Dictionary<string, string> pParams = new Dictionary<string, string>();
                if (aNamespace != null)
                {
                    await GetNamespaceContextAsync(sdk, aNamespace, _NamespaceFetchFunctionAsync);
                    pParams.Add("namespace", aNamespace);
                }
                if (userId != null)
                    pParams.Add("userId", userId);

                bool foundMatchingPermission = false;
                if ((response.Data.Permissions != null) && (response.Data.Permissions.Count > 0))
                {
                    foreach (var p in response.Data.Permissions)
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

                if (!foundMatchingPermission)
                {
                    if ((response.Data.NamespaceRoles != null) && (response.Data.NamespaceRoles.Count > 0))
                    {
                        foreach (var r in response.Data.NamespaceRoles)
                        {
                            if (r.RoleId == null)
                                continue;

                            var permissions = await GetRolePermissionAsync(sdk, r.RoleId, _FetchFunctionAsync);
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
