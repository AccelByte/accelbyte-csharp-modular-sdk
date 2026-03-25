// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccelByte.Sdk.Core.Net.Http;

namespace AccelByte.Sdk.Core.Security
{
    public abstract class TokenValidator
    {
        private ConcurrentDictionary<string, List<LocalPermissionItem>> _PermissionCache = new();

        private ConcurrentDictionary<string, LocalNamespaceContext> _NamespaceContextCache = new();

        protected void AddPermissionToCache(string key, List<LocalPermissionItem> permissions)
        {
            _PermissionCache.TryAdd(key, permissions);
        }

        protected void AddNamespaceContextToCache(string key, LocalNamespaceContext namespaceContext)
        {
            if (!_NamespaceContextCache.ContainsKey(key))
                _NamespaceContextCache.TryAdd(key, namespaceContext);
            else
                _NamespaceContextCache[key] = namespaceContext;
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

        protected LocalNamespaceContext? GetCachedNamespaceContext(string key)
        {
            if (_NamespaceContextCache.ContainsKey(key))
                return _NamespaceContextCache[key];
            else
                return null;
        }

        protected virtual LocalNamespaceContext DeriveAndCacheGameNamespaceContext(string aNamespace, string appNamespace, LocalNamespaceContext context)
        {
            AddNamespaceContextToCache(appNamespace, context);
            if (context.StudioNamespace != "")
            {
                var studioContext = new LocalNamespaceContext()
                {
                    Namespace = context.StudioNamespace,
                    Type = NamespaceType.Studio,
                    PublisherNamespace = context.PublisherNamespace,
                    StudioNamespace = ""
                };
                AddNamespaceContextToCache(context.StudioNamespace, studioContext);
            }
            if (context.PublisherNamespace != "")
            {
                var publisherContext = new LocalNamespaceContext()
                {
                    Namespace = context.PublisherNamespace,
                    Type = NamespaceType.Publisher,
                    PublisherNamespace = "",
                    StudioNamespace = ""
                };
                AddNamespaceContextToCache(context.PublisherNamespace, publisherContext);
            }
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];
            else
                return new LocalNamespaceContext($"Access denied to invalid namespace context {aNamespace}.");
        }

        protected virtual List<LocalPermissionItem> GetRolePermission(IAccelByteSdk sdk, string roleId, string roleNs,
            Func<IAccelByteSdk, string, string, ITokenValidationConfig, List<LocalPermissionItem>> fetchFunction)
        {
            // Strips the trailing "-" from the role namespace, as Studio namespace values are typically suffixed with "-" which can cause lookup errors.
            if (roleNs.EndsWith("-"))
                roleNs = roleNs.Substring(0, roleNs.Length - 1);

            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                var permissions = fetchFunction.Invoke(sdk, roleId, roleNs, tvConfig);
                _PermissionCache[cacheKey] = permissions;
                return permissions;
            }
            catch
            {
                if (tvConfig.SuppressGetRoleError)
                    return new List<LocalPermissionItem>();
                else
                    throw;
            }
        }

        protected virtual async Task<List<LocalPermissionItem>> GetRolePermissionAsync(IAccelByteSdk sdk, string roleId, string roleNs,
            Func<IAccelByteSdk, string, string, ITokenValidationConfig, Task<List<LocalPermissionItem>>> fetchFunction)
        {
            // Strips the trailing "-" from the role namespace, as Studio namespace values are typically suffixed with "-" which can cause lookup errors.
            if (roleNs.EndsWith("-"))
                roleNs = roleNs.Substring(0, roleNs.Length - 1);

            string cacheKey = $"{roleId}-{roleNs}";
            if (_PermissionCache.ContainsKey(cacheKey))
                return _PermissionCache[cacheKey];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                var permissions = await fetchFunction.Invoke(sdk, roleId, roleNs, tvConfig);
                _PermissionCache[cacheKey] = permissions;
                return permissions;
            }
            catch
            {
                if (tvConfig.SuppressGetRoleError)
                    return new List<LocalPermissionItem>();
                else
                    throw;
            }
        }

        protected virtual LocalNamespaceContext GetNamespaceContext(IAccelByteSdk sdk, string aNamespace,
            Func<IAccelByteSdk, string, ITokenValidationConfig, LocalNamespaceContext> fetchFunction)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                var namespaceContext = fetchFunction.Invoke(sdk, aNamespace, tvConfig);
                AddNamespaceContextToCache(aNamespace, namespaceContext);
                return _NamespaceContextCache[aNamespace];
            }
            catch (ApiResponseException)
            {
                // Failed to fetch context for aNamespace (likely a parent namespace
                // the app doesn't have permission to query). Fall back to fetching the
                // app's own game namespace and derive the hierarchy from it.

                string appNamespace = sdk.Configuration.ConfigRepository.Namespace;
                if (appNamespace == "" || appNamespace == aNamespace)
                    return new LocalNamespaceContext($"Namespace is empty or access denied accessing namespace context for {appNamespace}");

                try
                {
                    var appNamespaceContext = fetchFunction.Invoke(sdk, appNamespace, tvConfig);
                    return DeriveAndCacheGameNamespaceContext(aNamespace, appNamespace, appNamespaceContext);
                }
                catch (Exception x)
                {
                    return new LocalNamespaceContext(x.Message);
                }
            }
        }

        protected virtual async Task<LocalNamespaceContext> GetNamespaceContextAsync(IAccelByteSdk sdk, string aNamespace,
            Func<IAccelByteSdk, string, ITokenValidationConfig, Task<LocalNamespaceContext>> fetchFunction)
        {
            if (_NamespaceContextCache.ContainsKey(aNamespace))
                return _NamespaceContextCache[aNamespace];

            ITokenValidationConfig tvConfig;
            if (sdk.Configuration is ITokenValidationConfig tempConfig)
                tvConfig = tempConfig;
            else
                tvConfig = new DefaultTokenValidationConfig();

            try
            {
                var namespaceContext = await fetchFunction.Invoke(sdk, aNamespace, tvConfig);
                AddNamespaceContextToCache(aNamespace, namespaceContext);
                return _NamespaceContextCache[aNamespace];
            }
            catch (ApiResponseException)
            {
                // Failed to fetch context for aNamespace (likely a parent namespace
                // the app doesn't have permission to query). Fall back to fetching the
                // app's own game namespace and derive the hierarchy from it.

                string appNamespace = sdk.Configuration.ConfigRepository.Namespace;
                if (appNamespace == "" || appNamespace == aNamespace)
                    return new LocalNamespaceContext($"Namespace is empty or access denied accessing namespace context for {appNamespace}");

                try
                {
                    var appNamespaceContext = await fetchFunction.Invoke(sdk, appNamespace, tvConfig);
                    return DeriveAndCacheGameNamespaceContext(aNamespace, appNamespace, appNamespaceContext);
                }
                catch (Exception x)
                {
                    return new LocalNamespaceContext(x.Message);
                }
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
