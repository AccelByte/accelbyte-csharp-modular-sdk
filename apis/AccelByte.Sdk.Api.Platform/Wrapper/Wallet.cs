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
    public class Wallet
    {
        private readonly IAccelByteSdk _sdk;

        public Wallet(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetPlatformWalletConfig.GetPlatformWalletConfigBuilder GetPlatformWalletConfigOp
        {
            get { return new Operation.GetPlatformWalletConfig.GetPlatformWalletConfigBuilder(_sdk); }
        }
        public UpdatePlatformWalletConfig.UpdatePlatformWalletConfigBuilder UpdatePlatformWalletConfigOp
        {
            get { return new Operation.UpdatePlatformWalletConfig.UpdatePlatformWalletConfigBuilder(_sdk); }
        }
        public ResetPlatformWalletConfig.ResetPlatformWalletConfigBuilder ResetPlatformWalletConfigOp
        {
            get { return new Operation.ResetPlatformWalletConfig.ResetPlatformWalletConfigBuilder(_sdk); }
        }
        public QueryUserCurrencyWallets.QueryUserCurrencyWalletsBuilder QueryUserCurrencyWalletsOp
        {
            get { return new Operation.QueryUserCurrencyWallets.QueryUserCurrencyWalletsBuilder(_sdk); }
        }
        public DebitUserWalletByCurrencyCode.DebitUserWalletByCurrencyCodeBuilder DebitUserWalletByCurrencyCodeOp
        {
            get { return new Operation.DebitUserWalletByCurrencyCode.DebitUserWalletByCurrencyCodeBuilder(_sdk); }
        }
        public ListUserCurrencyTransactions.ListUserCurrencyTransactionsBuilder ListUserCurrencyTransactionsOp
        {
            get { return new Operation.ListUserCurrencyTransactions.ListUserCurrencyTransactionsBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public CheckWallet.CheckWalletBuilder CheckWalletOp
        {
            get { return new Operation.CheckWallet.CheckWalletBuilder(_sdk); }
        }
        public CreditUserWallet.CreditUserWalletBuilder CreditUserWalletOp
        {
            get { return new Operation.CreditUserWallet.CreditUserWalletBuilder(_sdk); }
        }
        public DebitByWalletPlatform.DebitByWalletPlatformBuilder DebitByWalletPlatformOp
        {
            get { return new Operation.DebitByWalletPlatform.DebitByWalletPlatformBuilder(_sdk); }
        }
        public PayWithUserWallet.PayWithUserWalletBuilder PayWithUserWalletOp
        {
            get { return new Operation.PayWithUserWallet.PayWithUserWalletBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserWallet.GetUserWalletBuilder GetUserWalletOp
        {
            get { return new Operation.GetUserWallet.GetUserWalletBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DebitUserWallet.DebitUserWalletBuilder DebitUserWalletOp
        {
            get { return new Operation.DebitUserWallet.DebitUserWalletBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DisableUserWallet.DisableUserWalletBuilder DisableUserWalletOp
        {
            get { return new Operation.DisableUserWallet.DisableUserWalletBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public EnableUserWallet.EnableUserWalletBuilder EnableUserWalletOp
        {
            get { return new Operation.EnableUserWallet.EnableUserWalletBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ListUserWalletTransactions.ListUserWalletTransactionsBuilder ListUserWalletTransactionsOp
        {
            get { return new Operation.ListUserWalletTransactions.ListUserWalletTransactionsBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QueryWallets.QueryWalletsBuilder QueryWalletsOp
        {
            get { return new Operation.QueryWallets.QueryWalletsBuilder(_sdk); }
        }
        public BulkCredit.BulkCreditBuilder BulkCreditOp
        {
            get { return new Operation.BulkCredit.BulkCreditBuilder(_sdk); }
        }
        public BulkDebit.BulkDebitBuilder BulkDebitOp
        {
            get { return new Operation.BulkDebit.BulkDebitBuilder(_sdk); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetWallet.GetWalletBuilder GetWalletOp
        {
            get { return new Operation.GetWallet.GetWalletBuilder(_sdk); }
        }
        public PublicGetMyWallet.PublicGetMyWalletBuilder PublicGetMyWalletOp
        {
            get { return new Operation.PublicGetMyWallet.PublicGetMyWalletBuilder(_sdk); }
        }
        public PublicGetWallet.PublicGetWalletBuilder PublicGetWalletOp
        {
            get { return new Operation.PublicGetWallet.PublicGetWalletBuilder(_sdk); }
        }
        public PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder PublicListUserWalletTransactionsOp
        {
            get { return new Operation.PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder(_sdk); }
        }
        #endregion

        public Model.PlatformWalletConfigInfo? GetPlatformWalletConfig(GetPlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWalletConfigInfo? UpdatePlatformWalletConfig(UpdatePlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWalletConfigInfo? ResetPlatformWalletConfig(ResetPlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CurrencyWallet>? QueryUserCurrencyWallets(QueryUserCurrencyWallets input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletInfo? DebitUserWalletByCurrencyCode(DebitUserWalletByCurrencyCode input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletTransactionPagingSlicedResult? ListUserCurrencyTransactions(ListUserCurrencyTransactions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void CheckWallet(CheckWallet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.WalletInfo? CreditUserWallet(CreditUserWallet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWallet? DebitByWalletPlatform(DebitByWalletPlatform input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWallet? PayWithUserWallet(PayWithUserWallet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.WalletInfo? GetUserWallet(GetUserWallet input)
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
        public Model.WalletInfo? DebitUserWallet(DebitUserWallet input)
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
        public void DisableUserWallet(DisableUserWallet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void EnableUserWallet(EnableUserWallet input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.DetailedWalletTransactionPagingSlicedResult? ListUserWalletTransactions(ListUserWalletTransactions input)
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
        public Model.WalletPagingSlicedResult? QueryWallets(QueryWallets input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.BulkCreditResult? BulkCredit(BulkCredit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.BulkDebitResult? BulkDebit(BulkDebit input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.WalletInfo? GetWallet(GetWallet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.PlatformWallet? PublicGetMyWallet(PublicGetMyWallet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.PlatformWallet? PublicGetWallet(PublicGetWallet input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.WalletTransactionPagingSlicedResult? PublicListUserWalletTransactions(PublicListUserWalletTransactions input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}