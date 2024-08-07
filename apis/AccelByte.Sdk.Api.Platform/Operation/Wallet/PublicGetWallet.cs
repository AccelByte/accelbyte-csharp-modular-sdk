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
    /// publicGetWallet
    ///
    /// get a wallet by currency code.
    /// Other detail info:
    /// 
    ///   * Returns : wallet info
    /// </summary>
    public class PublicGetWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetWalletBuilder Builder { get => new PublicGetWalletBuilder(); }

        public class PublicGetWalletBuilder
            : OperationBuilder<PublicGetWalletBuilder>
        {





            internal PublicGetWalletBuilder() { }

            internal PublicGetWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetWallet Build(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PublicGetWallet op = new PublicGetWallet(this,
                    currencyCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetWalletBuilder>(this);
                return op;
            }

            public Model.PlatformWallet? Execute(
                string currencyCode,
                string namespace_,
                string userId
            )
            {
                PublicGetWallet op = Build(
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
                PublicGetWallet op = Build(
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

        private PublicGetWallet(PublicGetWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetWallet(
            string currencyCode,
            string namespace_,
            string userId
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}";

        public override HttpMethod Method => HttpMethod.Get;

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