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
    /// publicCancelUserOrder
    ///
    /// Cancel user order.
    /// Other detail info:
    /// 
    ///   * Returns : cancelled order
    /// </summary>
    public class PublicCancelUserOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCancelUserOrderBuilder Builder { get => new PublicCancelUserOrderBuilder(); }

        public class PublicCancelUserOrderBuilder
            : OperationBuilder<PublicCancelUserOrderBuilder>
        {





            internal PublicCancelUserOrderBuilder() { }

            internal PublicCancelUserOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCancelUserOrder Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicCancelUserOrder op = new PublicCancelUserOrder(this,
                    namespace_,
                    orderNo,
                    userId
                );

                op.SetBaseFields<PublicCancelUserOrderBuilder>(this);
                return op;
            }

            public Model.OrderInfo? Execute(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicCancelUserOrder op = Build(
                    namespace_,
                    orderNo,
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
            public async Task<Model.OrderInfo?> ExecuteAsync(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicCancelUserOrder op = Build(
                    namespace_,
                    orderNo,
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

            public Model.OrderInfo<T1>? Execute<T1>(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicCancelUserOrder op = Build(
                    namespace_,
                    orderNo,
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
            public async Task<Model.OrderInfo<T1>?> ExecuteAsync<T1>(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicCancelUserOrder op = Build(
                    namespace_,
                    orderNo,
                    userId
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

        private PublicCancelUserOrder(PublicCancelUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCancelUserOrder(
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel";

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