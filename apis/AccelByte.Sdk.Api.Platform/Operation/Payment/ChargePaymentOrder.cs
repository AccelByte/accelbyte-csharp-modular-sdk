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
    /// chargePaymentOrder
    ///
    ///  [Not supported yet in AGS Shared Cloud] [TEST FACILITY ONLY] Forbidden in live environment. Charge payment order without payment flow for unpaid payment order, usually for test usage to simulate real currency payment process.
    /// Other detail info:
    /// 
    ///   * Returns : payment order instance
    /// </summary>
    public class ChargePaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChargePaymentOrderBuilder Builder { get => new ChargePaymentOrderBuilder(); }

        public class ChargePaymentOrderBuilder
            : OperationBuilder<ChargePaymentOrderBuilder>
        {





            internal ChargePaymentOrderBuilder() { }

            internal ChargePaymentOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ChargePaymentOrder Build(
                PaymentOrderChargeRequest body,
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = new ChargePaymentOrder(this,
                    body,
                    namespace_,
                    paymentOrderNo
                );

                op.SetBaseFields<ChargePaymentOrderBuilder>(this);
                return op;
            }

            public Model.PaymentOrderInfo? Execute(
                PaymentOrderChargeRequest body,
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
                    body,
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
            public async Task<Model.PaymentOrderInfo?> ExecuteAsync(
                PaymentOrderChargeRequest body,
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
                    body,
                    namespace_,
                    paymentOrderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.PaymentOrderInfo<T1>? Execute<T1>(
                PaymentOrderChargeRequest body,
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
                    body,
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
            public async Task<Model.PaymentOrderInfo<T1>?> ExecuteAsync<T1>(
                PaymentOrderChargeRequest body,
                string namespace_,
                string paymentOrderNo
            )
            {
                ChargePaymentOrder op = Build(
                    body,
                    namespace_,
                    paymentOrderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private ChargePaymentOrder(ChargePaymentOrderBuilder builder,
            PaymentOrderChargeRequest body,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;





            BodyParams = body;


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
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload, ResponseJsonOptions);
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
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}