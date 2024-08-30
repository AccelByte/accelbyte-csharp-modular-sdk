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
    /// testAdyenConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Test adyen configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * apiKey
    ///   * merchantAccount
    /// 
    /// 
    /// 
    /// #### Non-check list:
    /// 
    ///   * notificationHmacKey
    ///   * notificationUsername
    ///   * notificationPassword
    ///   * liveEndpointUrlPrefix
    ///   * allowedPaymentMethods
    ///   * blockedPaymentMethods
    ///   * settings
    /// 
    /// Other detail info:
    ///   * Returns : test adyen config
    /// </summary>
    public class TestAdyenConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestAdyenConfigBuilder Builder { get => new TestAdyenConfigBuilder(); }

        public class TestAdyenConfigBuilder
            : OperationBuilder<TestAdyenConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestAdyenConfigBuilder() { }

            internal TestAdyenConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestAdyenConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestAdyenConfig Build(
                AdyenConfig body
            )
            {
                TestAdyenConfig op = new TestAdyenConfig(this,
                    body                    
                );

                op.SetBaseFields<TestAdyenConfigBuilder>(this);
                return op;
            }

            public Model.TestResult? Execute(
                AdyenConfig body
            )
            {
                TestAdyenConfig op = Build(
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
            public async Task<Model.TestResult?> ExecuteAsync(
                AdyenConfig body
            )
            {
                TestAdyenConfig op = Build(
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

        private TestAdyenConfig(TestAdyenConfigBuilder builder,
            AdyenConfig body
        )
        {
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestAdyenConfig(
            bool? sandbox,            
            Model.AdyenConfig body            
        )
        {
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/adyenconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.TestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}