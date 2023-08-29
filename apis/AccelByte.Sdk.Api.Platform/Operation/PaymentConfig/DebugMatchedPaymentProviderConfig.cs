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
    /// debugMatchedPaymentProviderConfig
    ///
    /// Debug matched payment provider config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider config
    /// </summary>
    public class DebugMatchedPaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebugMatchedPaymentProviderConfigBuilder Builder { get => new DebugMatchedPaymentProviderConfigBuilder(); }

        public class DebugMatchedPaymentProviderConfigBuilder
            : OperationBuilder<DebugMatchedPaymentProviderConfigBuilder>
        {

            public string? Namespace { get; set; }

            public string? Region { get; set; }





            internal DebugMatchedPaymentProviderConfigBuilder() { }

            internal DebugMatchedPaymentProviderConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public DebugMatchedPaymentProviderConfigBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public DebugMatchedPaymentProviderConfigBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public DebugMatchedPaymentProviderConfig Build(
            )
            {
                DebugMatchedPaymentProviderConfig op = new DebugMatchedPaymentProviderConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.PaymentProviderConfigInfo? Execute(
            )
            {
                DebugMatchedPaymentProviderConfig op = Build(
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

        private DebugMatchedPaymentProviderConfig(DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            
            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DebugMatchedPaymentProviderConfig(
            string? namespace_,            
            string? region            
        )
        {
            
            if (namespace_ is not null) QueryParams["namespace"] = namespace_;
            if (region is not null) QueryParams["region"] = region;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider/matched";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.PaymentProviderConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}