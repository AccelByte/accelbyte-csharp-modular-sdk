// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// debitUserWallet
    ///
    /// Debit a user wallet.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DebitUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebitUserWalletBuilder Builder { get => new DebitUserWalletBuilder(); }

        public class DebitUserWalletBuilder
            : OperationBuilder<DebitUserWalletBuilder>
        {





            internal DebitUserWalletBuilder() { }

            internal DebitUserWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DebitUserWallet Build(
                DebitRequest body,
                string namespace_,
                string userId,
                string walletId
            )
            {
                DebitUserWallet op = new DebitUserWallet(this,
                    body,
                    namespace_,
                    userId,
                    walletId
                );

                op.SetBaseFields<DebitUserWalletBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public DebitUserWallet.Response Execute(
                DebitRequest body,
                string namespace_,
                string userId,
                string walletId
            )
            {
                DebitUserWallet op = Build(
                    body,
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DebitUserWallet.Response> ExecuteAsync(
                DebitRequest body,
                string namespace_,
                string userId,
                string walletId
            )
            {
                DebitUserWallet op = Build(
                    body,
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DebitUserWallet(DebitUserWalletBuilder builder,
            DebitRequest body,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.WalletInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Wallet::DebitUserWallet";
        }

        #endregion

        public DebitUserWallet(
            string namespace_,
            string userId,
            string walletId,
            Model.DebitRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/debit";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public DebitUserWallet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DebitUserWallet.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.WalletInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}