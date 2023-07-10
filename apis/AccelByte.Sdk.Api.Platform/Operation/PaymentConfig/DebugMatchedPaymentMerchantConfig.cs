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
    /// debugMatchedPaymentMerchantConfig
    ///
    /// Debug matched payment merchant config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment merchant config info
    /// </summary>
    public class DebugMatchedPaymentMerchantConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebugMatchedPaymentMerchantConfigBuilder Builder { get => new DebugMatchedPaymentMerchantConfigBuilder(); }

        public class DebugMatchedPaymentMerchantConfigBuilder
            : OperationBuilder<DebugMatchedPaymentMerchantConfigBuilder>
        {

            public string? Namespace { get; set; }

            public string? Region { get; set; }





            internal DebugMatchedPaymentMerchantConfigBuilder() { }

            internal DebugMatchedPaymentMerchantConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DebugMatchedPaymentMerchantConfigBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public DebugMatchedPaymentMerchantConfigBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public DebugMatchedPaymentMerchantConfig Build(
            )
            {
                DebugMatchedPaymentMerchantConfig op = new DebugMatchedPaymentMerchantConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.PaymentMerchantConfigInfo? Execute(
            )
            {
                DebugMatchedPaymentMerchantConfig op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DebugMatchedPaymentMerchantConfig(DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {

            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DebugMatchedPaymentMerchantConfig(
            string? namespace_,
            string? region
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;
            if (region is not null) QueryParams["region"] = region;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/matched";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}