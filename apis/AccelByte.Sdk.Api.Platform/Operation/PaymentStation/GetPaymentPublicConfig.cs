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
    /// getPaymentPublicConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Get payment provider public config, at current only Strip provide public config.
    /// Other detail info:
    /// 
    ///   * Returns : Public config
    /// </summary>
    public class GetPaymentPublicConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentPublicConfigBuilder Builder { get => new GetPaymentPublicConfigBuilder(); }

        public class GetPaymentPublicConfigBuilder
            : OperationBuilder<GetPaymentPublicConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal GetPaymentPublicConfigBuilder() { }

            internal GetPaymentPublicConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetPaymentPublicConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public GetPaymentPublicConfig Build(
                string namespace_,
                GetPaymentPublicConfigPaymentProvider paymentProvider,
                string region
            )
            {
                GetPaymentPublicConfig op = new GetPaymentPublicConfig(this,
                    namespace_,
                    paymentProvider,
                    region
                );

                op.SetBaseFields<GetPaymentPublicConfigBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_,
                string paymentProvider,
                string region
            )
            {
                GetPaymentPublicConfig op = Build(
                    namespace_,
                    paymentProvider,
                    region
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Dictionary<string, object>?> ExecuteAsync(
                string namespace_,
                string paymentProvider,
                string region
            )
            {
                GetPaymentPublicConfig op = Build(
                    namespace_,
                    paymentProvider,
                    region
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

        private GetPaymentPublicConfig(GetPaymentPublicConfigBuilder builder,
            string namespace_,
            GetPaymentPublicConfigPaymentProvider paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;






        }
        #endregion

        public GetPaymentPublicConfig(
            string namespace_,
            bool? sandbox,
            GetPaymentPublicConfigPaymentProvider paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;






        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/publicconfig";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetPaymentPublicConfigPaymentProvider : StringEnum<GetPaymentPublicConfigPaymentProvider>
    {
        public static readonly GetPaymentPublicConfigPaymentProvider ADYEN
            = new GetPaymentPublicConfigPaymentProvider("ADYEN");

        public static readonly GetPaymentPublicConfigPaymentProvider ALIPAY
            = new GetPaymentPublicConfigPaymentProvider("ALIPAY");

        public static readonly GetPaymentPublicConfigPaymentProvider CHECKOUT
            = new GetPaymentPublicConfigPaymentProvider("CHECKOUT");

        public static readonly GetPaymentPublicConfigPaymentProvider NEONPAY
            = new GetPaymentPublicConfigPaymentProvider("NEONPAY");

        public static readonly GetPaymentPublicConfigPaymentProvider PAYPAL
            = new GetPaymentPublicConfigPaymentProvider("PAYPAL");

        public static readonly GetPaymentPublicConfigPaymentProvider STRIPE
            = new GetPaymentPublicConfigPaymentProvider("STRIPE");

        public static readonly GetPaymentPublicConfigPaymentProvider WALLET
            = new GetPaymentPublicConfigPaymentProvider("WALLET");

        public static readonly GetPaymentPublicConfigPaymentProvider WXPAY
            = new GetPaymentPublicConfigPaymentProvider("WXPAY");

        public static readonly GetPaymentPublicConfigPaymentProvider XSOLLA
            = new GetPaymentPublicConfigPaymentProvider("XSOLLA");


        public static implicit operator GetPaymentPublicConfigPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public GetPaymentPublicConfigPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}