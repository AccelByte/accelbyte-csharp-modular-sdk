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
    /// getPaymentOrder
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment order by paymentOrderNo.
    /// Other detail info:
    /// 
    ///   * Returns : payment order instance
    /// </summary>
    public class GetPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentOrderBuilder Builder { get => new GetPaymentOrderBuilder(); }

        public class GetPaymentOrderBuilder
            : OperationBuilder<GetPaymentOrderBuilder>
        {





            internal GetPaymentOrderBuilder() { }

            internal GetPaymentOrderBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPaymentOrder Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrder op = new GetPaymentOrder(this,
                    namespace_,                    
                    paymentOrderNo                    
                );

                op.SetBaseFields<GetPaymentOrderBuilder>(this);
                return op;
            }

            public GetPaymentOrder.Response Execute(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrder op = Build(
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
            public async Task<GetPaymentOrder.Response> ExecuteAsync(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrder op = Build(
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

            public GetPaymentOrder.Response<T1> Execute<T1>(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrder op = Build(
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
            public async Task<GetPaymentOrder.Response<T1>> ExecuteAsync<T1>(
                string namespace_,
                string paymentOrderNo
            )
            {
                GetPaymentOrder op = Build(
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

        private GetPaymentOrder(GetPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentOrderInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Payment::GetPaymentOrder";
        }

        public class Response<T1> : ApiResponse<Model.PaymentOrderInfo<T1>>
        {
            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Payment::GetPaymentOrder";
        }
        #endregion

        public GetPaymentOrder(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetPaymentOrder.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPaymentOrder.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }

        public GetPaymentOrder.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPaymentOrder.Response<T1>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }            
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.PaymentOrderInfo<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            
            return response;
        }
    }

}