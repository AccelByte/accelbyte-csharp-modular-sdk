// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
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
    public class DefaultTokenValidator : IamBaseTokenValidator, ITokenValidator, IAsyncTokenValidator
    {
        protected virtual bool InternalValidatePermission(IAccelByteSdk sdk, OauthmodelTokenResponseV3 response, string permission, int action, Dictionary<string, string> pParams)
        {
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

            if (!foundMatchingPermission)
            {
                if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = GetRolePermission(sdk, r.RoleId, roleNamespace, _PermissionFetchFunction);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
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

        protected virtual async Task<bool> InternalValidatePermissionAsync(IAccelByteSdk sdk, OauthmodelTokenResponseV3 response, string permission, int action, Dictionary<string, string> pParams)
        {
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

            if (!foundMatchingPermission)
            {
                if ((response.NamespaceRoles != null) && (response.NamespaceRoles.Count > 0))
                {
                    foreach (var r in response.NamespaceRoles)
                    {
                        if (r.RoleId == null)
                            continue;
                        string roleNamespace = r.Namespace!;

                        pParams["namespace"] = roleNamespace;
                        var permissions = await GetRolePermissionAsync(sdk, r.RoleId, roleNamespace, _PermissionFetchFunctionAsync);
                        foreach (var p in permissions)
                        {
                            string aResource = ReplacePlaceholder(p.Resource, pParams);
                            if (IsResourceAllowed(aResource, permission))
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
                string claimedNamespace = response.Data.Namespace!;

                var result = GetNamespaceContext(sdk, claimedNamespace, _NamespaceFetchFunction);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return InternalValidatePermission(sdk, response.Data, permission, action, pParams);
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
                string claimedNamespace = response.Data.Namespace!;

                var result = await GetNamespaceContextAsync(sdk, claimedNamespace, _NamespaceFetchFunctionAsync);
                if (result.IsError)
                    return false; //Access denied to namespace context error

                //Default filled with sdk's namespace
                Dictionary<string, string> pParams = new() { { "namespace", sdk.Namespace } };

                return await InternalValidatePermissionAsync(sdk, response.Data, permission, action, pParams);
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

                return InternalValidatePermission(sdk, response.Data, permission, action, pParams);
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

                return await InternalValidatePermissionAsync(sdk, response.Data, permission, action, pParams);
            }
            catch
            {
                return false;
            }
        }
    }
}
