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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        public GetWalletConfig.GetWalletConfigBuilder GetWalletConfigOp
        {
            get
            {
                var opBuilder = new Operation.GetWalletConfig.GetWalletConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        public UpdateWalletConfig.UpdateWalletConfigBuilder UpdateWalletConfigOp
        {
            get
            {
                var opBuilder = new Operation.UpdateWalletConfig.UpdateWalletConfigBuilder(_sdk);
                if (_CustomBasePath != "")
                    return opBuilder.UseCustomBasePath(_CustomBasePath);
                else
                    return opBuilder;
            }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
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

        public GetPlatformWalletConfig.Response GetPlatformWalletConfig(GetPlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetPlatformWalletConfig.Response> GetPlatformWalletConfigAsync(GetPlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdatePlatformWalletConfig.Response UpdatePlatformWalletConfig(UpdatePlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdatePlatformWalletConfig.Response> UpdatePlatformWalletConfigAsync(UpdatePlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ResetPlatformWalletConfig.Response ResetPlatformWalletConfig(ResetPlatformWalletConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ResetPlatformWalletConfig.Response> ResetPlatformWalletConfigAsync(ResetPlatformWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public QueryUserCurrencyWallets.Response QueryUserCurrencyWallets(QueryUserCurrencyWallets input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryUserCurrencyWallets.Response> QueryUserCurrencyWalletsAsync(QueryUserCurrencyWallets input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DebitUserWalletByCurrencyCode.Response DebitUserWalletByCurrencyCode(DebitUserWalletByCurrencyCode input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DebitUserWalletByCurrencyCode.Response> DebitUserWalletByCurrencyCodeAsync(DebitUserWalletByCurrencyCode input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public ListUserCurrencyTransactions.Response ListUserCurrencyTransactions(ListUserCurrencyTransactions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListUserCurrencyTransactions.Response> ListUserCurrencyTransactionsAsync(ListUserCurrencyTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public CheckBalance.Response CheckBalance(CheckBalance input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CheckBalance.Response> CheckBalanceAsync(CheckBalance input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public CheckWallet.Response CheckWallet(CheckWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CheckWallet.Response> CheckWalletAsync(CheckWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public CreditUserWallet.Response CreditUserWallet(CreditUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<CreditUserWallet.Response> CreditUserWalletAsync(CreditUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public DebitByWalletPlatform.Response DebitByWalletPlatform(DebitByWalletPlatform input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DebitByWalletPlatform.Response> DebitByWalletPlatformAsync(DebitByWalletPlatform input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PayWithUserWallet.Response PayWithUserWallet(PayWithUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PayWithUserWallet.Response> PayWithUserWalletAsync(PayWithUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetUserWallet.Response GetUserWallet(GetUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetUserWallet.Response> GetUserWalletAsync(GetUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DebitUserWallet.Response DebitUserWallet(DebitUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DebitUserWallet.Response> DebitUserWalletAsync(DebitUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DisableUserWallet.Response DisableUserWallet(DisableUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<DisableUserWallet.Response> DisableUserWalletAsync(DisableUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EnableUserWallet.Response EnableUserWallet(EnableUserWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<EnableUserWallet.Response> EnableUserWalletAsync(EnableUserWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListUserWalletTransactions.Response ListUserWalletTransactions(ListUserWalletTransactions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<ListUserWalletTransactions.Response> ListUserWalletTransactionsAsync(ListUserWalletTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public GetWalletConfig.Response GetWalletConfig(GetWalletConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetWalletConfig.Response> GetWalletConfigAsync(GetWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public UpdateWalletConfig.Response UpdateWalletConfig(UpdateWalletConfig input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<UpdateWalletConfig.Response> UpdateWalletConfigAsync(UpdateWalletConfig input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public QueryWallets.Response QueryWallets(QueryWallets input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<QueryWallets.Response> QueryWalletsAsync(QueryWallets input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public BulkCredit.Response BulkCredit(BulkCredit input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkCredit.Response> BulkCreditAsync(BulkCredit input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public BulkDebit.Response BulkDebit(BulkDebit input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<BulkDebit.Response> BulkDebitAsync(BulkDebit input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetWallet.Response GetWallet(GetWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<GetWallet.Response> GetWalletAsync(GetWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public PublicGetMyWallet.Response PublicGetMyWallet(PublicGetMyWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetMyWallet.Response> PublicGetMyWalletAsync(PublicGetMyWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicGetWallet.Response PublicGetWallet(PublicGetWallet input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicGetWallet.Response> PublicGetWalletAsync(PublicGetWallet input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public PublicListUserWalletTransactions.Response PublicListUserWalletTransactions(PublicListUserWalletTransactions input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<PublicListUserWalletTransactions.Response> PublicListUserWalletTransactionsAsync(PublicListUserWalletTransactions input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}