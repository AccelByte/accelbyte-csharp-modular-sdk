// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Legal.Model;

using AccelByte.Sdk.Tests.Mod.Repository;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class LegalTests : BaseServiceTests
    {
        public LegalTests() : base(true, IntegrationTestConfigRepository.Admin) { }

        public void CreateMarketingPreferencePolicyAndAcceptTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string basePolicyName = "CSharp Extend SDK Test Policy";
            string marketingPrefPolicyTypeId = String.Empty;
            string targetPolicyId = String.Empty;
            string targetPolicyVersionId;
            string targetLocalizedPolicyId;

            #region Get all legal policies
            List<RetrieveBasePolicyResponse>? bPolicies = _Sdk.GetLegalApi().BaseLegalPolicies.RetrieveAllLegalPoliciesOp
                .Execute()
                .EnsureSuccess();
            #endregion

            //Try to find existing policy with specified name.
            foreach (var bPolicy in bPolicies!)
            {
                if (bPolicy.BasePolicyName == basePolicyName)
                {
                    Assert.Greater(bPolicy!.Policies!.Count, 0);
                    targetPolicyId = bPolicy!.Policies![0].Id!;
                }
            }

            if (targetPolicyId == "")
            {
                //Policy does not exists. so we create it.

                //Retrieving policy type id for Marketing Preference
                List<RetrievePolicyTypeResponse> policyTypes = _Sdk.GetLegalApi().BaseLegalPolicies.OldRetrieveAllPolicyTypesOp
                    .SetOffset(0)
                    .Execute(100)
                    .EnsureSuccess();

                foreach (RetrievePolicyTypeResponse policyType in policyTypes!)
                {
                    if (policyType.PolicyTypeName!.Trim().ToLower() == "marketing preference")
                        marketingPrefPolicyTypeId = policyType.Id!;
                }
                Assert.IsNotEmpty(marketingPrefPolicyTypeId, "Marketing preference policy type not found.");

                #region Create a policy for marketing preference.
                CreateBasePolicyRequest createPolicy = new CreateBasePolicyRequest()
                {
                    TypeId = marketingPrefPolicyTypeId,
                    BasePolicyName = basePolicyName,
                    Description = "Testing CSharp Server SDK legal endpoints.",
                    Namespace = _Sdk.Namespace,
                    Tags = new List<string>() { "csharp", "server_sdk", "test" },
                    AffectedCountries = new List<string>() { "ID" },
                    AffectedClientIds = new List<string>()
                };

                CreateBasePolicyResponse bPolResp = _Sdk.GetLegalApi().BaseLegalPolicies.OldCreatePolicyOp
                    .SetBody(createPolicy)
                    .Execute()
                    .EnsureSuccess();
                #endregion
                targetPolicyId = bPolResp!.PolicyId!;
            }

            #region Get single policy by policy id
            List<RetrievePolicyVersionResponse> polVers = _Sdk.GetLegalApi().PolicyVersions.OldRetrieveSinglePolicyVersionOp
                .Execute(targetPolicyId)
                .EnsureSuccess();
            #endregion
            if (polVers!.Count <= 0)
            {
                //No version available, so create one
                CreatePolicyVersionRequest policyVersion = new CreatePolicyVersionRequest()
                {
                    DisplayVersion = "1.0.0",
                    Description = "Testing CSharp Server SDK legal endpoints.",
                    IsCommitted = false
                };

                #region Create policy version
                CreatePolicyVersionResponse polVerResp = _Sdk.GetLegalApi().PolicyVersions.OldCreatePolicyVersionOp
                    .SetBody(policyVersion)
                    .Execute(targetPolicyId)
                    .EnsureSuccess();
                #endregion
                targetPolicyVersionId = polVerResp!.Id!;
            }
            else
            {
                targetPolicyVersionId = polVers![0].Id!;
            }

            List<RetrieveLocalizedPolicyVersionResponse> locPolVers = _Sdk.GetLegalApi().LocalizedPolicyVersions.OldRetrieveLocalizedPolicyVersionsOp
                .Execute(targetPolicyVersionId)
                .EnsureSuccess();
            if (locPolVers.Count <= 0)
            {
                //No localized version available, so create one
                CreateLocalizedPolicyVersionRequest localPolicy = new CreateLocalizedPolicyVersionRequest()
                {
                    LocaleCode = "ID",
                    ContentType = "CSharp Extend SDK Legal Content for ID",
                    Description = "Testing CSharp Extend SDK legal endpoints."
                };

                CreateLocalizedPolicyVersionResponse locPolResp = _Sdk.GetLegalApi().LocalizedPolicyVersions.OldCreateLocalizedPolicyVersionOp
                    .SetBody(localPolicy)
                    .Execute(targetPolicyVersionId)
                    .EnsureSuccess();
                targetLocalizedPolicyId = locPolResp!.Id!;
            }
            else
            {
                targetLocalizedPolicyId = locPolVers![0].Id!;
            }

            #region Accepting an aggrement policy
            List<AcceptAgreementRequest> aggreementRequests = new List<AcceptAgreementRequest>()
            {
                new AcceptAgreementRequest()
                {
                    LocalizedPolicyVersionId = targetLocalizedPolicyId,
                    PolicyVersionId = targetPolicyVersionId,
                    PolicyId = targetPolicyId,
                    IsAccepted = true,
                    IsNeedToSendEventMarketing = false
                }
            };

            string userId = _Sdk.Configuration.Credential!.UserId;
            _Sdk.GetLegalApi().Agreement.ChangePreferenceConsentOp
                .SetBody(aggreementRequests)
                .Execute(_Sdk.Namespace, userId)
                .EnsureSuccess();
            #endregion

            #region Bulk accept policy
            _Sdk.GetLegalApi().Agreement.BulkAcceptVersionedPolicyOp
                .SetBody(aggreementRequests)
                .Execute()
                .EnsureSuccess();
            #endregion
        }

        [Test]
        public void RetrieveAgreementsPublicTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Get aggrements
            List<RetrieveAcceptedAgreementResponse> aggrs = _Sdk.GetLegalApi().Agreement.RetrieveAgreementsPublicOp
                .Execute()
                .EnsureSuccess();
            #endregion

            Assert.IsNotNull(aggrs);
        }
    }
}