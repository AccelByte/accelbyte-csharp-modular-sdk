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
    /// debitUserWalletByCurrencyCode
    ///
    /// Debit a user wallet by currency code, default is debit system wallet.
    /// </summary>
    public class DebitUserWalletByCurrencyCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebitUserWalletByCurrencyCodeBuilder Builder { get => new DebitUserWalletByCurrencyCodeBuilder(); }

        public class DebitUserWalletByCurrencyCodeBuilder
            : OperationBuilder<DebitUserWalletByCurrencyCodeBuilder>
        {


            public Model.DebitByCurrencyCodeRequest? Body { get; set; }




            internal DebitUserWalletByCurrencyCodeBuilder() { }

            internal DebitUserWalletByCurrencyCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public DebitUserWalletByCurrencyCodeBuilder SetBody(Model.DebitByCurrencyCodeRequest _body)
            {
                Body = _body;
                return this;
            }




            public DebitUserWalletByCurrencyCode Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitUserWalletByCurrencyCode op = new DebitUserWalletByCurrencyCode(this,
                    currencyCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DebitUserWalletByCurrencyCodeBuilder>(this);
                return op;
            }

            public Model.WalletInfo? Execute(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitUserWalletByCurrencyCode op = Build(
                    currencyCode,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.WalletInfo?> ExecuteAsync(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                DebitUserWalletByCurrencyCode op = Build(
                    currencyCode,
                    namespace_,
                    userId
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

        private DebitUserWalletByCurrencyCode(DebitUserWalletByCurrencyCodeBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DebitUserWalletByCurrencyCode(
            string currencyCode,
            string namespace_,
            string userId,
            Model.DebitByCurrencyCodeRequest body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/debit";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.WalletInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.WalletInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.WalletInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}