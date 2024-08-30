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
    /// refundOrder
    ///
    /// Refund order by orderNo.
    /// </summary>
    public class RefundOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RefundOrderBuilder Builder { get => new RefundOrderBuilder(); }

        public class RefundOrderBuilder
            : OperationBuilder<RefundOrderBuilder>
        {





            internal RefundOrderBuilder() { }

            internal RefundOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RefundOrder Build(
                OrderRefundCreate body,
                string namespace_,
                string orderNo
            )
            {
                RefundOrder op = new RefundOrder(this,
                    body,
                    namespace_,
                    orderNo
                );

                op.SetBaseFields<RefundOrderBuilder>(this);
                return op;
            }

            public Model.OrderInfo? Execute(
                OrderRefundCreate body,
                string namespace_,
                string orderNo
            )
            {
                RefundOrder op = Build(
                    body,
                    namespace_,
                    orderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.OrderInfo?> ExecuteAsync(
                OrderRefundCreate body,
                string namespace_,
                string orderNo
            )
            {
                RefundOrder op = Build(
                    body,
                    namespace_,
                    orderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.OrderInfo<T1>? Execute<T1>(
                OrderRefundCreate body,
                string namespace_,
                string orderNo
            )
            {
                RefundOrder op = Build(
                    body,
                    namespace_,
                    orderNo
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.OrderInfo<T1>?> ExecuteAsync<T1>(
                OrderRefundCreate body,
                string namespace_,
                string orderNo
            )
            {
                RefundOrder op = Build(
                    body,
                    namespace_,
                    orderNo
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

        private RefundOrder(RefundOrderBuilder builder,
            OrderRefundCreate body,
            string namespace_,
            string orderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RefundOrder(
            string namespace_,
            string orderNo,
            Model.OrderRefundCreate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/orders/{orderNo}/refund";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.OrderInfo<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}