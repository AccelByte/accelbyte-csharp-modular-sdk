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
    /// publicGetMyWallet
    ///
    /// get my wallet by currency code and namespace.
    /// Other detail info:
    /// 
    ///   * Returns : wallet info
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to get publisher user wallet
    ///     * can be filled with game namespace in order to get game user wallet
    /// </summary>
    public class PublicGetMyWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyWalletBuilder Builder { get => new PublicGetMyWalletBuilder(); }

        public class PublicGetMyWalletBuilder
            : OperationBuilder<PublicGetMyWalletBuilder>
        {





            internal PublicGetMyWalletBuilder() { }

            internal PublicGetMyWalletBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetMyWallet Build(
                string currencyCode,
                string namespace_
            )
            {
                PublicGetMyWallet op = new PublicGetMyWallet(this,
                    currencyCode,
                    namespace_
                );

                op.SetBaseFields<PublicGetMyWalletBuilder>(this);
                return op;
            }

            public Model.PlatformWallet? Execute(
                string currencyCode,
                string namespace_
            )
            {
                PublicGetMyWallet op = Build(
                    currencyCode,
                    namespace_
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
                string namespace_
            )
            {
                PublicGetMyWallet op = Build(
                    currencyCode,
                    namespace_
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

        private PublicGetMyWallet(PublicGetMyWalletBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyWallet(
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode}";

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