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
    /// refundUserPaymentOrder
    ///
    ///  [Not Supported Yet In Starter] [SERVICE COMMUNICATION ONLY] This API is used to refund order by paymentOrderNo from justice service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:PAYMENT", action=4 (UPDATE)
    /// </summary>
    public class RefundUserPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RefundUserPaymentOrderBuilder Builder { get => new RefundUserPaymentOrderBuilder(); }

        public class RefundUserPaymentOrderBuilder
            : OperationBuilder<RefundUserPaymentOrderBuilder>
        {


            public Model.PaymentOrderRefund? Body { get; set; }




            internal RefundUserPaymentOrderBuilder() { }

            internal RefundUserPaymentOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public RefundUserPaymentOrderBuilder SetBody(Model.PaymentOrderRefund _body)
            {
                Body = _body;
                return this;
            }




            public RefundUserPaymentOrder Build(
                string namespace_,
                string paymentOrderNo,
                string userId
            )
            {
                RefundUserPaymentOrder op = new RefundUserPaymentOrder(this,
                    namespace_,
                    paymentOrderNo,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.PaymentOrderInfo? Execute(
                string namespace_,
                string paymentOrderNo,
                string userId
            )
            {
                RefundUserPaymentOrder op = Build(
                    namespace_,
                    paymentOrderNo,
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

            public Model.PaymentOrderInfo<T1>? Execute<T1>(
                string namespace_,
                string paymentOrderNo,
                string userId
            )
            {
                RefundUserPaymentOrder op = Build(
                    namespace_,
                    paymentOrderNo,
                    userId
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

        private RefundUserPaymentOrder(RefundUserPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RefundUserPaymentOrder(
            string namespace_,
            string paymentOrderNo,
            string userId,
            Model.PaymentOrderRefund body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund";

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