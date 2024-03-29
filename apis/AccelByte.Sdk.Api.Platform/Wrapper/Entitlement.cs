// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Entitlement
    {
        private readonly IAccelByteSdk _sdk;

        public Entitlement(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public QueryEntitlements.QueryEntitlementsBuilder QueryEntitlementsOp
        {
            get { return new Operation.QueryEntitlements.QueryEntitlementsBuilder(_sdk); }
        }
        public QueryEntitlements1.QueryEntitlements1Builder QueryEntitlements1Op
        {
            get { return new Operation.QueryEntitlements1.QueryEntitlements1Builder(_sdk); }
        }
        public EnableEntitlementOriginFeature.EnableEntitlementOriginFeatureBuilder EnableEntitlementOriginFeatureOp
        {
            get { return new Operation.EnableEntitlementOriginFeature.EnableEntitlementOriginFeatureBuilder(_sdk); }
        }
        public GetEntitlementConfigInfo.GetEntitlementConfigInfoBuilder GetEntitlementConfigInfoOp
        {
            get { return new Operation.GetEntitlementConfigInfo.GetEntitlementConfigInfoBuilder(_sdk); }
        }
        public GrantEntitlements.GrantEntitlementsBuilder GrantEntitlementsOp
        {
            get { return new Operation.GrantEntitlements.GrantEntitlementsBuilder(_sdk); }
        }
        public RevokeEntitlements.RevokeEntitlementsBuilder RevokeEntitlementsOp
        {
            get { return new Operation.RevokeEntitlements.RevokeEntitlementsBuilder(_sdk); }
        }
        public GetEntitlement.GetEntitlementBuilder GetEntitlementOp
        {
            get { return new Operation.GetEntitlement.GetEntitlementBuilder(_sdk); }
        }
        public GetPlatformEntitlementConfig.GetPlatformEntitlementConfigBuilder GetPlatformEntitlementConfigOp
        {
            get { return new Operation.GetPlatformEntitlementConfig.GetPlatformEntitlementConfigBuilder(_sdk); }
        }
        public UpdatePlatformEntitlementConfig.UpdatePlatformEntitlementConfigBuilder UpdatePlatformEntitlementConfigOp
        {
            get { return new Operation.UpdatePlatformEntitlementConfig.UpdatePlatformEntitlementConfigBuilder(_sdk); }
        }
        public QueryUserEntitlements.QueryUserEntitlementsBuilder QueryUserEntitlementsOp
        {
            get { return new Operation.QueryUserEntitlements.QueryUserEntitlementsBuilder(_sdk); }
        }
        public GrantUserEntitlement.GrantUserEntitlementBuilder GrantUserEntitlementOp
        {
            get { return new Operation.GrantUserEntitlement.GrantUserEntitlementBuilder(_sdk); }
        }
        public GetUserAppEntitlementByAppId.GetUserAppEntitlementByAppIdBuilder GetUserAppEntitlementByAppIdOp
        {
            get { return new Operation.GetUserAppEntitlementByAppId.GetUserAppEntitlementByAppIdBuilder(_sdk); }
        }
        public QueryUserEntitlementsByAppType.QueryUserEntitlementsByAppTypeBuilder QueryUserEntitlementsByAppTypeOp
        {
            get { return new Operation.QueryUserEntitlementsByAppType.QueryUserEntitlementsByAppTypeBuilder(_sdk); }
        }
        public GetUserEntitlementByItemId.GetUserEntitlementByItemIdBuilder GetUserEntitlementByItemIdOp
        {
            get { return new Operation.GetUserEntitlementByItemId.GetUserEntitlementByItemIdBuilder(_sdk); }
        }
        public GetUserActiveEntitlementsByItemIds.GetUserActiveEntitlementsByItemIdsBuilder GetUserActiveEntitlementsByItemIdsOp
        {
            get { return new Operation.GetUserActiveEntitlementsByItemIds.GetUserActiveEntitlementsByItemIdsBuilder(_sdk); }
        }
        public GetUserEntitlementBySku.GetUserEntitlementBySkuBuilder GetUserEntitlementBySkuOp
        {
            get { return new Operation.GetUserEntitlementBySku.GetUserEntitlementBySkuBuilder(_sdk); }
        }
        public ExistsAnyUserActiveEntitlement.ExistsAnyUserActiveEntitlementBuilder ExistsAnyUserActiveEntitlementOp
        {
            get { return new Operation.ExistsAnyUserActiveEntitlement.ExistsAnyUserActiveEntitlementBuilder(_sdk); }
        }
        public ExistsAnyUserActiveEntitlementByItemIds.ExistsAnyUserActiveEntitlementByItemIdsBuilder ExistsAnyUserActiveEntitlementByItemIdsOp
        {
            get { return new Operation.ExistsAnyUserActiveEntitlementByItemIds.ExistsAnyUserActiveEntitlementByItemIdsBuilder(_sdk); }
        }
        public GetUserAppEntitlementOwnershipByAppId.GetUserAppEntitlementOwnershipByAppIdBuilder GetUserAppEntitlementOwnershipByAppIdOp
        {
            get { return new Operation.GetUserAppEntitlementOwnershipByAppId.GetUserAppEntitlementOwnershipByAppIdBuilder(_sdk); }
        }
        public GetUserEntitlementOwnershipByItemId.GetUserEntitlementOwnershipByItemIdBuilder GetUserEntitlementOwnershipByItemIdOp
        {
            get { return new Operation.GetUserEntitlementOwnershipByItemId.GetUserEntitlementOwnershipByItemIdBuilder(_sdk); }
        }
        public GetUserEntitlementOwnershipByItemIds.GetUserEntitlementOwnershipByItemIdsBuilder GetUserEntitlementOwnershipByItemIdsOp
        {
            get { return new Operation.GetUserEntitlementOwnershipByItemIds.GetUserEntitlementOwnershipByItemIdsBuilder(_sdk); }
        }
        public GetUserEntitlementOwnershipBySku.GetUserEntitlementOwnershipBySkuBuilder GetUserEntitlementOwnershipBySkuOp
        {
            get { return new Operation.GetUserEntitlementOwnershipBySku.GetUserEntitlementOwnershipBySkuBuilder(_sdk); }
        }
        public RevokeAllEntitlements.RevokeAllEntitlementsBuilder RevokeAllEntitlementsOp
        {
            get { return new Operation.RevokeAllEntitlements.RevokeAllEntitlementsBuilder(_sdk); }
        }
        public RevokeUserEntitlements.RevokeUserEntitlementsBuilder RevokeUserEntitlementsOp
        {
            get { return new Operation.RevokeUserEntitlements.RevokeUserEntitlementsBuilder(_sdk); }
        }
        public GetUserEntitlement.GetUserEntitlementBuilder GetUserEntitlementOp
        {
            get { return new Operation.GetUserEntitlement.GetUserEntitlementBuilder(_sdk); }
        }
        public UpdateUserEntitlement.UpdateUserEntitlementBuilder UpdateUserEntitlementOp
        {
            get { return new Operation.UpdateUserEntitlement.UpdateUserEntitlementBuilder(_sdk); }
        }
        public ConsumeUserEntitlement.ConsumeUserEntitlementBuilder ConsumeUserEntitlementOp
        {
            get { return new Operation.ConsumeUserEntitlement.ConsumeUserEntitlementBuilder(_sdk); }
        }
        public DisableUserEntitlement.DisableUserEntitlementBuilder DisableUserEntitlementOp
        {
            get { return new Operation.DisableUserEntitlement.DisableUserEntitlementBuilder(_sdk); }
        }
        public EnableUserEntitlement.EnableUserEntitlementBuilder EnableUserEntitlementOp
        {
            get { return new Operation.EnableUserEntitlement.EnableUserEntitlementBuilder(_sdk); }
        }
        public GetUserEntitlementHistories.GetUserEntitlementHistoriesBuilder GetUserEntitlementHistoriesOp
        {
            get { return new Operation.GetUserEntitlementHistories.GetUserEntitlementHistoriesBuilder(_sdk); }
        }
        public RevokeUserEntitlement.RevokeUserEntitlementBuilder RevokeUserEntitlementOp
        {
            get { return new Operation.RevokeUserEntitlement.RevokeUserEntitlementBuilder(_sdk); }
        }
        public RevokeUserEntitlementByUseCount.RevokeUserEntitlementByUseCountBuilder RevokeUserEntitlementByUseCountOp
        {
            get { return new Operation.RevokeUserEntitlementByUseCount.RevokeUserEntitlementByUseCountBuilder(_sdk); }
        }
        public PreCheckRevokeUserEntitlementByUseCount.PreCheckRevokeUserEntitlementByUseCountBuilder PreCheckRevokeUserEntitlementByUseCountOp
        {
            get { return new Operation.PreCheckRevokeUserEntitlementByUseCount.PreCheckRevokeUserEntitlementByUseCountBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public RevokeUseCount.RevokeUseCountBuilder RevokeUseCountOp
        {
            get { return new Operation.RevokeUseCount.RevokeUseCountBuilder(_sdk); }
        }
        public SellUserEntitlement.SellUserEntitlementBuilder SellUserEntitlementOp
        {
            get { return new Operation.SellUserEntitlement.SellUserEntitlementBuilder(_sdk); }
        }
        public PublicExistsAnyMyActiveEntitlement.PublicExistsAnyMyActiveEntitlementBuilder PublicExistsAnyMyActiveEntitlementOp
        {
            get { return new Operation.PublicExistsAnyMyActiveEntitlement.PublicExistsAnyMyActiveEntitlementBuilder(_sdk); }
        }
        public PublicGetMyAppEntitlementOwnershipByAppId.PublicGetMyAppEntitlementOwnershipByAppIdBuilder PublicGetMyAppEntitlementOwnershipByAppIdOp
        {
            get { return new Operation.PublicGetMyAppEntitlementOwnershipByAppId.PublicGetMyAppEntitlementOwnershipByAppIdBuilder(_sdk); }
        }
        public PublicGetMyEntitlementOwnershipByItemId.PublicGetMyEntitlementOwnershipByItemIdBuilder PublicGetMyEntitlementOwnershipByItemIdOp
        {
            get { return new Operation.PublicGetMyEntitlementOwnershipByItemId.PublicGetMyEntitlementOwnershipByItemIdBuilder(_sdk); }
        }
        public PublicGetMyEntitlementOwnershipBySku.PublicGetMyEntitlementOwnershipBySkuBuilder PublicGetMyEntitlementOwnershipBySkuOp
        {
            get { return new Operation.PublicGetMyEntitlementOwnershipBySku.PublicGetMyEntitlementOwnershipBySkuBuilder(_sdk); }
        }
        public PublicGetEntitlementOwnershipToken.PublicGetEntitlementOwnershipTokenBuilder PublicGetEntitlementOwnershipTokenOp
        {
            get { return new Operation.PublicGetEntitlementOwnershipToken.PublicGetEntitlementOwnershipTokenBuilder(_sdk); }
        }
        public PublicQueryUserEntitlements.PublicQueryUserEntitlementsBuilder PublicQueryUserEntitlementsOp
        {
            get { return new Operation.PublicQueryUserEntitlements.PublicQueryUserEntitlementsBuilder(_sdk); }
        }
        public PublicGetUserAppEntitlementByAppId.PublicGetUserAppEntitlementByAppIdBuilder PublicGetUserAppEntitlementByAppIdOp
        {
            get { return new Operation.PublicGetUserAppEntitlementByAppId.PublicGetUserAppEntitlementByAppIdBuilder(_sdk); }
        }
        public PublicQueryUserEntitlementsByAppType.PublicQueryUserEntitlementsByAppTypeBuilder PublicQueryUserEntitlementsByAppTypeOp
        {
            get { return new Operation.PublicQueryUserEntitlementsByAppType.PublicQueryUserEntitlementsByAppTypeBuilder(_sdk); }
        }
        public PublicGetUserEntitlementsByIds.PublicGetUserEntitlementsByIdsBuilder PublicGetUserEntitlementsByIdsOp
        {
            get { return new Operation.PublicGetUserEntitlementsByIds.PublicGetUserEntitlementsByIdsBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetUserEntitlementByItemId.PublicGetUserEntitlementByItemIdBuilder PublicGetUserEntitlementByItemIdOp
        {
            get { return new Operation.PublicGetUserEntitlementByItemId.PublicGetUserEntitlementByItemIdBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public PublicGetUserEntitlementBySku.PublicGetUserEntitlementBySkuBuilder PublicGetUserEntitlementBySkuOp
        {
            get { return new Operation.PublicGetUserEntitlementBySku.PublicGetUserEntitlementBySkuBuilder(_sdk); }
        }
        public PublicUserEntitlementHistory.PublicUserEntitlementHistoryBuilder PublicUserEntitlementHistoryOp
        {
            get { return new Operation.PublicUserEntitlementHistory.PublicUserEntitlementHistoryBuilder(_sdk); }
        }
        public PublicExistsAnyUserActiveEntitlement.PublicExistsAnyUserActiveEntitlementBuilder PublicExistsAnyUserActiveEntitlementOp
        {
            get { return new Operation.PublicExistsAnyUserActiveEntitlement.PublicExistsAnyUserActiveEntitlementBuilder(_sdk); }
        }
        public PublicGetUserAppEntitlementOwnershipByAppId.PublicGetUserAppEntitlementOwnershipByAppIdBuilder PublicGetUserAppEntitlementOwnershipByAppIdOp
        {
            get { return new Operation.PublicGetUserAppEntitlementOwnershipByAppId.PublicGetUserAppEntitlementOwnershipByAppIdBuilder(_sdk); }
        }
        public PublicGetUserEntitlementOwnershipByItemId.PublicGetUserEntitlementOwnershipByItemIdBuilder PublicGetUserEntitlementOwnershipByItemIdOp
        {
            get { return new Operation.PublicGetUserEntitlementOwnershipByItemId.PublicGetUserEntitlementOwnershipByItemIdBuilder(_sdk); }
        }
        public PublicGetUserEntitlementOwnershipByItemIds.PublicGetUserEntitlementOwnershipByItemIdsBuilder PublicGetUserEntitlementOwnershipByItemIdsOp
        {
            get { return new Operation.PublicGetUserEntitlementOwnershipByItemIds.PublicGetUserEntitlementOwnershipByItemIdsBuilder(_sdk); }
        }
        public PublicGetUserEntitlementOwnershipBySku.PublicGetUserEntitlementOwnershipBySkuBuilder PublicGetUserEntitlementOwnershipBySkuOp
        {
            get { return new Operation.PublicGetUserEntitlementOwnershipBySku.PublicGetUserEntitlementOwnershipBySkuBuilder(_sdk); }
        }
        public PublicGetUserEntitlement.PublicGetUserEntitlementBuilder PublicGetUserEntitlementOp
        {
            get { return new Operation.PublicGetUserEntitlement.PublicGetUserEntitlementBuilder(_sdk); }
        }
        public PublicConsumeUserEntitlement.PublicConsumeUserEntitlementBuilder PublicConsumeUserEntitlementOp
        {
            get { return new Operation.PublicConsumeUserEntitlement.PublicConsumeUserEntitlementBuilder(_sdk); }
        }
        public PublicSellUserEntitlement.PublicSellUserEntitlementBuilder PublicSellUserEntitlementOp
        {
            get { return new Operation.PublicSellUserEntitlement.PublicSellUserEntitlementBuilder(_sdk); }
        }
        public PublicSplitUserEntitlement.PublicSplitUserEntitlementBuilder PublicSplitUserEntitlementOp
        {
            get { return new Operation.PublicSplitUserEntitlement.PublicSplitUserEntitlementBuilder(_sdk); }
        }
        public PublicTransferUserEntitlement.PublicTransferUserEntitlementBuilder PublicTransferUserEntitlementOp
        {
            get { return new Operation.PublicTransferUserEntitlement.PublicTransferUserEntitlementBuilder(_sdk); }
        }
        #endregion

        public Model.EntitlementPagingSlicedResult? QueryEntitlements(QueryEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPagingSlicedResult? QueryEntitlements1(QueryEntitlements1 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementConfigInfo? EnableEntitlementOriginFeature(EnableEntitlementOriginFeature input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementConfigInfo? GetEntitlementConfigInfo(GetEntitlementConfigInfo input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkEntitlementGrantResult? GrantEntitlements(GrantEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkEntitlementRevokeResult? RevokeEntitlements(RevokeEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetEntitlement(GetEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPlatformConfigInfo? GetPlatformEntitlementConfig(GetPlatformEntitlementConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPlatformConfigInfo? UpdatePlatformEntitlementConfig(UpdatePlatformEntitlementConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPagingSlicedResult? QueryUserEntitlements(QueryUserEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.StackableEntitlementInfo>? GrantUserEntitlement(GrantUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementInfo? GetUserAppEntitlementByAppId(GetUserAppEntitlementByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementPagingSlicedResult? QueryUserEntitlementsByAppType(QueryUserEntitlementsByAppType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlementByItemId(GetUserEntitlementByItemId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementInfo>? GetUserActiveEntitlementsByItemIds(GetUserActiveEntitlementsByItemIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlementBySku(GetUserEntitlementBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? ExistsAnyUserActiveEntitlement(ExistsAnyUserActiveEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? ExistsAnyUserActiveEntitlementByItemIds(ExistsAnyUserActiveEntitlementByItemIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? GetUserAppEntitlementOwnershipByAppId(GetUserAppEntitlementOwnershipByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? GetUserEntitlementOwnershipByItemId(GetUserEntitlementOwnershipByItemId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementOwnership>? GetUserEntitlementOwnershipByItemIds(GetUserEntitlementOwnershipByItemIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? GetUserEntitlementOwnershipBySku(GetUserEntitlementOwnershipBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? RevokeAllEntitlements(RevokeAllEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkOperationResult? RevokeUserEntitlements(RevokeUserEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? GetUserEntitlement(GetUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? UpdateUserEntitlement(UpdateUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementDecrementResult? ConsumeUserEntitlement(ConsumeUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? DisableUserEntitlement(DisableUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? EnableUserEntitlement(EnableUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementHistoryInfo>? GetUserEntitlementHistories(GetUserEntitlementHistories input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? RevokeUserEntitlement(RevokeUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementIfc? RevokeUserEntitlementByUseCount(RevokeUserEntitlementByUseCount input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPrechekResult? PreCheckRevokeUserEntitlementByUseCount(PreCheckRevokeUserEntitlementByUseCount input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.EntitlementInfo? RevokeUseCount(RevokeUseCount input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.EntitlementSoldResult? SellUserEntitlement(SellUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicExistsAnyMyActiveEntitlement(PublicExistsAnyMyActiveEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicGetMyAppEntitlementOwnershipByAppId(PublicGetMyAppEntitlementOwnershipByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetMyEntitlementOwnershipByItemId(PublicGetMyEntitlementOwnershipByItemId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetMyEntitlementOwnershipBySku(PublicGetMyEntitlementOwnershipBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.OwnershipToken? PublicGetEntitlementOwnershipToken(PublicGetEntitlementOwnershipToken input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementPagingSlicedResult? PublicQueryUserEntitlements(PublicQueryUserEntitlements input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementInfo? PublicGetUserAppEntitlementByAppId(PublicGetUserAppEntitlementByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AppEntitlementPagingSlicedResult? PublicQueryUserEntitlementsByAppType(PublicQueryUserEntitlementsByAppType input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementInfo>? PublicGetUserEntitlementsByIds(PublicGetUserEntitlementsByIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.EntitlementInfo? PublicGetUserEntitlementByItemId(PublicGetUserEntitlementByItemId input)
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
        public Model.EntitlementInfo? PublicGetUserEntitlementBySku(PublicGetUserEntitlementBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public List<Model.UserEntitlementHistoryPagingSlicedResult>? PublicUserEntitlementHistory(PublicUserEntitlementHistory input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicExistsAnyUserActiveEntitlement(PublicExistsAnyUserActiveEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.Ownership? PublicGetUserAppEntitlementOwnershipByAppId(PublicGetUserAppEntitlementOwnershipByAppId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetUserEntitlementOwnershipByItemId(PublicGetUserEntitlementOwnershipByItemId input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.EntitlementOwnership>? PublicGetUserEntitlementOwnershipByItemIds(PublicGetUserEntitlementOwnershipByItemIds input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.TimedOwnership? PublicGetUserEntitlementOwnershipBySku(PublicGetUserEntitlementOwnershipBySku input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementInfo? PublicGetUserEntitlement(PublicGetUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementDecrementResult? PublicConsumeUserEntitlement(PublicConsumeUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementSoldResult? PublicSellUserEntitlement(PublicSellUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementSplitResult? PublicSplitUserEntitlement(PublicSplitUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.EntitlementTransferResult? PublicTransferUserEntitlement(PublicTransferUserEntitlement input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}