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
    /// testCheckoutConfig
    ///
    ///  [Not supported yet in AGS Shared Cloud] Test checkout.com configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * publicKey
    ///   * secretKey
    /// 
    /// Other detail info:
    ///   * Returns : test result
    /// </summary>
    public class TestCheckoutConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestCheckoutConfigBuilder Builder { get => new TestCheckoutConfigBuilder(); }

        public class TestCheckoutConfigBuilder
            : OperationBuilder<TestCheckoutConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestCheckoutConfigBuilder() { }

            internal TestCheckoutConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public TestCheckoutConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestCheckoutConfig Build(
                CheckoutConfig body
            )
            {
                TestCheckoutConfig op = new TestCheckoutConfig(this,
                    body
                );

                op.SetBaseFields<TestCheckoutConfigBuilder>(this);
                return op;
            }

            public Model.TestResult? Execute(
                CheckoutConfig body
            )
            {
                TestCheckoutConfig op = Build(
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
                CheckoutConfig body
            )
            {
                TestCheckoutConfig op = Build(
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

        private TestCheckoutConfig(TestCheckoutConfigBuilder builder,
            CheckoutConfig body
        )
        {

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestCheckoutConfig(
            bool? sandbox,
            Model.CheckoutConfig body
        )
        {

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/checkoutconfig/test";

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