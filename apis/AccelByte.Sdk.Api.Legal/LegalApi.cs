// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Legal;

namespace AccelByte.Sdk.Api.Legal
{
    public class LegalApi : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        private string _CustomBasePath = String.Empty;

        public Wrapper.Agreement Agreement
        {
            get
            {
                if (_Agreement == null)
                    _Agreement = new Wrapper.Agreement(_Sdk, _CustomBasePath);
                return _Agreement;
            }
        }
        private Wrapper.Agreement? _Agreement = null;

        public Wrapper.BaseLegalPolicies BaseLegalPolicies
        {
            get
            {
                if (_BaseLegalPolicies == null)
                    _BaseLegalPolicies = new Wrapper.BaseLegalPolicies(_Sdk, _CustomBasePath);
                return _BaseLegalPolicies;
            }
        }
        private Wrapper.BaseLegalPolicies? _BaseLegalPolicies = null;

        public Wrapper.LocalizedPolicyVersions LocalizedPolicyVersions
        {
            get
            {
                if (_LocalizedPolicyVersions == null)
                    _LocalizedPolicyVersions = new Wrapper.LocalizedPolicyVersions(_Sdk, _CustomBasePath);
                return _LocalizedPolicyVersions;
            }
        }
        private Wrapper.LocalizedPolicyVersions? _LocalizedPolicyVersions = null;

        public Wrapper.AgreementWithNamespace AgreementWithNamespace
        {
            get
            {
                if (_AgreementWithNamespace == null)
                    _AgreementWithNamespace = new Wrapper.AgreementWithNamespace(_Sdk, _CustomBasePath);
                return _AgreementWithNamespace;
            }
        }
        private Wrapper.AgreementWithNamespace? _AgreementWithNamespace = null;

        public Wrapper.BaseLegalPoliciesWithNamespace BaseLegalPoliciesWithNamespace
        {
            get
            {
                if (_BaseLegalPoliciesWithNamespace == null)
                    _BaseLegalPoliciesWithNamespace = new Wrapper.BaseLegalPoliciesWithNamespace(_Sdk, _CustomBasePath);
                return _BaseLegalPoliciesWithNamespace;
            }
        }
        private Wrapper.BaseLegalPoliciesWithNamespace? _BaseLegalPoliciesWithNamespace = null;

        public Wrapper.LocalizedPolicyVersionsWithNamespace LocalizedPolicyVersionsWithNamespace
        {
            get
            {
                if (_LocalizedPolicyVersionsWithNamespace == null)
                    _LocalizedPolicyVersionsWithNamespace = new Wrapper.LocalizedPolicyVersionsWithNamespace(_Sdk, _CustomBasePath);
                return _LocalizedPolicyVersionsWithNamespace;
            }
        }
        private Wrapper.LocalizedPolicyVersionsWithNamespace? _LocalizedPolicyVersionsWithNamespace = null;

        public Wrapper.PolicyVersionsWithNamespace PolicyVersionsWithNamespace
        {
            get
            {
                if (_PolicyVersionsWithNamespace == null)
                    _PolicyVersionsWithNamespace = new Wrapper.PolicyVersionsWithNamespace(_Sdk, _CustomBasePath);
                return _PolicyVersionsWithNamespace;
            }
        }
        private Wrapper.PolicyVersionsWithNamespace? _PolicyVersionsWithNamespace = null;

        public Wrapper.PoliciesWithNamespace PoliciesWithNamespace
        {
            get
            {
                if (_PoliciesWithNamespace == null)
                    _PoliciesWithNamespace = new Wrapper.PoliciesWithNamespace(_Sdk, _CustomBasePath);
                return _PoliciesWithNamespace;
            }
        }
        private Wrapper.PoliciesWithNamespace? _PoliciesWithNamespace = null;

        public Wrapper.AdminUserAgreement AdminUserAgreement
        {
            get
            {
                if (_AdminUserAgreement == null)
                    _AdminUserAgreement = new Wrapper.AdminUserAgreement(_Sdk, _CustomBasePath);
                return _AdminUserAgreement;
            }
        }
        private Wrapper.AdminUserAgreement? _AdminUserAgreement = null;

        public Wrapper.AdminUserEligibilities AdminUserEligibilities
        {
            get
            {
                if (_AdminUserEligibilities == null)
                    _AdminUserEligibilities = new Wrapper.AdminUserEligibilities(_Sdk, _CustomBasePath);
                return _AdminUserEligibilities;
            }
        }
        private Wrapper.AdminUserEligibilities? _AdminUserEligibilities = null;

        public Wrapper.Policies Policies
        {
            get
            {
                if (_Policies == null)
                    _Policies = new Wrapper.Policies(_Sdk, _CustomBasePath);
                return _Policies;
            }
        }
        private Wrapper.Policies? _Policies = null;

        public Wrapper.PolicyVersions PolicyVersions
        {
            get
            {
                if (_PolicyVersions == null)
                    _PolicyVersions = new Wrapper.PolicyVersions(_Sdk, _CustomBasePath);
                return _PolicyVersions;
            }
        }
        private Wrapper.PolicyVersions? _PolicyVersions = null;

        public Wrapper.UserInfo UserInfo
        {
            get
            {
                if (_UserInfo == null)
                    _UserInfo = new Wrapper.UserInfo(_Sdk, _CustomBasePath);
                return _UserInfo;
            }
        }
        private Wrapper.UserInfo? _UserInfo = null;

        public Wrapper.Anonymization Anonymization
        {
            get
            {
                if (_Anonymization == null)
                    _Anonymization = new Wrapper.Anonymization(_Sdk, _CustomBasePath);
                return _Anonymization;
            }
        }
        private Wrapper.Anonymization? _Anonymization = null;

        public Wrapper.Eligibilities Eligibilities
        {
            get
            {
                if (_Eligibilities == null)
                    _Eligibilities = new Wrapper.Eligibilities(_Sdk, _CustomBasePath);
                return _Eligibilities;
            }
        }
        private Wrapper.Eligibilities? _Eligibilities = null;

        public Wrapper.Utility Utility
        {
            get
            {
                if (_Utility == null)
                    _Utility = new Wrapper.Utility(_Sdk, _CustomBasePath);
                return _Utility;
            }
        }
        private Wrapper.Utility? _Utility = null;

        internal LegalApi(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }

        public LegalApi WithCustomBasePath(string value)
        {
            _CustomBasePath = value;
            return this;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class LegalApi_SdkExts
    {
        public static LegalApi GetLegalApi(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<LegalApi>("legal", () =>
            {
                string customPath = sdk.Configuration.ConfigRepository.GetCustomServiceBasePath("legal");
                if (customPath != "")
                    return (new LegalApi(sdk)).WithCustomBasePath(customPath);
                else
                    return new LegalApi(sdk);
            });
        }
    }
}