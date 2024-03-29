// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class Agreement
    {
        private readonly IAccelByteSdk _sdk;

        public Agreement(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ChangePreferenceConsent.ChangePreferenceConsentBuilder ChangePreferenceConsentOp
        {
            get { return new Operation.ChangePreferenceConsent.ChangePreferenceConsentBuilder(_sdk); }
        }
        public RetrieveAcceptedAgreements.RetrieveAcceptedAgreementsBuilder RetrieveAcceptedAgreementsOp
        {
            get { return new Operation.RetrieveAcceptedAgreements.RetrieveAcceptedAgreementsBuilder(_sdk); }
        }
        public RetrieveAllUsersByPolicyVersion.RetrieveAllUsersByPolicyVersionBuilder RetrieveAllUsersByPolicyVersionOp
        {
            get { return new Operation.RetrieveAllUsersByPolicyVersion.RetrieveAllUsersByPolicyVersionBuilder(_sdk); }
        }
        public ChangePreferenceConsent1.ChangePreferenceConsent1Builder ChangePreferenceConsent1Op
        {
            get { return new Operation.ChangePreferenceConsent1.ChangePreferenceConsent1Builder(_sdk); }
        }
        public AcceptVersionedPolicy.AcceptVersionedPolicyBuilder AcceptVersionedPolicyOp
        {
            get { return new Operation.AcceptVersionedPolicy.AcceptVersionedPolicyBuilder(_sdk); }
        }
        public RetrieveAgreementsPublic.RetrieveAgreementsPublicBuilder RetrieveAgreementsPublicOp
        {
            get { return new Operation.RetrieveAgreementsPublic.RetrieveAgreementsPublicBuilder(_sdk); }
        }
        public BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder BulkAcceptVersionedPolicyOp
        {
            get { return new Operation.BulkAcceptVersionedPolicy.BulkAcceptVersionedPolicyBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder IndirectBulkAcceptVersionedPolicyV2Op
        {
            get { return new Operation.IndirectBulkAcceptVersionedPolicyV2.IndirectBulkAcceptVersionedPolicyV2Builder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder IndirectBulkAcceptVersionedPolicy1Op
        {
            get { return new Operation.IndirectBulkAcceptVersionedPolicy1.IndirectBulkAcceptVersionedPolicy1Builder(_sdk); }
        }
        #endregion

        public void ChangePreferenceConsent(ChangePreferenceConsent input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAcceptedAgreements(RetrieveAcceptedAgreements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PagedRetrieveUserAcceptedAgreementResponse? RetrieveAllUsersByPolicyVersion(RetrieveAllUsersByPolicyVersion input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void ChangePreferenceConsent1(ChangePreferenceConsent1 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AcceptVersionedPolicy(AcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveAcceptedAgreementResponse>? RetrieveAgreementsPublic(RetrieveAgreementsPublic input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AcceptAgreementResponse? BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicy input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.AcceptAgreementResponse? IndirectBulkAcceptVersionedPolicy1(IndirectBulkAcceptVersionedPolicy1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}