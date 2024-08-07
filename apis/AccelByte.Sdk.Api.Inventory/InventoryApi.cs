// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Inventory;

namespace AccelByte.Sdk.Api.Inventory
{
    public class InventoryApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.AdminChainingOperations AdminChainingOperations
        {
            get
            {
                if (_AdminChainingOperations == null)
                    _AdminChainingOperations = new Wrapper.AdminChainingOperations(_Sdk, _CustomBasePath);
                return _AdminChainingOperations;
            }
        }
        private Wrapper.AdminChainingOperations? _AdminChainingOperations = null;

        public Wrapper.AdminIntegrationConfigurations AdminIntegrationConfigurations
        {
            get
            {
                if (_AdminIntegrationConfigurations == null)
                    _AdminIntegrationConfigurations = new Wrapper.AdminIntegrationConfigurations(_Sdk, _CustomBasePath);
                return _AdminIntegrationConfigurations;
            }
        }
        private Wrapper.AdminIntegrationConfigurations? _AdminIntegrationConfigurations = null;

        public Wrapper.AdminInventories AdminInventories
        {
            get
            {
                if (_AdminInventories == null)
                    _AdminInventories = new Wrapper.AdminInventories(_Sdk, _CustomBasePath);
                return _AdminInventories;
            }
        }
        private Wrapper.AdminInventories? _AdminInventories = null;

        public Wrapper.AdminItems AdminItems
        {
            get
            {
                if (_AdminItems == null)
                    _AdminItems = new Wrapper.AdminItems(_Sdk, _CustomBasePath);
                return _AdminItems;
            }
        }
        private Wrapper.AdminItems? _AdminItems = null;

        public Wrapper.AdminInventoryConfigurations AdminInventoryConfigurations
        {
            get
            {
                if (_AdminInventoryConfigurations == null)
                    _AdminInventoryConfigurations = new Wrapper.AdminInventoryConfigurations(_Sdk, _CustomBasePath);
                return _AdminInventoryConfigurations;
            }
        }
        private Wrapper.AdminInventoryConfigurations? _AdminInventoryConfigurations = null;

        public Wrapper.AdminItemTypes AdminItemTypes
        {
            get
            {
                if (_AdminItemTypes == null)
                    _AdminItemTypes = new Wrapper.AdminItemTypes(_Sdk, _CustomBasePath);
                return _AdminItemTypes;
            }
        }
        private Wrapper.AdminItemTypes? _AdminItemTypes = null;

        public Wrapper.AdminTags AdminTags
        {
            get
            {
                if (_AdminTags == null)
                    _AdminTags = new Wrapper.AdminTags(_Sdk, _CustomBasePath);
                return _AdminTags;
            }
        }
        private Wrapper.AdminTags? _AdminTags = null;

        public Wrapper.PublicInventoryConfigurations PublicInventoryConfigurations
        {
            get
            {
                if (_PublicInventoryConfigurations == null)
                    _PublicInventoryConfigurations = new Wrapper.PublicInventoryConfigurations(_Sdk, _CustomBasePath);
                return _PublicInventoryConfigurations;
            }
        }
        private Wrapper.PublicInventoryConfigurations? _PublicInventoryConfigurations = null;

        public Wrapper.PublicItemTypes PublicItemTypes
        {
            get
            {
                if (_PublicItemTypes == null)
                    _PublicItemTypes = new Wrapper.PublicItemTypes(_Sdk, _CustomBasePath);
                return _PublicItemTypes;
            }
        }
        private Wrapper.PublicItemTypes? _PublicItemTypes = null;

        public Wrapper.PublicTags PublicTags
        {
            get
            {
                if (_PublicTags == null)
                    _PublicTags = new Wrapper.PublicTags(_Sdk, _CustomBasePath);
                return _PublicTags;
            }
        }
        private Wrapper.PublicTags? _PublicTags = null;

        public Wrapper.PublicInventories PublicInventories
        {
            get
            {
                if (_PublicInventories == null)
                    _PublicInventories = new Wrapper.PublicInventories(_Sdk, _CustomBasePath);
                return _PublicInventories;
            }
        }
        private Wrapper.PublicInventories? _PublicInventories = null;

        public Wrapper.PublicItems PublicItems
        {
            get
            {
                if (_PublicItems == null)
                    _PublicItems = new Wrapper.PublicItems(_Sdk, _CustomBasePath);
                return _PublicItems;
            }
        }
        private Wrapper.PublicItems? _PublicItems = null;

        internal InventoryApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public InventoryApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class InventoryApi_SdkExts
    {
        public static InventoryApi GetInventoryApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<InventoryApi>("inventory", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("inventory");
                if (customPath != "")
                    return (new InventoryApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new InventoryApi(sdk);
            });
        }
    }
}