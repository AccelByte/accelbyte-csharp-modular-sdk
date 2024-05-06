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
    /// enableUserWallet
    ///
    /// enable a user wallet.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class EnableUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnableUserWalletBuilder Builder { get => new EnableUserWalletBuilder(); }

        public class EnableUserWalletBuilder
            : OperationBuilder<EnableUserWalletBuilder>
        {





            internal EnableUserWalletBuilder() { }

            internal EnableUserWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnableUserWallet Build(
                string namespace_,
                string userId,
                string walletId
            )
            {
                EnableUserWallet op = new EnableUserWallet(this,
                    namespace_,
                    userId,
                    walletId
                );

                op.SetBaseFields<EnableUserWalletBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                string namespace_,
                string userId,
                string walletId
            )
            {
                EnableUserWallet op = Build(
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string namespace_,
                string userId,
                string walletId
            )
            {
                EnableUserWallet op = Build(
                    namespace_,
                    userId,
                    walletId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private EnableUserWallet(EnableUserWalletBuilder builder,
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public EnableUserWallet(
            string namespace_,
            string userId,
            string walletId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            PathParams["walletId"] = walletId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}