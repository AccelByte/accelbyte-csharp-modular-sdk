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
    /// publicCheckPaymentOrderPaidStatus
    ///
    ///  [Not supported yet in AGS Shared Cloud] Check payment order paid status.
    /// Other detail info:
    /// 
    ///   * Returns : Payment order paid result
    /// </summary>
    public class PublicCheckPaymentOrderPaidStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCheckPaymentOrderPaidStatusBuilder Builder { get => new PublicCheckPaymentOrderPaidStatusBuilder(); }

        public class PublicCheckPaymentOrderPaidStatusBuilder
            : OperationBuilder<PublicCheckPaymentOrderPaidStatusBuilder>
        {





            internal PublicCheckPaymentOrderPaidStatusBuilder() { }

            internal PublicCheckPaymentOrderPaidStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCheckPaymentOrderPaidStatus Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicCheckPaymentOrderPaidStatus op = new PublicCheckPaymentOrderPaidStatus(this,
                    namespace_,
                    paymentOrderNo
                );

                op.SetBaseFields<PublicCheckPaymentOrderPaidStatusBuilder>(this);
                return op;
            }

            public Model.PaymentOrderPaidResult? Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicCheckPaymentOrderPaidStatus op = Build(
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
            public async Task<Model.PaymentOrderPaidResult?> ExecuteAsync(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicCheckPaymentOrderPaidStatus op = Build(
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
        }

        private PublicCheckPaymentOrderPaidStatus(PublicCheckPaymentOrderPaidStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;







        }
        #endregion

        public PublicCheckPaymentOrderPaidStatus(
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;







        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentOrderPaidResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPaidResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPaidResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}