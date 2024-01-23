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
    /// publicGetPaymentMethods
    ///
    ///  [Not Supported Yet In Starter] Get payment methods.
    /// Other detail info:
    /// 
    ///   * Returns : Payment method list
    /// </summary>
    public class PublicGetPaymentMethods : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentMethodsBuilder Builder { get => new PublicGetPaymentMethodsBuilder(); }

        public class PublicGetPaymentMethodsBuilder
            : OperationBuilder<PublicGetPaymentMethodsBuilder>
        {





            internal PublicGetPaymentMethodsBuilder() { }

            internal PublicGetPaymentMethodsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetPaymentMethods Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicGetPaymentMethods op = new PublicGetPaymentMethods(this,
                    namespace_,
                    paymentOrderNo
                );

                op.SetBaseFields<PublicGetPaymentMethodsBuilder>(this);
                return op;
            }

            public List<Model.PaymentMethod>? Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicGetPaymentMethods op = Build(
                    namespace_,
                    paymentOrderNo
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

        private PublicGetPaymentMethods(PublicGetPaymentMethodsBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;

            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;






        }
        #endregion

        public PublicGetPaymentMethods(
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;

            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;






        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/methods";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.PaymentMethod>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentMethod>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentMethod>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}