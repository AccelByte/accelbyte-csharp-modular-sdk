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
    /// publicGetPaymentAccounts
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment accounts.
    /// Other detail info:
    /// 
    ///   * Returns : Payment account list
    /// </summary>
    public class PublicGetPaymentAccounts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentAccountsBuilder Builder { get => new PublicGetPaymentAccountsBuilder(); }

        public class PublicGetPaymentAccountsBuilder
            : OperationBuilder<PublicGetPaymentAccountsBuilder>
        {





            internal PublicGetPaymentAccountsBuilder() { }

            internal PublicGetPaymentAccountsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetPaymentAccounts Build(
                string namespace_,
                string userId
            )
            {
                PublicGetPaymentAccounts op = new PublicGetPaymentAccounts(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetPaymentAccountsBuilder>(this);
                return op;
            }

            public List<Model.PaymentAccount>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetPaymentAccounts op = Build(
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
            public async Task<List<Model.PaymentAccount>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetPaymentAccounts op = Build(
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

        private PublicGetPaymentAccounts(PublicGetPaymentAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetPaymentAccounts(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.PaymentAccount>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentAccount>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentAccount>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}