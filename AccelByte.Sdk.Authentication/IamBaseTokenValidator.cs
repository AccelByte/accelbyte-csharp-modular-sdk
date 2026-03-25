// Copyright (c) 2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Authentication
{
    public class IamBaseTokenValidator : TokenValidator
    {
        public static List<LocalPermissionItem> ConvertPermissionItems(ModelRoleResponseV3 response)
        {
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
        }

        public static List<LocalPermissionItem> ConvertPermissionItems(ModelRolePermissionResponseV3 response)
        {
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
        }

        public static LocalNamespaceContext ConvertNamespaceContext(NamespaceContext response)
        {
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
        }

        protected Func<IAccelByteSdk, string, string, ITokenValidationConfig, List<LocalPermissionItem>> _PermissionFetchFunction = ((sdk, roleId, roleNs, tvConfig) =>
        {
            if (roleNs == "*" && tvConfig.AllowGlobalRoleFetchForWildcardNamespace)
            {
                var response = sdk.GetIamApi().Roles.AdminGetRoleV3Op
                    .Execute(roleId)
                    .EnsureSuccess();
                return ConvertPermissionItems(response);
            }
            else
            {
                var response = sdk.GetIamApi().OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                    .Execute(roleNs, roleId)
                    .EnsureSuccess();
                return ConvertPermissionItems(response);
            }
        });

        protected Func<IAccelByteSdk, string, string, ITokenValidationConfig, Task<List<LocalPermissionItem>>> _PermissionFetchFunctionAsync = (async (sdk, roleId, roleNs, tvConfig) =>
        {
            if (roleNs == "*" && tvConfig.AllowGlobalRoleFetchForWildcardNamespace)
            {
                var response = (await sdk.GetIamApi().Roles.AdminGetRoleV3Op
                    .ExecuteAsync(roleId))
                    .EnsureSuccess();
                return ConvertPermissionItems(response);
            }
            else
            {
                var response = (await sdk.GetIamApi().OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                    .ExecuteAsync(roleNs, roleId))
                    .EnsureSuccess();
                return ConvertPermissionItems(response);
            }
        });

        protected Func<IAccelByteSdk, string, ITokenValidationConfig, LocalNamespaceContext> _NamespaceFetchFunction = ((sdk, aNamespace, tvConfig) =>
        {
            var response = sdk.GetBasicApi().Namespace.GetNamespaceContextOp.Execute(aNamespace).EnsureSuccess();
            return ConvertNamespaceContext(response);
        });

        protected Func<IAccelByteSdk, string, ITokenValidationConfig, Task<LocalNamespaceContext>> _NamespaceFetchFunctionAsync = (async (sdk, aNamespace, tvConfig) =>
        {
            var response = await sdk.GetBasicApi().Namespace.GetNamespaceContextOp.ExecuteAsync(aNamespace);
            var responseData = response.EnsureSuccess();
            return ConvertNamespaceContext(responseData);
        });
    }
}
