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
    /// chargePaymentOrder
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Charge payment order without payment flow for unpaid payment order, usually for test usage to simulate real currency payment process.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=4 (UPDATE)
    ///   *  Returns : payment order instance
    /// </summary>
    public class ChargePaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChargePaymentOrderBuilder Builder { get => new ChargePaymentOrderBuilder(); }

        public class ChargePaymentOrderBuilder
            : OperationBuilder<ChargePaymentOrderBuilder>
        {


            public Model.PaymentOrderChargeRequest? Body { get; set; }




            internal ChargePaymentOrderBuilder() { }

            internal ChargePaymentOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public ChargePaymentOrderBuilder SetBody(Model.PaymentOrderChargeRequest _body)
            {
                Body = _body;
                return this;
            }




            public ChargePaymentOrder Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = new ChargePaymentOrder(this,
                    namespace_,
                    paymentOrderNo
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.PaymentOrderInfo? Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
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

            public Model.PaymentOrderInfo<T1>? Execute<T1>(
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
                    namespace_,
                    paymentOrderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ChargePaymentOrder(ChargePaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ChargePaymentOrder(
            string namespace_,
            string paymentOrderNo,
            Model.PaymentOrderChargeRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentOrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.PaymentOrderInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}