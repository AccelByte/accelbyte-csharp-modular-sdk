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
    /// testPayPalConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Test PayPal configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * clientID
    ///   * clientSecret
    /// 
    /// 
    /// 
    /// #### Non-check list:
    /// 
    ///   * webHookId
    /// 
    /// Other detail info:
    ///   * Returns : test result
    /// </summary>
    public class TestPayPalConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestPayPalConfigBuilder Builder { get => new TestPayPalConfigBuilder(); }

        public class TestPayPalConfigBuilder
            : OperationBuilder<TestPayPalConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestPayPalConfigBuilder() { }

            internal TestPayPalConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestPayPalConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestPayPalConfig Build(
                PayPalConfig body
            )
            {
                TestPayPalConfig op = new TestPayPalConfig(this,
                    body                    
                );

                op.SetBaseFields<TestPayPalConfigBuilder>(this);
                return op;
            }

            public TestPayPalConfig.Response Execute(
                PayPalConfig body
            )
            {
                TestPayPalConfig op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<TestPayPalConfig.Response> ExecuteAsync(
                PayPalConfig body
            )
            {
                TestPayPalConfig op = Build(
                    body
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

        private TestPayPalConfig(TestPayPalConfigBuilder builder,
            PayPalConfig body
        )
        {
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.TestResult>
        {


            protected override string GetFullOperationId() => "Platform::PaymentConfig::TestPayPalConfig";
        }

        #endregion

        public TestPayPalConfig(
            bool? sandbox,            
            Model.PayPalConfig body            
        )
        {
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/paypalconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public TestPayPalConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new TestPayPalConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}