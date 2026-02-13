// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Security
{
    public abstract class TokenValidator
    {
        private Dictionary<string, List<LocalPermissionItem>> _PermissionCache = new();

        private Dictionary<string, LocalNamespaceContext> _NamespaceContextCache = new();

        protected void AddPermissionToCache(string key, List<LocalPermissionItem> permissions)
        {
            _PermissionCache.Add(key, permissions);
        }

        protected void AddNamespaceContextToCache(string key, LocalNamespaceContext namespaceContext)
        {
            _NamespaceContextCache.Add(key, namespaceContext);
        }

        protected void ClearPermissionCache()
        {
            _PermissionCache.Clear();
        }

        protected void ClearNamespaceContextCache()
        {
            _NamespaceContextCache.Clear();
        }

        public void InvalidateCache()
        {
            _PermissionCache.Clear();
            _NamespaceContextCache.Clear();
        }

        protected virtual List<LocalPermissionItem> GetRolePermission(IAccelByteSdk sdk, string roleId, string roleNs,
            Func<IAccelByteSdk, string, string, List<LocalPermissionItem>> fetchFunction)
        {
            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            try
            {
                var permissions = fetchFunction.Invoke(sdk, roleId, roleNs);
                _PermissionCache[cacheKey] = permissions;
                return permissions;
            }
            catch
            {
                return new List<LocalPermissionItem>();
            }
        }

        protected virtual async Task<List<LocalPermissionItem>> GetRolePermissionAsync(IAccelByteSdk sdk, string roleId, string roleNs,
            Func<IAccelByteSdk, string, string, Task<List<LocalPermissionItem>>> fetchFunction)
        {
            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            try
            {
                var permissions = await fetchFunction.Invoke(sdk, roleId, roleNs);
                _PermissionCache[cacheKey] = permissions;
                return permissions;
            }
            catch
            {
                return new List<LocalPermissionItem>();
            }
        }

        protected virtual LocalNamespaceContext GetNamespaceContext(IAccelByteSdk sdk, string aNamespace,
            Func<IAccelByteSdk, string, LocalNamespaceContext> fetchFunction)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];
            try
            {
                var namespaceContext = fetchFunction.Invoke(sdk, aNamespace);
                if (!_NamespaceContextCache.ContainsKey(aNamespace))
                    _NamespaceContextCache.Add(aNamespace, namespaceContext);
                else
                    _NamespaceContextCache[aNamespace] = namespaceContext;
                return _NamespaceContextCache[aNamespace];
            }
            catch
            {
                return new LocalNamespaceContext();
            }
        }

        protected virtual async Task<LocalNamespaceContext> GetNamespaceContextAsync(IAccelByteSdk sdk, string aNamespace,
            Func<IAccelByteSdk, string, Task<LocalNamespaceContext>> fetchFunction)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];
            try
            {
                var namespaceContext = await fetchFunction.Invoke(sdk, aNamespace);
                if (!_NamespaceContextCache.ContainsKey(aNamespace))
                    _NamespaceContextCache.Add(aNamespace, namespaceContext);
                else
                    _NamespaceContextCache[aNamespace] = namespaceContext;
                return _NamespaceContextCache[aNamespace];
            }
            catch
            {
                return new LocalNamespaceContext();
            }
        }

        protected string ReplacePlaceholder(string sResource, Dictionary<string, string> parameters)
        {
            string result = sResource;
            foreach (var param in parameters)
                result = result.Replace("{" + param.Key + "}", param.Value);
            return result;
        }

        protected bool IsResourceAllowed(string accessPermissionResource, string requiredPermissionResource)
        {
            string[] requiredPermResSections = requiredPermissionResource.Split(':');
            int requiredPermResSectionLen = requiredPermResSections.Length;
            string[] accessPermResSections = accessPermissionResource.Split(':');
            int accessPermResSectionLen = accessPermResSections.Length;

            int minSectionLen = accessPermResSectionLen;

            if (minSectionLen > requiredPermResSectionLen)
                minSectionLen = requiredPermResSectionLen;

            for (int i = 0; i < minSectionLen; i++)
            {
                string userSection = accessPermResSections[i];
                string requiredSection = requiredPermResSections[i];


                if ((userSection != requiredSection) && (userSection != "*"))
                {
                    if (userSection.EndsWith("-") && (i > 0))
                    {
                        string previousUserSection = accessPermResSections[i - 1];
                        if (previousUserSection == "NAMESPACE")
                        {
                            if ((requiredSection.Contains("-")) &&
                                (requiredSection.Split("-").Length == 2) &&
                                (requiredSection.StartsWith(userSection)))
                                continue;

                            if (userSection == $"{requiredSection}-")
                                continue;

                            if (_NamespaceContextCache.ContainsKey(requiredSection))
                            {
                                LocalNamespaceContext context = _NamespaceContextCache[requiredSection];
                                if ((context.Type == NamespaceType.Game) && (userSection.StartsWith(context.StudioNamespace)))
                                    continue;
                            }
                        }
                    }

                    return false;
                }
            }

            if (accessPermResSectionLen == requiredPermResSectionLen)
                return true;

            if (accessPermResSectionLen < requiredPermResSectionLen)
            {
                if (accessPermResSections[accessPermResSectionLen - 1] == "*")
                {
                    if (accessPermResSectionLen < 2)
                        return true;

                    string segment = accessPermResSections[accessPermResSectionLen - 2];

                    if ((segment == "NAMESPACE") || (segment == "USER"))
                        return false;

                    return true;
                }

                return false;
            }

            for (int i = requiredPermResSectionLen; i < accessPermResSectionLen; i++)
            {
                if (accessPermResSections[i] != "*")
                    return false;
            }

            return true;
        }
    }
}
