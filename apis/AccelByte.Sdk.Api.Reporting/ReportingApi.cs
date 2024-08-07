// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Reporting;

namespace AccelByte.Sdk.Api.Reporting
{
    public class ReportingApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.AdminExtensionCategoriesAndAutoModerationActions AdminExtensionCategoriesAndAutoModerationActions
        {
            get
            {
                if (_AdminExtensionCategoriesAndAutoModerationActions == null)
                    _AdminExtensionCategoriesAndAutoModerationActions = new Wrapper.AdminExtensionCategoriesAndAutoModerationActions(_Sdk, _CustomBasePath);
                return _AdminExtensionCategoriesAndAutoModerationActions;
            }
        }
        private Wrapper.AdminExtensionCategoriesAndAutoModerationActions? _AdminExtensionCategoriesAndAutoModerationActions = null;

        public Wrapper.AdminConfigurations AdminConfigurations
        {
            get
            {
                if (_AdminConfigurations == null)
                    _AdminConfigurations = new Wrapper.AdminConfigurations(_Sdk, _CustomBasePath);
                return _AdminConfigurations;
            }
        }
        private Wrapper.AdminConfigurations? _AdminConfigurations = null;

        public Wrapper.AdminReasons AdminReasons
        {
            get
            {
                if (_AdminReasons == null)
                    _AdminReasons = new Wrapper.AdminReasons(_Sdk, _CustomBasePath);
                return _AdminReasons;
            }
        }
        private Wrapper.AdminReasons? _AdminReasons = null;

        public Wrapper.AdminReports AdminReports
        {
            get
            {
                if (_AdminReports == null)
                    _AdminReports = new Wrapper.AdminReports(_Sdk, _CustomBasePath);
                return _AdminReports;
            }
        }
        private Wrapper.AdminReports? _AdminReports = null;

        public Wrapper.AdminModerationRule AdminModerationRule
        {
            get
            {
                if (_AdminModerationRule == null)
                    _AdminModerationRule = new Wrapper.AdminModerationRule(_Sdk, _CustomBasePath);
                return _AdminModerationRule;
            }
        }
        private Wrapper.AdminModerationRule? _AdminModerationRule = null;

        public Wrapper.AdminTickets AdminTickets
        {
            get
            {
                if (_AdminTickets == null)
                    _AdminTickets = new Wrapper.AdminTickets(_Sdk, _CustomBasePath);
                return _AdminTickets;
            }
        }
        private Wrapper.AdminTickets? _AdminTickets = null;

        public Wrapper.PublicReasons PublicReasons
        {
            get
            {
                if (_PublicReasons == null)
                    _PublicReasons = new Wrapper.PublicReasons(_Sdk, _CustomBasePath);
                return _PublicReasons;
            }
        }
        private Wrapper.PublicReasons? _PublicReasons = null;

        public Wrapper.PublicReports PublicReports
        {
            get
            {
                if (_PublicReports == null)
                    _PublicReports = new Wrapper.PublicReports(_Sdk, _CustomBasePath);
                return _PublicReports;
            }
        }
        private Wrapper.PublicReports? _PublicReports = null;

        internal ReportingApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public ReportingApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class ReportingApi_SdkExts
    {
        public static ReportingApi GetReportingApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<ReportingApi>("reporting", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("reporting");
                if (customPath != "")
                    return (new ReportingApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new ReportingApi(sdk);
            });
        }
    }
}