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
    /// payWithUserWallet
    ///
    /// Pay with user wallet by currency code and client platform.
    /// </summary>
    public class PayWithUserWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PayWithUserWalletBuilder Builder { get => new PayWithUserWalletBuilder(); }

        public class PayWithUserWalletBuilder
            : OperationBuilder<PayWithUserWalletBuilder>
        {


            public Model.PaymentRequest? Body { get; set; }




            internal PayWithUserWalletBuilder() { }

            internal PayWithUserWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PayWithUserWalletBuilder SetBody(Model.PaymentRequest _body)
            {
                Body = _body;
                return this;
            }




            public PayWithUserWallet Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PayWithUserWallet op = new PayWithUserWallet(this,
                    currencyCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PayWithUserWalletBuilder>(this);
                return op;
            }

            public Model.PlatformWallet? Execute(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PayWithUserWallet op = Build(
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
            public async Task<Model.PlatformWallet?> ExecuteAsync(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PayWithUserWallet op = Build(
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

        private PayWithUserWallet(PayWithUserWalletBuilder builder,
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

        public PayWithUserWallet(
            string currencyCode,
            string namespace_,
            string userId,
            Model.PaymentRequest body
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PlatformWallet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformWallet>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformWallet>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}