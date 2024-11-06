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
    /// pay
    ///
    ///  [Not supported yet in AGS Shared Cloud] Do payment(For now, this only support checkout.com).
    /// Other detail info:
    /// 
    ///   * Returns : Payment process result
    /// </summary>
    public class Pay : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PayBuilder Builder { get => new PayBuilder(); }

        public class PayBuilder
            : OperationBuilder<PayBuilder>
        {

            public PayPaymentProvider? PaymentProvider { get; set; }

            public string? ZipCode { get; set; }





            internal PayBuilder() { }

            internal PayBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PayBuilder SetPaymentProvider(PayPaymentProvider _paymentProvider)
            {
                PaymentProvider = _paymentProvider;
                return this;
            }

            public PayBuilder SetZipCode(string _zipCode)
            {
                ZipCode = _zipCode;
                return this;
            }





            public Pay Build(
                PaymentToken body,
                string namespace_,
                string paymentOrderNo
            )
            {
                Pay op = new Pay(this,
                    body,                    
                    namespace_,                    
                    paymentOrderNo                    
                );

                op.SetBaseFields<PayBuilder>(this);
                return op;
            }

            public Pay.Response Execute(
                PaymentToken body,
                string namespace_,
                string paymentOrderNo
            )
            {
                Pay op = Build(
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
            public async Task<Pay.Response> ExecuteAsync(
                PaymentToken body,
                string namespace_,
                string paymentOrderNo
            )
            {
                Pay op = Build(
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
        }

        private Pay(PayBuilder builder,
            PaymentToken body,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            if (builder.PaymentProvider is not null) QueryParams["paymentProvider"] = builder.PaymentProvider.Value;
            if (builder.ZipCode is not null) QueryParams["zipCode"] = builder.ZipCode;
            

            
            
            BodyParams = body;
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentProcessResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentStation::Pay";
        }

        #endregion

        public Pay(
            string namespace_,            
            string paymentOrderNo,            
            PayPaymentProvider? paymentProvider,            
            string? zipCode,            
            Model.PaymentToken body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (zipCode is not null) QueryParams["zipCode"] = zipCode;
            

            
            
            BodyParams = body;
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/pay";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public Pay.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Pay.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PaymentProcessResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

    public class PayPaymentProvider : StringEnum<PayPaymentProvider>
    {
        public static readonly PayPaymentProvider ADYEN
            = new PayPaymentProvider("ADYEN");

        public static readonly PayPaymentProvider ALIPAY
            = new PayPaymentProvider("ALIPAY");

        public static readonly PayPaymentProvider CHECKOUT
            = new PayPaymentProvider("CHECKOUT");

        public static readonly PayPaymentProvider NEONPAY
            = new PayPaymentProvider("NEONPAY");

        public static readonly PayPaymentProvider PAYPAL
            = new PayPaymentProvider("PAYPAL");

        public static readonly PayPaymentProvider STRIPE
            = new PayPaymentProvider("STRIPE");

        public static readonly PayPaymentProvider WALLET
            = new PayPaymentProvider("WALLET");

        public static readonly PayPaymentProvider WXPAY
            = new PayPaymentProvider("WXPAY");

        public static readonly PayPaymentProvider XSOLLA
            = new PayPaymentProvider("XSOLLA");


        public static implicit operator PayPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public PayPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}