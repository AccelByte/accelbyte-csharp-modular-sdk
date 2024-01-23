// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// creditUserWallet
    ///
    /// Credit a user wallet by currency code and balance origin, if wallet not exists, it will create a new wallet.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:WALLET", action=4 (UPDATE)
    /// </summary>
    public class CreditUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreditUserWalletBuilder Builder { get => new CreditUserWalletBuilder(); }

        public class CreditUserWalletBuilder
            : OperationBuilder<CreditUserWalletBuilder>
        {


            public Model.CreditRequest? Body { get; set; }




            internal CreditUserWalletBuilder() { }

            internal CreditUserWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreditUserWalletBuilder SetBody(Model.CreditRequest _body)
            {
                Body = _body;
                return this;
            }




            public CreditUserWallet Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                CreditUserWallet op = new CreditUserWallet(this,
                    currencyCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<CreditUserWalletBuilder>(this);
                return op;
            }

            public Model.WalletInfo? Execute(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                CreditUserWallet op = Build(
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
        }

        private CreditUserWallet(CreditUserWalletBuilder builder,
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

        public CreditUserWallet(
            string currencyCode,
            string namespace_,
            string userId,
            Model.CreditRequest body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/credit";

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