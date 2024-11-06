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
    /// updateCheckoutConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update checkout.com config.
    /// Other detail info:
    /// 
    ///   * Returns : updated payment merchant config
    /// </summary>
    public class UpdateCheckoutConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCheckoutConfigBuilder Builder { get => new UpdateCheckoutConfigBuilder(); }

        public class UpdateCheckoutConfigBuilder
            : OperationBuilder<UpdateCheckoutConfigBuilder>
        {

            public bool? Sandbox { get; set; }

            public bool? Validate { get; set; }





            internal UpdateCheckoutConfigBuilder() { }

            internal UpdateCheckoutConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public UpdateCheckoutConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }

            public UpdateCheckoutConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }





            public UpdateCheckoutConfig Build(
                CheckoutConfig body,
                string id
            )
            {
                UpdateCheckoutConfig op = new UpdateCheckoutConfig(this,
                    body,                    
                    id                    
                );

                op.SetBaseFields<UpdateCheckoutConfigBuilder>(this);
                return op;
            }

            public UpdateCheckoutConfig.Response Execute(
                CheckoutConfig body,
                string id
            )
            {
                UpdateCheckoutConfig op = Build(
                    body,
                    id
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateCheckoutConfig.Response> ExecuteAsync(
                CheckoutConfig body,
                string id
            )
            {
                UpdateCheckoutConfig op = Build(
                    body,
                    id
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

        private UpdateCheckoutConfig(UpdateCheckoutConfigBuilder builder,
            CheckoutConfig body,
            string id
        )
        {
            PathParams["id"] = id;
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PaymentMerchantConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::PaymentConfig::UpdateCheckoutConfig";
        }

        #endregion

        public UpdateCheckoutConfig(
            string id,            
            bool? sandbox,            
            bool? validate,            
            Model.CheckoutConfig body            
        )
        {
            PathParams["id"] = id;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/checkoutconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateCheckoutConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateCheckoutConfig.Response()
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