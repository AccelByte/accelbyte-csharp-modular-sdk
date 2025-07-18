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
    /// debugMatchedPaymentMerchantConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Debug matched payment merchant config.
    /// Other detail info:
    /// 
    ///   * Returns : payment merchant config info
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

                op.SetBaseFields<DebugMatchedPaymentMerchantConfigBuilder>(this);
                return op;
            }

            public DebugMatchedPaymentMerchantConfig.Response Execute(
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
            public async Task<DebugMatchedPaymentMerchantConfig.Response> ExecuteAsync(
            )
            {
                DebugMatchedPaymentMerchantConfig op = Build(
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

        private DebugMatchedPaymentMerchantConfig(DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            
            if (builder.Namespace is not null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentMerchantConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentConfig::DebugMatchedPaymentMerchantConfig";
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

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public DebugMatchedPaymentMerchantConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DebugMatchedPaymentMerchantConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload, ResponseJsonOptions);
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