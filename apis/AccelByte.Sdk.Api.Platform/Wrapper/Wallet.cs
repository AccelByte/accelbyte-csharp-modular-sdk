// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Wallet
    {
        private readonly IAccelByteSdk _sdk;

        private string _CustomBasePath = String.Empty;

        public Wallet(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        public Wallet(IAccelByteSdk sdk, string customBasePath)
        {
            _sdk = sdk;
            _CustomBasePath = customBasePath;
        }

        #region Operation Builders
        public GetPlatformWalletConfig.GetPlatformWalletConfigBuilder GetPlatformWalletConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetPlatformWalletConfig.GetPlatformWalletConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdatePlatformWalletConfig.UpdatePlatformWalletConfigBuilder UpdatePlatformWalletConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdatePlatformWalletConfig.UpdatePlatformWalletConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ResetPlatformWalletConfig.ResetPlatformWalletConfigBuilder ResetPlatformWalletConfigOp
        {
            get
            {
                var opBuilder = new Operation.ResetPlatformWalletConfig.ResetPlatformWalletConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public QueryUserCurrencyWallets.QueryUserCurrencyWalletsBuilder QueryUserCurrencyWalletsOp
        {
            get
            {
                var opBuilder = new Operation.QueryUserCurrencyWallets.QueryUserCurrencyWalletsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DebitUserWalletByCurrencyCode.DebitUserWalletByCurrencyCodeBuilder DebitUserWalletByCurrencyCodeOp
        {
            get
            {
                var opBuilder = new Operation.DebitUserWalletByCurrencyCode.DebitUserWalletByCurrencyCodeBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public ListUserCurrencyTransactions.ListUserCurrencyTransactionsBuilder ListUserCurrencyTransactionsOp
        {
            get
            {
                var opBuilder = new Operation.ListUserCurrencyTransactions.ListUserCurrencyTransactionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CheckBalance.CheckBalanceBuilder CheckBalanceOp
        {
            get
            {
                var opBuilder = new Operation.CheckBalance.CheckBalanceBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public CheckWallet.CheckWalletBuilder CheckWalletOp
        {
            get
            {
                var opBuilder = new Operation.CheckWallet.CheckWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public CreditUserWallet.CreditUserWalletBuilder CreditUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.CreditUserWallet.CreditUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public DebitByWalletPlatform.DebitByWalletPlatformBuilder DebitByWalletPlatformOp
        {
            get
            {
                var opBuilder = new Operation.DebitByWalletPlatform.DebitByWalletPlatformBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PayWithUserWallet.PayWithUserWalletBuilder PayWithUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.PayWithUserWallet.PayWithUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetUserWallet.GetUserWalletBuilder GetUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.GetUserWallet.GetUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DebitUserWallet.DebitUserWalletBuilder DebitUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.DebitUserWallet.DebitUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public DisableUserWallet.DisableUserWalletBuilder DisableUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.DisableUserWallet.DisableUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public EnableUserWallet.EnableUserWalletBuilder EnableUserWalletOp
        {
            get
            {
                var opBuilder = new Operation.EnableUserWallet.EnableUserWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public ListUserWalletTransactions.ListUserWalletTransactionsBuilder ListUserWalletTransactionsOp
        {
            get
            {
                var opBuilder = new Operation.ListUserWalletTransactions.ListUserWalletTransactionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public QueryWallets.QueryWalletsBuilder QueryWalletsOp
        {
            get
            {
                var opBuilder = new Operation.QueryWallets.QueryWalletsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public BulkCredit.BulkCreditBuilder BulkCreditOp
        {
            get
            {
                var opBuilder = new Operation.BulkCredit.BulkCreditBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public BulkDebit.BulkDebitBuilder BulkDebitOp
        {
            get
            {
                var opBuilder = new Operation.BulkDebit.BulkDebitBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public GetWallet.GetWalletBuilder GetWalletOp
        {
            get
            {
                var opBuilder = new Operation.GetWallet.GetWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetMyWallet.PublicGetMyWalletBuilder PublicGetMyWalletOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetMyWallet.PublicGetMyWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicGetWallet.PublicGetWalletBuilder PublicGetWalletOp
        {
            get
            {
                var opBuilder = new Operation.PublicGetWallet.PublicGetWalletBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder PublicListUserWalletTransactionsOp
        {
            get
            {
                var opBuilder = new Operation.PublicListUserWalletTransactions.PublicListUserWalletTransactionsBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
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
        public async Task<Model.PlatformWalletConfigInfo?> GetPlatformWalletConfigAsync(GetPlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWalletConfigInfo?> UpdatePlatformWalletConfigAsync(UpdatePlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWalletConfigInfo?> ResetPlatformWalletConfigAsync(ResetPlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<List<Model.CurrencyWallet>?> QueryUserCurrencyWalletsAsync(QueryUserCurrencyWallets input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletInfo?> DebitUserWalletByCurrencyCodeAsync(DebitUserWalletByCurrencyCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletTransactionPagingSlicedResult?> ListUserCurrencyTransactionsAsync(ListUserCurrencyTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void CheckBalance(CheckBalance input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task CheckBalanceAsync(CheckBalance input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
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
        public async Task CheckWalletAsync(CheckWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletInfo?> CreditUserWalletAsync(CreditUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWallet?> DebitByWalletPlatformAsync(DebitByWalletPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWallet?> PayWithUserWalletAsync(PayWithUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletInfo?> GetUserWalletAsync(GetUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletInfo?> DebitUserWalletAsync(DebitUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task DisableUserWalletAsync(DisableUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task EnableUserWalletAsync(EnableUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.DetailedWalletTransactionPagingSlicedResult?> ListUserWalletTransactionsAsync(ListUserWalletTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletPagingSlicedResult?> QueryWalletsAsync(QueryWallets input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.BulkCreditResult?> BulkCreditAsync(BulkCredit input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.BulkDebitResult?> BulkDebitAsync(BulkDebit input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletInfo?> GetWalletAsync(GetWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWallet?> PublicGetMyWalletAsync(PublicGetMyWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.PlatformWallet?> PublicGetWalletAsync(PublicGetWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
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
        public async Task<Model.WalletTransactionPagingSlicedResult?> PublicListUserWalletTransactionsAsync(PublicListUserWalletTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}