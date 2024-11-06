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
    /// getPaymentTaxValue
    ///
    ///  [Not supported yet in AGS Shared Cloud] Check and get a payment order's should pay tax.
    /// Other detail info:
    /// 
    ///   * Returns : tax result
    /// </summary>
    public class GetPaymentTaxValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentTaxValueBuilder Builder { get => new GetPaymentTaxValueBuilder(); }

        public class GetPaymentTaxValueBuilder
            : OperationBuilder<GetPaymentTaxValueBuilder>
        {

            public string? ZipCode { get; set; }





            internal GetPaymentTaxValueBuilder() { }

            internal GetPaymentTaxValueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetPaymentTaxValueBuilder SetZipCode(string _zipCode)
            {
                ZipCode = _zipCode;
                return this;
            }





            public GetPaymentTaxValue Build(
                string namespace_,
                string paymentOrderNo,
                GetPaymentTaxValuePaymentProvider paymentProvider
            )
            {
                GetPaymentTaxValue op = new GetPaymentTaxValue(this,
                    namespace_,                    
                    paymentOrderNo,                    
                    paymentProvider                    
                );

                op.SetBaseFields<GetPaymentTaxValueBuilder>(this);
                return op;
            }

            public GetPaymentTaxValue.Response Execute(
                string namespace_,
                string paymentOrderNo,
                string paymentProvider
            )
            {
                GetPaymentTaxValue op = Build(
                    namespace_,
                    paymentOrderNo,
                    paymentProvider
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetPaymentTaxValue.Response> ExecuteAsync(
                string namespace_,
                string paymentOrderNo,
                string paymentProvider
            )
            {
                GetPaymentTaxValue op = Build(
                    namespace_,
                    paymentOrderNo,
                    paymentProvider
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

        private GetPaymentTaxValue(GetPaymentTaxValueBuilder builder,
            string namespace_,
            string paymentOrderNo,
            GetPaymentTaxValuePaymentProvider paymentProvider
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ZipCode is not null) QueryParams["zipCode"] = builder.ZipCode;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            

            
            
            

        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TaxResult>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentStation::GetPaymentTaxValue";
        }

        #endregion

        public GetPaymentTaxValue(
            string namespace_,            
            string? zipCode,            
            string paymentOrderNo,            
            GetPaymentTaxValuePaymentProvider paymentProvider            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (zipCode is not null) QueryParams["zipCode"] = zipCode;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetPaymentTaxValue.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPaymentTaxValue.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.TaxResult>(payload, ResponseJsonOptions);
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

            return response;
        }
    }

    public class GetPaymentTaxValuePaymentProvider : StringEnum<GetPaymentTaxValuePaymentProvider>
    {
        public static readonly GetPaymentTaxValuePaymentProvider ADYEN
            = new GetPaymentTaxValuePaymentProvider("ADYEN");

        public static readonly GetPaymentTaxValuePaymentProvider ALIPAY
            = new GetPaymentTaxValuePaymentProvider("ALIPAY");

        public static readonly GetPaymentTaxValuePaymentProvider CHECKOUT
            = new GetPaymentTaxValuePaymentProvider("CHECKOUT");

        public static readonly GetPaymentTaxValuePaymentProvider NEONPAY
            = new GetPaymentTaxValuePaymentProvider("NEONPAY");

        public static readonly GetPaymentTaxValuePaymentProvider PAYPAL
            = new GetPaymentTaxValuePaymentProvider("PAYPAL");

        public static readonly GetPaymentTaxValuePaymentProvider STRIPE
            = new GetPaymentTaxValuePaymentProvider("STRIPE");

        public static readonly GetPaymentTaxValuePaymentProvider WALLET
            = new GetPaymentTaxValuePaymentProvider("WALLET");

        public static readonly GetPaymentTaxValuePaymentProvider WXPAY
            = new GetPaymentTaxValuePaymentProvider("WXPAY");

        public static readonly GetPaymentTaxValuePaymentProvider XSOLLA
            = new GetPaymentTaxValuePaymentProvider("XSOLLA");


        public static implicit operator GetPaymentTaxValuePaymentProvider(string value)
        {
            return NewValue(value);
        }

        public GetPaymentTaxValuePaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}